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


End Class