Imports MySql.Data.MySqlClient

Public Class GesPiezas

    Dim F As New VaGlo
    Dim ComSql As String
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim lista As Byte
    Public Ori As String

    Private Sub GesPiezas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PBOX()
        OBOX()
        MBOX()
        Defbtn()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles RMPbtn.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub PBOX()
        ComSql = "SELECT ID_Pieza FROM Piezas"
        DA = New MySqlDataAdapter(ComSql, F.Conn)
        DS = New DataSet
        DA.Fill(DS, "Piezas")

        NPBox.DataSource = DS.Tables(0)
        NPBox.DisplayMember = "ID_Pieza"
        NPBox.Text = "<Seleccione una opción>"
    End Sub

    Private Sub OBOX()
        ComSql = "SELECT ID_Origen FROM Origenes"
        DA = New MySqlDataAdapter(ComSql, F.Conn)
        DS = New DataSet
        DA.Fill(DS, "Origenes")

        OriBox.DataSource = DS.Tables(0)
        OriBox.DisplayMember = "ID_Origen"
        OriBox.Text = "<Seleccione una opción>"
    End Sub

    Private Sub MBOX()
        ComSql = "SELECT ID_Divisa FROM Divisas"
        DA = New MySqlDataAdapter(ComSql, F.Conn)
        DS = New DataSet
        DA.Fill(DS, "Divisas")

        MonBox.DataSource = DS.Tables(0)
        MonBox.DisplayMember = "ID_Divisa"
        MonBox.Text = "<Seleccione una opción>"
    End Sub

    Private Sub Consultar() 'Procedimiento que buscará en la base da datos los registros ingresados
        If NPBox.Text <> "" Then
            F.Conexion()
            ComSql = "SELECT * FROM Piezas WHERE ID_Pieza='" & NPBox.Text & "'"
            DA = New MySqlDataAdapter(ComSql, F.Conn)
            DS = New DataSet
            DA.Fill(DS, "Piezas")
            lista = DS.Tables("Piezas").Rows.Count
        Else
            MsgBox("Para hacer una consulta es necesario introducir el campo REC")
        End If
        If lista <> 0 Then
            OriBox.Text = DS.Tables("Piezas").Rows(0).Item("Origen")
            CosBox.Text = DS.Tables("Piezas").Rows(0).Item("Costo")
            DesBox.Text = DS.Tables("Piezas").Rows(0).Item("Descripcion")
            MonBox.Text = DS.Tables("Piezas").Rows(0).Item("Moneda")
            F.Conn.Close()
        Else
            MsgBox("No se encontraron resultados")
            F.Conn.Close()
        End If
    End Sub

    Private Sub Limpiar()
        NPBox.Text = ""
        OriBox.Text = ""
        CosBox.Text = ""
        DesBox.Text = ""
        MonBox.Text = ""
    End Sub

    Private Sub Capturar()
        If NPBox.Text <> "" And OriBox.Text <> "" And CosBox.Text <> "" And DesBox.Text <> "" And MonBox.Text <> "" Then

            ComSql = "INSERT INTO Piezas (ID_Pieza, Origen, Costo, Descripcion, Moneda) 
                    VALUES
                    ('" & NPBox.Text & "','" & OriBox.Text & "','" & CosBox.Text & "','" & DesBox.Text & "','" & MonBox.Text & "')"
            Dim READER As MySqlDataReader

            Try
                F.Conn.Open()
                Dim Cmd As New MySqlCommand(ComSql, F.Conn)
                READER = Cmd.ExecuteReader()

                MsgBox("Pieza agregada con éxito")
                Limpiar()
                F.Conn.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                F.Conn.Close()
            End Try

        Else
            MsgBox("Porfavor llena todos los campos")
        End If
    End Sub

    Private Sub Eliminar()
        If NPBox.Text <> "" And NPBox.Text <> "<Seleccione una opción>" Then
            Dim R
            MsgBox("¿Seguro que desea elimar la pieza?", vbOKCancel + vbSystemModal)
            If R = vbOK Then
                ComSql = "DELETE FROM Piezas WHERE ID_Pieza='" & NPBox.Text & "'"
                Dim READER As MySqlDataReader

                Try
                    F.Conn.Open()
                    Dim Cmd As New MySqlCommand(ComSql, F.Conn)
                    READER = Cmd.ExecuteReader()

                    MsgBox("Pieza eliminada con éxito")
                    F.Conn.Close()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                    F.Conn.Close()
                End Try
            End If
        Else
            MsgBox("Para eliminar una pieza es necesario el número de pieza")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Consultar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Capturar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Eliminar()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles RMFbtn.Click
        MenuFinan.Show()
        Me.Hide()
    End Sub
End Class