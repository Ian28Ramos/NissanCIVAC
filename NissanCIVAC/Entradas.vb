Public Class Entradas
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_MouseCaptureChanged(sender As Object, e As EventArgs) Handles Button1.MouseCaptureChanged
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class