Public Class AdministratorForm

    Public move_info As String
    Private sqlConnect As SQLConnectClass
    Private searchDim As SearchSharedDim
    Private infoSetter

    ''' <summary>
    ''' SQL接続の可否を取得します。
    ''' </summary>
    ''' <returns>True: 接続完了 False: 未接続</returns>
    ''' <remarks></remarks>
    Public Function sqlConnectChecker() As Boolean
        If BackgroundWorkerSQLConnect.IsBusy = False Then
            Return True
        End If
        Return False
    End Function

    Private Sub AdministratorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SQL接続を開始する
        BackgroundWorkerSQLConnect.RunWorkerAsync()
        searchDim = New SearchSharedDim
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs)
        Dim TargetForm As New SelectAddDocument '遷移先
        '表示するフォームのみ操作可能とする
        MoveInfoSetter("SelectAddDocument")
        MoveForm()
    End Sub

    '追加用コピペページ
    ' 他フォームから動かす奴
    Public Sub MoveInfoSetter(mInfo As String)
        Me.move_info = mInfo
    End Sub
    Public Function MoveInfoGetter() As String
        Return Me.move_info
    End Function

    Public Sub MoveForm()
        Select Case MoveInfoGetter()
            Case "SelectAddDocument"
                MoveSelectAddDocument()
            Case "Month35Age"
                MoveMonth3to5Age()
            Case "Month1Age"
                MoveMonth0to1Age()
            Case "Month2Age"
                MoveMonth2Age()
            Case "StaffRegister"
                MoveStaffRegister()
            Case "SearchSelect"
                MoveSearchSelect()
            Case "ChildTable"
                MoveChildTable()
        End Select
    End Sub

    Private Sub BnfImgBtnNewCreate_Click(sender As Object, e As EventArgs) Handles BnfImgBtnNewCreate.Click
        MoveInfoSetter("SelectAddDocument")
        MoveForm()
    End Sub

    Private Sub MoveMonth3to5Age()
        If sqlConnectChecker() = False Then
            MessageBox.Show("SQL接続中です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return  ' sql接続不可により終了
        Else
            Dim f As New Month35Age
            Me.Enabled = False
            f.Show(Me)
            f.SetID(sqlConnect)
        End If
    End Sub

    Private Sub MoveMonth0to1Age()
        If sqlConnectChecker() = False Then
            MessageBox.Show("SQL接続中です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return  ' sql接続不可により終了
        Else
            Dim f As New Month1Age
            Me.Enabled = False
            f.Show(Me)
            f.SetID(sqlConnect)
        End If
    End Sub

    Private Sub MoveMonth2Age()
        If sqlConnectChecker() = False Then
            MessageBox.Show("SQL接続中です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return  ' sql接続不可により終了
        Else
            Dim f As New Month2Age
            Me.Enabled = False
            f.Show(Me)
            f.SetID(sqlConnect)
        End If
    End Sub

    Private Sub MoveSelectAddDocument()
        Dim f As New SelectAddDocument
        Me.Enabled = False
        f.Show(Me)
    End Sub

    Private Sub MoveStaffRegister()
        If sqlConnectChecker() = False Then
            MessageBox.Show("SQL接続中です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return  ' sql接続不可により終了
        Else
            Dim f As New TeacherDBView
            Me.Enabled = False
            f.Show(Me)
            f.SetID(sqlConnect)
        End If
    End Sub

    Private Sub MoveSearchSelect()
        Dim f As New SearchSelect
        Me.Enabled = False
        f.Show(Me)
    End Sub
    Private Sub MoveChildTable()
        If sqlConnectChecker() = False Then
            MessageBox.Show("SQL接続中です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return  ' sql接続不可により終了
        Else
            Dim f As New ChildInfoAdd
            Me.Enabled = False
            f.Show(Me)
            f.SetID(sqlConnect)
        End If
    End Sub
    'ここまで追加ボタン

    Private Sub BnfImgBtnLoad_Click(sender As Object, e As EventArgs) Handles BnfImgBtnLoad.Click
        Dim search As New SearchChild(sqlConnect)
        search.SearchExe(DataGridView)
    End Sub

    Private Function Month_0to1_show_sql() As String
        Dim sqlString As String
        sqlString = _
            "SELECT " _
                & "month_main_0to1_id AS 書類番号, " _
                & "'月案0～1歳' AS Type, " _
                & "ClassName AS クラス名, " _
                & "LeaderName AS 指導者名, " _
                & "UpdateDate AS 更新日, " _
                & "CreatedDate AS 作成日 " _
            & "FROM `child_monthplan_main_0to1`;"
        Return sqlString
    End Function

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        Dim btnNum As String = GetClickCellButtonContent(sender, e)
        If btnNum <> "" Then
            Dim type As String = GetCellChildInfo(sender, e)
            Dim fSel As New ChildInfoSelect

            Me.Enabled = False

            fSel.SetName(type, btnNum)
            fSel.ShowDialog(Me)

            Select Case fSel.Result()
                Case DialogResult.OK
                    EditChildFile(btnNum, type)

                Case DialogResult.Yes
                    DeleteChildFile(btnNum, type)
                    Dim search As New SearchChild(sqlConnect)
                    search.SearchExe(DataGridView)

                Case DialogResult.Cancel
            End Select

        End If
    End Sub
    Private Sub DeleteChildFile(btnNum As String, type As String)
        Dim sqlString As String = ""
        Select Case type
            Case "月案0～1歳"
                sqlString = "DELETE FROM `child_monthplan_main_0to1` WHERE month_main_0to1_id = " & btnNum & ";"

            Case "月案2歳"
                sqlString = "DELETE FROM `child_monthplan_main_2to2` WHERE month_main_2to2_id = " & btnNum & ";"

            Case "月案3～5歳"
                sqlString = "DELETE FROM `child_monthplan_main_3to5` WHERE month_main_3to5_id = " & btnNum & ";"

            Case "週案0～5歳"
                sqlString = "DELETE FROM `child_weekplan_main_0to5` WHERE week_main_0to5_id = " & btnNum & ";"
        End Select
        If sqlString <> "" Then sqlConnect.DBConnect(sqlString)
    End Sub
    Private Sub EditChildFile(btnNum As String, type As String)
        Select Case type
            Case "月案0～1歳"
                Dim f As New Month1Age

                Me.Enabled = False
                f.Show(Me)
                f.MonthDBDraw(btnNum, sqlConnect)
                f.SetID(sqlConnect)

            Case "月案2歳"
                Dim f As New Month2Age

                Me.Enabled = False
                f.Show(Me)
                f.MonthDBDraw(btnNum, sqlConnect)
                f.SetID(sqlConnect)

            Case "月案3～5歳"
                Dim f As New Month35Age

                Me.Enabled = False
                f.Show(Me)
                f.MonthDBDraw(btnNum, sqlConnect)
                f.SetID(sqlConnect)

            Case "週案0～5歳"
        End Select
    End Sub

    ''' <summary>
    ''' 必要物が全てハードコーティング済みのDataGridViewから、
    ''' クリックされたボタンの内容を取得する。
    ''' </summary>
    ''' <param name="sender">senderそのまま代入</param>
    ''' <param name="e">eventそのまま代入</param>
    ''' <returns>クリックされたボタンの内容</returns>
    ''' <remarks></remarks>
    Private Function GetClickCellButtonContent(sender As Object, e As DataGridViewCellEventArgs) As String
        Dim dgv As DataGridView = CType(sender, DataGridView)
        '"id"列ならば、ボタンがクリックされた
        If dgv.Columns(e.ColumnIndex).Name = "id" Then
            Dim num As Integer
            If Integer.TryParse(e.RowIndex.ToString(), num) = False Then
                num = -1
            End If
            If -1 < num Then
                '現在指定しているセルの内容を取得する
                Return DataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            End If
        End If
        Return ""
    End Function

    ''' <summary>
    ''' 必要物が全てハードコーティング済みのDataGridViewから、
    ''' クリックされたボタンの児童表の種類を取得する。
    ''' </summary>
    ''' <param name="sender">senderそのまま代入</param>
    ''' <param name="e">eventそのまま代入</param>
    ''' <returns>クリックされたボタンに対する児童表の内容</returns>
    ''' <remarks></remarks>
    Private Function GetCellChildInfo(sender As Object, e As DataGridViewCellEventArgs) As String
        Dim dgv As DataGridView = CType(sender, DataGridView)
        '"id"列ならば、ボタンがクリックされた
        If dgv.Columns(e.ColumnIndex).Name = "id" Then
            Dim num As Integer
            If Integer.TryParse(e.RowIndex.ToString(), num) = False Then
                num = -1
            End If
            If -1 < num Then
                '現在指定しているセルの内容を取得する
                Return DataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value.ToString()
            End If
        End If
        Return ""
    End Function

    Private Sub BnfImgBtnClose_Click(sender As Object, e As EventArgs) Handles BnfImgBtnClose.Click
        Me.Close()
    End Sub

    Private Sub BackgroundWorkerSQLConnect_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSQLConnect.DoWork
        Me.sqlConnect = New SQLConnectClass
    End Sub

    Private Sub BackgroundWorkerSQLConnect_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSQLConnect.RunWorkerCompleted
        LabelSQLStatus.Text = "SQL接続完了!!"
        System.Threading.Thread.Sleep(200)
        LabelSQLStatus.Text = ""
        Dim search As New SearchChild(sqlConnect)
        search.SearchExe(DataGridView)
    End Sub


    Private Sub BnfFlatBtnRegister_Click(sender As Object, e As EventArgs) Handles BnfFlatBtnRegister.Click
        MoveInfoSetter("StaffRegister")
        MoveForm()
    End Sub

    Private Sub BnfFlatBtnSimpleSortAny_Click(sender As Object, e As EventArgs) Handles BnfFlatBtnSimpleSortAny.Click
        MoveInfoSetter("SearchSelect")
        MoveForm()
    End Sub

    Private Sub BnfFlatBtnChildTable_Click(sender As Object, e As EventArgs) Handles BnfFlatBtnChildTable.Click
        MoveInfoSetter("ChildTable")
        MoveForm()
    End Sub


    Private Sub BnfFlatBtnSearch_Click(sender As Object, e As EventArgs) Handles BnfFlatBtnSearch.Click
        Dim search As New SearchChild(sqlConnect)
        search.SearchExe(DataGridView)
    End Sub


    Private Sub TextBoxSearchTitle_MouseLeave(sender As Object, e As EventArgs) Handles TextBoxSearchTitle.MouseLeave
        Dim t As TextBox = TextBoxSearchTitle
        If String.IsNullOrWhiteSpace(t.Text) = False Then
            SearchSharedDim.className = t.Text
        Else
            t.Text = ""
            SearchSharedDim.className = ""
        End If
    End Sub
End Class