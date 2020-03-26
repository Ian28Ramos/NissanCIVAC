Public Class MenuMM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Entradas.Ori = "MM"
        Entradas.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Salidas.Ori = "MM"
        Salidas.Show()
        Me.Hide()
    End Sub

End Class