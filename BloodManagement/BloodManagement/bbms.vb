Public Class bbms

  

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        Label2.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            login.Show()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
