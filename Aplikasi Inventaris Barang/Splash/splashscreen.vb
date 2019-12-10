Public Class splashscreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = 1.0
        ProgressBar1.Value += 5
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            FormMenu.Show()
        End If
    End Sub
End Class