Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Entradas

    Dim F As New VaGlo
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim ComSql As String
    Dim lista As Byte


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BoxArea()
        BoxParte()
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
            F.Conexion()
            ComSql = "SELECT * FROM Entradas WHERE ID_Entrada='" & Cap.Text & "'"
            DA = New MySqlDataAdapter(ComSql, F.Conn)
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
            Fecha.Text = DS.Tables("Entradas").Rows(0).Item("Fecha")
            F.Conn.Close()
        Else
            MsgBox("No se encontraron resultados")
            F.Conn.Close()
        End If
    End Sub

    Private Sub Ingresar() 'Procedimeinto que se encarga de llenar la base de datos
        If Cap.Text <> "" And Cantidad.Text <> "" And NoParte.Text <> "" And TiDa.Text <> "" And Prioridad.Text <> "" And ArRe.Text <> "" And Desc.Text <> "" And Fecha.Text <> "" Then
            ComSql = "INSERT INTO Entradas (ID_Entrada, ID_Pieza, Falla, Fecha, Descripcion, Prioridad, Cantidad_Entrada, Responsable) 
                    VALUES
                    ('" & Cap.Text & "','" & NoParte.Text & "','" & TiDa.Text & "','" & Fecha.Text & "','" & Desc.Text & "','" & Prioridad.Text & "','" & Cantidad.Text & "','" & ArRe.Text & "')"
            Dim READER As MySqlDataReader

            Try
                F.Conn.Open()
                Dim Cmd As New MySqlCommand(ComSql, F.Conn)
                READER = Cmd.ExecuteReader()

                MsgBox("Datos guardados con éxito")
                F.Conn.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                F.Conn.Close()
            End Try
        Else
            MsgBox("Porfavor llena todos los campos")
        End If
    End Sub

    Private Sub Actualizar() 'Proceso que edita los valores dentro de la BD por medio de la Primary key
        Try
            If Cap.Text <> "" And Cantidad.Text <> "" And NoParte.Text <> "" And TiDa.Text <> "" And Prioridad.Text <> "" And ArRe.Text <> "" And Desc.Text <> "" And Fecha.Text <> "" Then
                ComSql = "UPDATE Entradas SET ID_PIeza='" & NoParte.Text & "', Falla='" & TiDa.Text & "', Fecha='" & Fecha.Text & "', Descripcion='" & Desc.Text & "', Prioridad='" & Prioridad.Text & "', Cantidad_Entrada=" & Cantidad.Text & ", Responsable='" & ArRe.Text & "' WHERE ID_Entrada='" & Cap.Text & "'"
                Dim READER As MySqlDataReader

                Try
                    F.Conn.Open()
                    Dim Cmd As New MySqlCommand(ComSql, F.Conn)
                    READER = Cmd.ExecuteReader()

                    MsgBox("Datos guardados con éxito")
                    F.Conn.Close()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                    F.Conn.Close()
                End Try
            Else
                MsgBox("Porfavor llena todos los campos")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DescPieza() 'Obtencion de la descripcion de la pieza automaticamente
        Try
            If NoParte.Text <> "" And NoParte.Text.Length >= 9 Then
                If F.Conn.Equals(0) Then
                    F.Conn.Open()
                End If

                ComSql = "SELECT Descripcion FROM Piezas WHERE ID_Pieza='" & NoParte.Text & "'"
                DA = New MySqlDataAdapter(ComSql, F.Conn)
                DS = New DataSet
                DA.Fill(DS, "Entradas")
                lista = DS.Tables("Entradas").Rows.Count

                If lista <> 0 Then
                    Desc.Text = DS.Tables("Entradas").Rows(0).Item("Descripcion")
                    F.Conn.Close()
                Else
                    MsgBox("Verifique el Número de pieza")
                        F.Conn.Close()
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
        NomArea.Text = ""
    End Sub

    Private Sub NoParte_TextUpdate(sender As Object, e As EventArgs) Handles NoParte.TextUpdate, NoParte.TextChanged, NoParte.DropDownClosed
        DescPieza()
    End Sub

    Private Sub NomAr()
        If ArRe.Text <> "" And ArRe.Text.Length = 2 Then
            Try
                If F.Conn.Equals(0) Then
                    F.Conexion()
                End If

                Dim ComSql As String = "SELECT Nombre_Area FROM Areas WHERE ID_Area = '" & ArRe.Text & "'"
                Dim DA As New MySqlDataAdapter(ComSql, F.Conn)
                Dim DS As New DataSet
                Dim lista As Byte
                DA.Fill(DS, "Areas")
                lista = DS.Tables("Areas").Rows.Count

                If lista <> 0 Then
                    NomArea.Text = DS.Tables("Areas").Rows(0).Item("Nombre_Area")
                    F.Conn.Close()
                Else
                    MsgBox("Error")
                    F.Conn.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else

        End If
    End Sub

    Private Sub ArRe_TextUpdate(sender As Object, e As EventArgs) Handles ArRe.TextUpdate, ArRe.DropDownClosed, ArRe.TextChanged
        NomAr()
    End Sub

    Private Sub BoxArea() 'Llenado de ComboBox Con datos de la BD
        ComSql = "SELECT ID_Area FROM Areas"
        DA = New MySqlDataAdapter(ComSql, F.Conn)
        DS = New DataSet
        DA.Fill(DS, "Areas")

        ArRe.DataSource = DS.Tables(0)
        ArRe.DisplayMember = "ID_Area"
    End Sub

    Private Sub BoxParte()
        ComSql = "SELECT ID_Pieza FROM Piezas"
        DA = New MySqlDataAdapter(ComSql, F.Conn)
        DS = New DataSet
        DA.Fill(DS, "Piezas")

        NoParte.DataSource = DS.Tables(0)
        NoParte.DisplayMember = "ID_Pieza"
    End Sub

End Class