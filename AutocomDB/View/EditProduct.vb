Public Class formEp
    Private query As String
    Private querys As New QuerysGet
    Public product As String
    Public ref As String
    Public init As String
    Public inPro As String
    Public outPro As String
    Public dateIn As String
    Public out As String
    Public dateOut As String
    Public price As String
    Public fact As String

    Private Sub formEp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNameProduct.Text = product
        txtRefProduct.Text = ref
        txtInit.Text = init
        txtIn.Text = inPro
        txtOut.Text = outPro
        txtDateIn.Text = dateIn
        txtDateOut.Text = dateOut
        txtPrice.Text = price
        numberFac.Text = fact
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim loadDb As New LoadDataBase
        query = querys.getUpdate(txtNameProduct.Text, txtRefProduct.Text, txtInit.Text, txtIn.Text, txtDateIn.Text, txtOut.Text, txtPrice.Text, "", txtNameProduct.Text, txtRefProduct.Text)
        If loadDb.updateDatabase(query) Then
            HomeShowA.dgvDatabase = loadDb.loadDatabase(querys.getSelect(), HomeShowA.dgvDatabase)
            Me.Hide()
        End If
    End Sub

End Class