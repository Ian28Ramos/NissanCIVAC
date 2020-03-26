Imports MySql.Data.MySqlClient 'Libreria de conexión a la BD

Public Class LogIn


    Dim F As New VaGlo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Entrar.Click
        F.Conexion()
        NomUsuario()
        Validar()
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub Validar() 'verifica usuario y lo discrimina

        Dim sql As String 'Variable de consulta
        Dim lista As Byte
        Dim DA As MySqlDataAdapter
        Dim DS As DataSet
        Dim User As Integer = Val(Usuario.Text) 'Cast del valor txt a int
        Dim TiU As String

        Try
            If Usuario.Text <> "" And Pswd.Text <> "" Then
                sql = "SELECT * FROM Usuarios WHERE ID_Usuario='" & Usuario.Text & "' AND Pswrds= '" & Pswd.Text & "'"
                DA = New MySqlDataAdapter(sql, F.Conn)
                DS = New DataSet
                DA.Fill(DS, "Usuarios")
                lista = DS.Tables("Usuarios").Rows.Count
                TiU = DS.Tables("Usuarios").Rows(0).Item("Tipo_Usuario")
                F.Us = TiU
                F.Conn.Close()
            Else
                MsgBox("Porfavor llena todos los campos solicitados")
            End If
            If lista <> 0 And TiU = "SUPER" Then
                MenuPrincipal.Show()
                Me.Hide()
            ElseIf lista <> 0 And TiU = "FINANCIEROS" Then
                MenuFinan.Show()
                Me.Hide()
            ElseIf lista <> 0 And TiU = "MANEJO DE MATERIALES" Then
                MenuMM.Show()
                Me.Hide()
            Else
                MsgBox("El usuario o la contraseña son incorrectos")
            End If
        Catch ex As Exception
            MsgBox("El usuario o la contraseña son incorrectos")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Public Sub NomUsuario() 'Asigna valor para identificar usuario
        Try
            Dim cmd As String = "SELECT Nombre FROM Usuarios WHERE ID_Usuario='" & Usuario.Text & "'"
            Dim DA = New MySqlDataAdapter(cmd, F.Conn)
            Dim DS = New DataSet
            DA.Fill(DS, "Usuarios")
            Dim lista As Byte = DS.Tables("Usuarios").Rows.Count

            If lista <> 0 Then
                MenuPrincipal.Usutxt.Text = DS.Tables("Usuarios").Rows(0).Item("Nombre")
                MenuFinan.Ustxt.Text = DS.Tables("Usuarios").Rows(0).Item("Nombre")
                MenuMM.UsTxt.Text = DS.Tables("Usuarios").Rows(0).Item("Nombre")
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class