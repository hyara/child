Public Class ChildInfoSelect

    Private rslt As Integer

    Public Function Result() As Integer
        Return rslt
    End Function

    Public Sub SetName(type As String, name As String)
        LabelInfoType.Text = type
        LabelInfoName.Text = name
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        rslt = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        rslt = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        rslt = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        rslt = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub ChildInfoSelect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub
End Class