Imports MySql.Data.MySqlClient
Public Class VarGlo

    Public StrConexion As String = "Server=127.0.0.1; Database=nissancivac; Uid=root; pwd=1013p362; port=3306"
    Public Conn As New MySqlConnection(StrConexion)

    Public Sub Conexion()
        Try
            Conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
