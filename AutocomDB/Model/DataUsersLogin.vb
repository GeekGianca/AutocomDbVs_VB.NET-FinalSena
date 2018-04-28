Public Class DataUsersLogin
    Private username As String
    Private password As String

    Public Function getUsername() As String
        Return username
    End Function

    Public Sub setUsername(value As String)
        username = value
    End Sub

    Public Function getPassword() As String
        Return password
    End Function

    Public Sub setPassword(value As String)
        password = value
    End Sub

    Public Function connection() As Boolean
        Dim isConnect As Boolean = False
        Dim conn As New ConnectionDB()
        Try
            isConnect = conn.connectionDB(getUsername(), getPassword())
            'isConnect = conn.connectionDB("id2770351_admin", "geekprogramador")
        Catch ex As Exception
            MsgBox("Failed")
        End Try
        Return isConnect
    End Function
End Class
