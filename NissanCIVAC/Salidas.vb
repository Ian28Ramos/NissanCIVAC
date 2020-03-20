Imports MySql.Data.MySqlClient
Public Class Salidas

    Dim F As New VaGlo
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim ComSql As String
    Dim lista As Byte
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Capturar()

    End Sub

    Private Sub Consultar()
        If CapBox.Text <> "" Then
            F.Conexion()
            ComSql = "SELECT * FROM Salidas WHERE ID_Salida='" & Cap.Text & "'"
            DA = New MySqlDataAdapter(ComSql, F.Conn)
            DS = New DataSet
            DA.Fill(DS, "Salidas")
            lista = DS.Tables("Salidas").Rows.Count
        Else
            MsgBox("Para hacer una consulta es necesario introducir el campo REC")
        End If
        If lista <> 0 Then
            TiSaBox.Text = DS.Tables("Salidas").Rows(0).Item("")
            CantBox.Text = DS.Tables("Salidas").Rows(0).Item("ID_Pieza")
            FechaBox.Text = DS.Tables("Salidas").Rows(0).Item("Falla")
            F.Conn.Close()
        Else
            MsgBox("No se encontraron resultados")
            F.Conn.Close()
        End If
    End Sub

End Class