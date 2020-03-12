
Imports MySql.Data.MySqlClient 'Libreria de conexión a la BD

Public Class LogIn

    Dim StrConexion As String = "Server=127.0.0.1; Database=nissancivac; Uid=root; pwd=1013p362; port=3306"
    Dim Conn As New MySqlConnection(StrConexion)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Entrar.Click
        Conexion()
        Validar()
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Conexion() 'conexion a la BD
        Try
            Conn.Open() 'Abrimos la BD
        Catch ex As Exception
            MsgBox("No se puede conectar con la Base de datos por: " & ex.Message)
        End Try
    End Sub

    Private Sub Validar()

        Dim sql As String 'Variable de consulta
        Dim lista As Byte
        Dim DA As MySqlDataAdapter
        Dim DS As DataSet
        Dim User As Integer = Val(Usuario.Text)

        If Usuario.Text <> "" And Pswd.Text <> "" Then
            sql = "SELECT * FROM Usuarios WHERE ID_Usuario='" & Usuario.Text & "' AND Pswrds= '" & Pswd.Text & "'"
            DA = New MySqlDataAdapter(sql, Conn)
            DS = New DataSet
            DA.Fill(DS, "Usuarios")
            lista = DS.Tables("Usuarios").Rows.Count
        Else
            MsgBox("Porfavor llena todos los campos solicitados")
        End If
        If lista <> 0 Then
            MenuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("El usuario o la contraseña son incorrectos:")
        End If
    End Sub
End Class