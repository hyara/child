Public Class AdministratorForm

    Public move_info As String
    Private sqlConnect As SQLConnectClass

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
            'f.SetID(sql)
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

    'ここまで追加ボタン




    Private Sub BnfImgBtnLoad_Click(sender As Object, e As EventArgs) Handles BnfImgBtnLoad.Click

        If sqlConnectChecker() = False Then
            MessageBox.Show("SQL接続中です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return  ' sql接続不可により終了
        End If

        ' プログレスバーを出現させる
        Dim pF As New ProgressStatesForm
        pF.Show() : pF.ProgressStatesMaxSet(2)
        pF.ProgressStatesLabelUpdate("SQL接続完了")

        sqlConnect.DBConnect(Month_0to1_show_sql())
        pF.ProgressStatesLabelUpdate("DB一覧取得完了")


        ' DBからの情報をDataGridViewに上書き反映させる
        Dim ds As DataSet = sqlConnect.DBResult
        DataGridView.Rows.Clear()
        For Each row As DataRow In ds.Tables(0).Rows
            DataGridView.Rows.Add(row.ItemArray)
        Next row

        'プログレスバーを閉じる
        pF.ProgressStatesEnd()
    End Sub

    Private Function Month_0to1_show_sql() As String
        Dim sqlString As String
        sqlString = _
            "SELECT " _
                & "month_main_0to1_id AS 書類番号, " _
                & "ClassName AS クラス名, " _
                & "LeaderName AS 指導者名, " _
                & "UpdateDate AS 更新日, " _
                & "CreatedDate AS 作成日 " _
            & "FROM `child_monthplan_main_0to1`;"
        Return sqlString
    End Function

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

        ' クリックされたボタンからidを取得
        Dim id As String = GetClickCellButtonContent(sender, e)

        ' 準備済みの閲覧用ダミーフォームに月案情報を送り込む
        If id <> "" Then
            '関数に引数がつけれないため一時退避
            Dim f As New Month1AgeShownDummy
            Me.Enabled = False
            f.Show(Me)
            f.SetID(id, sqlConnect)
            '関数おわり
        End If
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
    End Sub


End Class