﻿Public Class MenuPrincipal

    Dim F As VaGlo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Entradas.Ori = "MP"
        Entradas.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Salidas.Ori = "MP"
        Salidas.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Usuarios.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Reportes.Ori = "MP"
        Reportes.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GesPiezas.Ori = "MP"
        GesPiezas.Show()
        Me.Hide()
    End Sub
End Class