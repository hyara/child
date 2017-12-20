Public Class SelectAddDocument
    Inherits BaseForm '★System.Windows.Forms.Form から BaseForm に変更
    '終了処理
    Private Sub SelectAddDocument_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Owner.Enabled = True
        Me.Dispose()
    End Sub
    '--------------------------------------------------------------------------------
    'ボタン押下の動作
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)

        Dim form1 As New AdministratorForm '遷移先
        Owner.Enabled = True

        'メモリ開放も行う方の閉じる()
        Me.Dispose()
    End Sub


    'ここまでボタン押下動作
    '------------------------------------------------------------


    'ここから移動用
    '------------------------------------------------------------

    Private Sub ButtonMonthHigh_Click(sender As Object, e As EventArgs)
        Dim a As AdministratorForm
        a = Owner
        a.MoveInfoSetter("MonthHigh")
        a.MoveForm()
        Me.Dispose()
    End Sub
    Private Sub ButtonMonthLow_Click(sender As Object, e As EventArgs)
        Dim b As AdministratorForm
        b = Owner
        b.MoveInfoSetter("MonthLow")
        b.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub ButtonWeekLow_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("WeekLow")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub ButtonWeekHigh_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("WeekHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub
    'ここまで移動用
    '---------------------------------------------------------------------






    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(2)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthLow")
        f.MoveForm()
        Me.Dispose()
    End Sub


    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthLow")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub BunifuGradientPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("WeekLow")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("WeekHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub


    Private Sub BunifuFlatButton4_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthLow")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs)
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub



    Private Sub BunifuThinButton25_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthLow")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Dim f As AdministratorForm
        f = Owner
        f.MoveInfoSetter("MonthHigh")
        f.MoveForm()
        Me.Dispose()
    End Sub

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(2)
    End Sub

    Private Sub ButtonDay_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub BunifuFlatButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        TabControl1.SelectTab(0)
    End Sub
End Class

