Imports MySql.Data.MySqlClient
Public Class Salidas

    Dim F As New VaGlo
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim ComSql As String
    Dim lista As Byte
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BoxREC()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Capturar()
        If Cap.Text <> "" And SalBox.Text <> "" And RECBox.Text <> "" And TiSaBox.Text <> "" And CantBox.Text <> "" And FechaBox.Text <> "" Then
            ComSql = "INSERT INTO Salidas (ID_Salida, ID_Entrada, Tipo_Salida, Cantidad_Salida, Fecha) 
                    VALUES
                    ('" & SalBox.Text & "','" & RECBox.Text & "','" & TiSaBox.Text & "','" & CantBox.Text & "','" & FechaBox.Text & "')"
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

    Private Sub Consultar()
        If SalBox.Text <> "" Then
            F.Conexion()
            ComSql = "SELECT * FROM Salidas WHERE ID_Salida='" & SalBox.Text & "'"
            DA = New MySqlDataAdapter(ComSql, F.Conn)
            DS = New DataSet
            DA.Fill(DS, "Salidas")
            lista = DS.Tables("Salidas").Rows.Count
        Else
            MsgBox("Para hacer una consulta es necesario introducir el campo REC")
        End If
        If lista <> 0 Then
            RECBox.Text = DS.Tables("Salidas").Rows(0).Item("ID_Entrada")
            TiSaBox.Text = DS.Tables("Salidas").Rows(0).Item("Tipo_Salida")
            CantBox.Text = DS.Tables("Salidas").Rows(0).Item("Cantidad_Salida")
            FechaBox.Text = DS.Tables("Salidas").Rows(0).Item("Fecha")
            F.Conn.Close()
        Else
            MsgBox("No se encontraron resultados")
            F.Conn.Close()
        End If
    End Sub

    Private Sub BoxREC() 'Llenado de ComboBox Con datos de la BD
        ComSql = "SELECT ID_Entrada FROM Entradas"
        DA = New MySqlDataAdapter(ComSql, F.Conn)
        DS = New DataSet
        DA.Fill(DS, "Entradas")

        RECBox.DataSource = DS.Tables(0)
        RECBox.DisplayMember = "ID_Entrada"
    End Sub

    Private Sub Cons_Click(sender As Object, e As EventArgs) Handles Cons.Click
        Consultar()
    End Sub

    Private Sub Cap_Click(sender As Object, e As EventArgs) Handles Cap.Click
        Capturar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SalBox.Text = ""
        RECBox.Text = ""
        TiSaBox.Text = ""
        CantBox.Text = ""
        FechaBox.Text = ""
    End Sub
End Class