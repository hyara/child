Public Class Week01
    Private Sub Week01_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub
    Private Sub TextMen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMen.KeyPress
        '押されたキーが「0～9でない場合」かつ「BackSpaceでない場合」イベントをキャンセルする
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        TextMen.MaxLength = 2
    End Sub

    Private Sub TextWomen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextWomen.KeyPress
        '押されたキーが「0～9でない場合」かつ「BackSpaceでない場合」イベントをキャンセルする
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        TextWomen.MaxLength = 2
    End Sub

    Private Sub TextMen_TextChanged(sender As Object, e As EventArgs) Handles TextMen.TextChanged
        Dim men As String = TextMen.Text
        Dim women As String = TextWomen.Text
        If men <> "" And women <> "" Then
            LabelSum.Text = Integer.Parse(TextMen.Text) + Integer.Parse(TextWomen.Text)
        End If
    End Sub


    Private Sub TextWomen_TextChanged(sender As Object, e As EventArgs) Handles TextWomen.TextChanged
        Dim men As String = TextMen.Text
        Dim women As String = TextWomen.Text
        If men <> "" And women <> "" Then
            LabelSum.Text = Integer.Parse(TextMen.Text) + Integer.Parse(TextWomen.Text)
        End If
    End Sub

    Private Sub TextMen_Enter(sender As Object, e As EventArgs) Handles TextMen.Enter
        If TextMen.Text = "0" Then
            TextMen.Clear()
        End If
    End Sub

    Private Sub Week01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
    End Sub


End Class
