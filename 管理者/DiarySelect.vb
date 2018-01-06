Public Class DiarySelect

    Private Sub DiarySelect_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsNothing(Owner) = False Then
            Owner.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub BtnMonth0to1_Click(sender As Object, e As EventArgs) Handles BtnMonth0to1.Click
        If BnfChkboxMonth0to1.Checked Then
            BnfChkboxMonth0to1.Checked = False
        Else
            BnfChkboxMonth0to1.Checked = True
        End If
    End Sub

    Private Sub BtnMonth2_Click(sender As Object, e As EventArgs) Handles BtnMonth2.Click
        If BnfChkboxMonth2.Checked Then
            BnfChkboxMonth2.Checked = False
        Else
            BnfChkboxMonth2.Checked = True
        End If
    End Sub

    Private Sub BtnMonth3to5_Click(sender As Object, e As EventArgs) Handles BtnMonth3to5.Click
        If BnfChkboxMonth3to5.Checked Then
            BnfChkboxMonth3to5.Checked = False
        Else
            BnfChkboxMonth3to5.Checked = True
        End If
    End Sub

    Private Sub BtnWeek0to5_Click(sender As Object, e As EventArgs) Handles BtnWeek0to5.Click
        If BnfChkboxWeek0to5.Checked Then
            BnfChkboxWeek0to5.Checked = False
        Else
            BnfChkboxWeek0to5.Checked = True
        End If
    End Sub
End Class