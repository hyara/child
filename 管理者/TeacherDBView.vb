Public Class TeacherDBView
    Dim sqlConnect As SQLConnectClass
    Dim move_info As String

    Public Sub SetID(s As SQLConnectClass)
        sqlConnect = s
    End Sub

    Public Sub MoveInfoSetter(mInfo As String)
        Me.move_info = mInfo
    End Sub
    Public Function MoveInfoGetter() As String
        Return Me.move_info
    End Function

    Public Sub MoveForm()
        Select Case MoveInfoGetter()
            Case "TeacherEdit"
                MoveTeacherEdit()
        End Select
    End Sub

    Private Sub MoveTeacherEdit()
        Dim f As New TeacherEdit
        Me.Enabled = False
        f.Show(Me)
        f.SetID(sqlConnect)
    End Sub

    Private Sub BnfImgBtnClose_Click(sender As Object, e As EventArgs) Handles BnfImgBtnClose.Click
        Me.Close()
    End Sub

    Private Sub TeacherDBView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub BnfFlatBtnRegister_Click(sender As Object, e As EventArgs) Handles BnfFlatBtnRegister.Click
        MoveInfoSetter("TeacherEdit")
        MoveForm()
    End Sub
End Class