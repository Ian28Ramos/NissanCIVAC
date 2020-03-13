Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Entradas

    Dim StrConexion As String = "Server=127.0.0.1; Database=nissancivac; Uid=root; pwd=1013p362; port=3306"
    Dim Conn As New MySqlConnection(StrConexion)
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim ComSql As String
    Dim lista As Byte


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_MouseCaptureChanged(sender As Object, e As EventArgs) Handles Button1.MouseCaptureChanged
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Capturar.Click
        Ingresar()
    End Sub

    Private Sub Consulta_Click(sender As Object, e As EventArgs) Handles Consulta.Click
        Consultar()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Actualizar()
    End Sub

    Private Sub Consultar() 'Procedimiento que buscará en la base da datos los registros ingresados
        If Cap.Text <> "" Then
            Conn.Open()
            ComSql = "SELECT * FROM Entradas WHERE ID_Entrada='" & Cap.Text & "'"
            DA = New MySqlDataAdapter(ComSql, Conn)
            DS = New DataSet
            DA.Fill(DS, "Entradas")
            lista = DS.Tables("Entradas").Rows.Count
        Else
            MsgBox("Para hacer una consulta es necesario introducir el campo REC")
        End If
        If lista <> 0 Then
            Cantidad.Text = DS.Tables("Entradas").Rows(0).Item("Cantidad_Entrada")
            NoParte.Text = DS.Tables("Entradas").Rows(0).Item("ID_Pieza")
            TiDa.Text = DS.Tables("Entradas").Rows(0).Item("Falla")
            Prioridad.Text = DS.Tables("Entradas").Rows(0).Item("Prioridad")
            ArRe.Text = DS.Tables("Entradas").Rows(0).Item("Responsable")
            Desc.Text = DS.Tables("Entradas").Rows(0).Item("Descripcion")
            Fecha.Text = DS.Tables("Entradas").Rows(0).Item("Fecha")
            Conn.Close()
        Else
            MsgBox("No se encontraron resultados")
            Conn.Close()
        End If
    End Sub

    Private Sub Ingresar() 'Procedimeinto que se encarga de llenar la base de datos
        If Cap.Text <> "" And Cantidad.Text <> "" And NoParte.Text <> "" And TiDa.Text <> "" And Prioridad.Text <> "" And ArRe.Text <> "" And Desc.Text <> "" And Fecha.Text <> "" Then
            ComSql = "INSERT INTO Entradas (ID_Entrada, ID_Pieza, Falla, Fecha, Descripcion, Prioridad, Cantidad_Entrada, Responsable) 
                    VALUES
                    ('" & Cap.Text & "','" & NoParte.Text & "','" & TiDa.Text & "','" & Fecha.Text & "','" & Desc.Text & "','" & Prioridad.Text & "','" & Cantidad.Text & "','" & ArRe.Text & "')"
            Dim READER As MySqlDataReader

            Try
                Conn.Open()
                Dim Cmd As New MySqlCommand(ComSql, Conn)
                READER = Cmd.ExecuteReader()

                MsgBox("Datos guardados con éxito")
                Conn.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Conn.Close()
            End Try
        Else
            MsgBox("Porfavor llena todos los campos")
        End If
    End Sub

    Private Sub Actualizar()

        ComSql = "UPDATE * FROM Entradas WHERE ID_Entrada='" & Cap.Text & "'"

    End Sub

    Private Sub Conexion()
        Try
            Conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DescPieza() 'Obtencion de la descripcion de la pieza automaticamente
        Try
            If NoParte.Text <> "" Then
                Conn.Open()
                ComSql = "SELECT Descripcion FROM Piezas WHERE ID_Pieza='" & NoParte.Text & "'"
                DA = New MySqlDataAdapter(ComSql, Conn)
                DS = New DataSet
                DA.Fill(DS, "Entradas")
                lista = DS.Tables("Entradas").Rows.Count

                If lista <> 0 Then
                    Desc.Text = DS.Tables("Entradas").Rows(0).Item("Descripcion")
                    Conn.Close()
                Else
                    MsgBox("Verifique el Número de pieza")
                    Conn.Close()
                End If
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click 'Borra el contenido de los TextBox
        Cantidad.Text = ""
        NoParte.Text = ""
        TiDa.Text = ""
        Prioridad.Text = ""
        ArRe.Text = ""
        Desc.Text = ""
        Fecha.Text = ""
    End Sub

    Private Sub NoParte_TextUpdate(sender As Object, e As EventArgs) Handles NoParte.TextUpdate
        DescPieza()
    End Sub
End Class