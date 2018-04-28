Imports MySql.Data.MySqlClient
Public Class ConnectionDB
    Dim connection As MySqlConnection
    Dim connect As String
    Public Function connectionDB(user As String, pass As String) As Boolean
        Dim isConnect As Boolean = False
        'id2770351_autocom_productos
        connect = "server=localhost;database=autocom;user id=root;password=geekprogramador23"
        'connect = "server=localhost;database=id2770351_autocom_productos;user id=" & user & ";password=" & pass
        Try
            connection = New MySqlConnection(connect)
            connection.Open()
            MsgBox("Connection Success", MsgBoxStyle.Information)
            HomeUser.Hide()
            HomeShowA.Show()
            isConnect = True
        Catch ex As MySqlException
            MsgBox("Failed To Connection" & vbCr & "Verify that the server is on" & vbCr & "Or check username and password", MsgBoxStyle.Critical)
        Finally
            connection.Close()
        End Try
        Return isConnect
    End Function
End Class
