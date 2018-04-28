Imports MySql.Data.MySqlClient

Public Class HomeShowA
    Private isLoad As Boolean = False
    Private querys As New QuerysGet
    Public dataUs As DataUsersLogin
    Private loadDb As New LoadDataBase
    Private dataSet As DataSet
    Private dataView As DataView
    Public user As String
    Public pass As String
    Dim query As String
    Dim queryRef As String

    Private Sub cbAcces_CheckedChanged(sender As Object, e As EventArgs) Handles cbAcces.CheckedChanged
        If cbAcces.Checked = True Then
            txtUsername.Visible = True
            txtPass.Visible = True
            picName.Visible = True
            picUser.Visible = True
            btnAcces.Visible = True
        Else
            txtUsername.Visible = False
            txtPass.Visible = False
            picName.Visible = False
            picUser.Visible = False
            btnAcces.Visible = False
        End If
    End Sub

    Private Sub loadGridView(queryable As String)
        dgvDatabase = loadDb.loadDatabase(query, dgvDatabase)
    End Sub

    Private Sub txtNamePro_TextChanged(sender As Object, e As EventArgs) Handles txtNamePro.TextChanged
        query = querys.getSelectTwoLike(txtNamePro.Text, txtRef.Text)
        loadGridView(query)
    End Sub

    Private Sub txtRef_TextChanged(sender As Object, e As EventArgs) Handles txtRef.TextChanged
        query = querys.getSelectTwoLike(txtNamePro.Text, txtRef.Text)
        loadGridView(query)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'No es recomendable eliminar los productos mejor se tienen en otra tabla que referencia si estan disponibles o no
        'query = querys.getDelete(txtNamePro.Text, txtRef.Text)
        Dim i As Integer = dgvDatabase.CurrentRow.Index
        query = querys.getDelete(dgvDatabase.Item(1, i).Value)
        loadGridView(query)
        'dgvDatabase = loadDb.updateDatabase(query)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        loadDb.editDatabase(dgvDatabase)
    End Sub

    Private Sub btnAcces_Click(sender As Object, e As EventArgs) Handles btnAcces.Click

    End Sub
End Class
'Dim strConnection As String = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'Dim connection As New MySqlConnection(strConnection)
'Dim filtre As String
'filtre = ""
'filtre = txtFiltre.Text
'Dim adapter As MySqlDataAdapter
'Dim query As String
'Dim dataSet As New DataSet
'query = "SELECT * FROM producto WHERE NombProducto LIKE '%" & filtre & "%'"
'adapter = New MySqlDataAdapter(query, connection)
'adapter.Fill(dataSet)
'dataSet.Tables(0).Columns(0).ColumnName = "Nombre Producto"
'dataSet.Tables(0).Columns(1).ColumnName = "Referencia"
'dataSet.Tables(0).Columns(2).ColumnName = "Inicial"
'dataSet.Tables(0).Columns(3).ColumnName = "Entradas"
'dataSet.Tables(0).Columns(4).ColumnName = "Fecha Ingreso"
'dataSet.Tables(0).Columns(5).ColumnName = "Salidas"
'dataSet.Tables(0).Columns(6).ColumnName = "Fecha Egreso"
'dataSet.Tables(0).Columns(7).ColumnName = "Precio"
'dataSet.Tables(0).Columns(8).ColumnName = "Factura Compra"