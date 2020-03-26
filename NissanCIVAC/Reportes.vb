Public Class Reportes

    Public Ori As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RMPbtn.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub CapDate()
        StarTxt.Text = MC.SelectionRange.Start.ToString("yyyy/MM/dd")
        EndTxt.Text = MC.SelectionRange.End.ToString("yyyy/MM/dd")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CapDate()
    End Sub

    Private Sub RMF_Click(sender As Object, e As EventArgs) Handles RMFbtn.Click
        MenuFinan.Show()
        Me.Hide()
    End Sub

    Private Sub RMM_Click(sender As Object, e As EventArgs)
        MenuMM.Show()
        Me.Hide()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Defbtn()
    End Sub

    Private Sub Defbtn()
        If Ori = "MP" Then
            RMPbtn.Visible = True
            RMFbtn.Visible = False
        ElseIf Ori = "MF" Then
            RMPbtn.Visible = False
            RMFbtn.Visible = True
        End If
    End Sub

End Class