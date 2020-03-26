Public Class MenuFinan
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reportes.Ori = "MF"
        Reportes.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GesPiezas.Ori = "MF"
        GesPiezas.Show()
        Me.Hide()
    End Sub

End Class