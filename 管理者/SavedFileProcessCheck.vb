Public Class SavedFileProcessCheck

    Private rslt As Integer

    Public Sub SetName(s As String)
        LabelName.Text = s
    End Sub

    Public Function Result() As Integer
        Return rslt
    End Function

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        rslt = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        rslt = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        rslt = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SavedFileProcessCheck_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub
End Class