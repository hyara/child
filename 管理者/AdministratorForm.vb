Public Class AdministratorForm

    Public move_info As String

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
    End Sub

    Private Sub MoveMonthLow()
        Dim f As New Month1Age
        Me.Enabled = False
        f.Show(Me)
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
        Dim sql As New SQLConnectClass

        pF.ProgressStatesLabelUpdate()
        pF.ProcessContentsSet("SQL接続完了")

        sql.DBConnect(Month_0to1_show_sql())

        pF.ProgressStatesLabelUpdate()
        pF.ProcessContentsSet("DB一覧取得完了")

        Dim ds As DataSet = sql.DBResult

        'DataGridView.DataSource = ds.Tables(0).Rows

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

End Class