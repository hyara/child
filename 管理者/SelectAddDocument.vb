Public Class SelectAddDocument
    Inherits BaseForm '★System.Windows.Forms.Form から BaseForm に変更
    '終了処理
    Private Sub SelectAddDocument_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Owner.Enabled = True
        Me.Dispose()
    End Sub

    'ここから移動用
    '------------------------------------------------------------

    Private Sub Button3to5_Click(sender As Object, e As EventArgs) Handles Button3to5.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("Month35Age")
        f.MoveForm()
        Me.Close()
    End Sub

    Private Sub Button0to1_Click(sender As Object, e As EventArgs) Handles Button0to1.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("Month1Age")
        f.MoveForm()
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("Month2Age")
        f.MoveForm()
        Me.Close()
    End Sub

    'ここまで移動用
    '---------------------------------------------------------------------

    Private Sub BnfImgBtnClose_Click(sender As Object, e As EventArgs) Handles BnfImgBtnClose.Click
        Me.Close()
    End Sub
End Class

