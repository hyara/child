Public Class AdministratorForm

    Public move_info As String
    Dim sql As New SQLConnectClass

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

    Public Function SQLConnectGetter() As SQLConnectClass
        Return sql
    End Function

    Public Sub MoveForm()

        Select Case MoveInfoGetter()
            Case "SelectAddDocument"
                MoveSelectAddDocument()
            Case "MonthHigh"
                MoveMonthHigh()
            Case "MonthLow"
                MoveMonthLow()
            Case "WeekHigh"
                MoveWeekHigh()
            Case "WeekLow"
                MoveWeekLow()

        End Select

    End Sub
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        MoveInfoSetter("SelectAddDocument")
        MoveForm()
    End Sub

    Private Sub MoveMonthHigh()
        Dim f As New Month35Age
        Me.Enabled = False
        f.Show(Me)
        f.SetID(sql)
    End Sub

    Private Sub MoveMonthLow()
        Dim f As New Month1Age
        Me.Enabled = False
        f.Show(Me)
        f.SetID(sql)
    End Sub

    Private Sub MoveWeekLow()
        Dim f As New Week01
        Me.Enabled = False
        f.Show(Me)
    End Sub

    Private Sub MoveWeekHigh()
        Dim f As New Week25
        Me.Enabled = False
        f.Show(Me)
    End Sub

    Private Sub MoveSelectAddDocument()
        Dim f As New SelectAddDocument
        Me.Enabled = False
        f.Show(Me)
    End Sub

    'ここまで追加ボタン


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim pF As New ProgressStatesForm
        pF.Show()
        pF.ProgressStatesMaxSet(2)

        pF.ProgressStatesLabelUpdate()
        pF.ProcessContentsSet("SQL接続完了")

        sql.DBConnect(Month_0to1_show_sql())

        pF.ProgressStatesLabelUpdate()
        pF.ProcessContentsSet("DB一覧取得完了")

        Dim ds As DataSet = sql.DBResult

        'DataGridView.DataSource = ds.Tables(0).Rows
        DataGridView.Rows.Clear()
        For Each row As DataRow In ds.Tables(0).Rows

            DataGridView.Rows.Add(row.ItemArray)
        Next row

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
            f.SetID(id, sql)
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
End Class