Imports MySql.Data.MySqlClient

Public Class Usuarios

    Dim F As New VaGlo
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim ComSql As String
    Dim lista As Byte

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Capturar()
        If IDBox.Text <> "" And NomBox.Text <> "" And ApPBox.Text <> "" And ApMBox.Text <> "" And TiUsBox.Text <> "" And PassBox.Text <> "" And PassBox2.Text <> "" Then
            If PassBox.Text = PassBox2.Text Then
                ComSql = "INSERT INTO Usuarios (ID_Usuario, Nombre, Ap_Paterno, Ap_Materno, Pswrds, Tipo_Usuario) 
                    VALUES
                    ('" & IDBox.Text & "','" & NomBox.Text & "','" & ApPBox.Text & "','" & ApMBox.Text & "','" & PassBox.Text & "','" & TiUsBox.Text & "')"
                Dim READER As MySqlDataReader

                Try
                    F.Conn.Open()
                    Dim Cmd As New MySqlCommand(ComSql, F.Conn)
                    READER = Cmd.ExecuteReader()

                    MsgBox("El usuario se agregó con éxito")
                    Limpiar()
                    F.Conn.Close()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                    F.Conn.Close()
                End Try
            Else
                MsgBox("Las contraseñas no coinciden")
            End If
        Else
            MsgBox("Porfavor llena todos los campos")
        End If
    End Sub

    Private Sub Eliminar()
        If IDBox.Text <> "" Then
            ComSql = "DELETE FROM Usuarios WHERE ID_Usuario='" & IDBox.Text & "'"
            Dim READER As MySqlDataReader

            Try
                F.Conn.Open()
                Dim Cmd As New MySqlCommand(ComSql, F.Conn)
                READER = Cmd.ExecuteReader()

                MsgBox("Usuario eliminado con éxito")
                F.Conn.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                F.Conn.Close()
            End Try
        Else
            MsgBox("Para eliminar usuario es necesario su número de empleado")
        End If
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        Dim R
        MsgBox("¿Esta seguro de eliminar a este usuario?", vbOKCancel + vbSystemModal)
        If R = vbOK Then
            Eliminar()
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Capturar()
    End Sub

    Private Sub Limpiar()
        IDBox.Text = ""
        NomBox.Text = ""
        ApPBox.Text = ""
        ApMBox.Text = ""
        TiUsBox.Text = ""
        PassBox.Text = ""
        PassBox2.Text = ""
    End Sub

End Class