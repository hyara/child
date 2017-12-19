Public Class SelectAddDocument
    Inherits BaseForm '★System.Windows.Forms.Form から BaseForm に変更
    '終了処理
    Private Sub SelectAddDocument_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Owner.Enabled = True
        Me.Dispose()
    End Sub
    '--------------------------------------------------------------------------------
    'ボタン押下の動作

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim form1 As New AdministratorForm '遷移先
        Owner.Enabled = True

        'メモリ開放も行う方の閉じる()a
        Me.Close()
    End Sub
    'ここまでボタン押下動作
    '------------------------------------------------------------


    'ここから移動用
    '------------------------------------------------------------

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("Month35Age")
        f.MoveForm()
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("Month1Age")
        f.MoveForm()
        Me.Close()
    End Sub


    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("Month2Age")
        f.MoveForm()
        Me.Close()
    End Sub

    'ここまで移動用
    '---------------------------------------------------------------------

    Private Sub BnfFlatButtonMonth3to5_Click(sender As Object, e As EventArgs) Handles BnfFlatButtonMonth3to5.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub BnfFlatButtonMonth0to1_Click(sender As Object, e As EventArgs) Handles BnfFlatButtonMonth0to1.Click





    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("Month2Age")
        f.MoveForm()
        Me.Close()
    End Sub

    Private Sub BnfImgBtnClose_Click(sender As Object, e As EventArgs) Handles BnfImgBtnClose.Click
        Me.Close()
    End Sub
End Class
