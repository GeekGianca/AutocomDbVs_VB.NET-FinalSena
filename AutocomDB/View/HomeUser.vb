Imports MaterialSkin

Public Class HomeUser
    Dim dataUs As New DataUsersLogin
    Private Sub HomeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.LightBlue700, TextShade.WHITE)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If dataUs.connection() = False Then
            btnStartServer.Visible = True
        End If
        'dataUs.setUsername(txtUsername.Text)
        'dataUs.setPassword(txtPassword.Text)
        'If dataUs.connection() Then
        '    HomeShowA.user = dataUs.getUsername()
        '    HomeShowA.pass = dataUs.getPassword()
        'End If
    End Sub

    Private Sub btnStartServer_Click(sender As Object, e As EventArgs) Handles btnStartServer.Click
        proBar.Visible = True
        time.Visible = True
        Shell("explorer.exe root=C:\bitnami\wampstack-7.0.23-0\manager-windows.exe", vbNormalFocus)
        temp.Start()
    End Sub

    Private Sub temp_Tick(sender As Object, e As EventArgs) Handles temp.Tick
        proBar.Increment(1)
        time.Text = proBar.Value & "%"
        If time.Text = "100%" Then
            picCheck.Visible = True
            serverRunning.Visible = True
        End If
    End Sub
End Class
