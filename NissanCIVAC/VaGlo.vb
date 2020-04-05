Imports MySql.Data.MySqlClient
Public Class VaGlo

    Public StrConexion As String = "Server=127.0.0.1; Database=nissancivac; Uid=NissanUser; pwd=Rxw75GI00Ykm; port=3306"
    Public Conn As New MySqlConnection(StrConexion)
    Public Us As String 'Variable que guarda el tipo de usuario

    Public Sub Conexion() 'conexion a la BD
        Try
            Conn.Open() 'Abrimos la BD
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
