Imports MySql.Data.MySqlClient

Public Class LoadDataBase
    Private connectionDB As New ConnectionDB
    Private querys As New QuerysGet
    'CONEXION FUNCIONAL'
    Private connection As MySqlConnection
    Private command As MySqlCommand
    Private reader As MySqlDataReader
    Private strConnection As String

    Public Function loadDatabase(query As String, dgv As DataGridView) As DataGridView
        strConnection = "server=localhost;database=autocom;user id=root;password=geekprogramador23"
        connection = New MySqlConnection(strConnection)
        dgv.Rows.Clear()
        connection.Open()
        command = New MySqlCommand
        command.Connection = connection
        command.CommandText = query
        reader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                Try
                    If CInt(reader("Inicial")) <> 1 Then
                        dgv.Rows.Add(reader("NombProducto"), reader("Referencia"), reader("Inicial"), reader("Entradas"), reader("FechaIngreso"), reader("Salidas"), reader("FechaEgreso"), reader("Precio"), reader("FacturaCompra"))
                    End If
                Catch ex As Exception
                    MsgBox("Exception Type: " & ex.Message)
                End Try
            End While
        End If
        reader.Close()
        connection.Close()
        Return dgv
    End Function

    Public Function updateDatabase(query As String) As Boolean
        Dim isUpdate As Boolean = False
        strConnection = "server=localhost;database=autocom;user id=root;password=geekprogramador23"
        connection = New MySqlConnection(strConnection)
        connection.Open()
        Try
            command = New MySqlCommand
            command.Connection = connection
            command.CommandText = query
            command.ExecuteNonQuery()
            MsgBox("Update Complete", MsgBoxStyle.Information)
            isUpdate = True
        Catch ex As Exception
            MsgBox("Failed To Update " & ex.Message, MsgBoxStyle.Critical)
        End Try
        connection.Close()
        Return isUpdate
    End Function

    Public Sub editDatabase(dgv As DataGridView)
        Dim i As Integer
        i = dgv.CurrentRow.Index
        Try
            i = dgv.CurrentRow.Index
            formEp.product = dgv.Item(0, i).Value 'NombProducto
            formEp.ref = dgv.Item(1, i).Value 'Referencia
            formEp.init = dgv.Item(2, i).Value 'Inicial
            formEp.inPro = dgv.Item(3, i).Value 'Entradas
            formEp.dateIn = Convert.ToDateTime(dgv.Item(4, i).Value).ToString("yyyy-MM-dd") 'Fecha de Ingreso
            formEp.outPro = dgv.Item(5, i).Value 'Salidas
            formEp.dateOut = Convert.ToDateTime(dgv.Item(6, i).Value).ToString("yyyy-MM-dd") 'Fecha de egreso
            formEp.price = dgv.Item(7, i).Value 'Precio
            formEp.fact = dgv.Item(8, i).Value
        Catch ex As Exception
            MsgBox("It is trying to delete empty data", MsgBoxStyle.Critical)
        End Try
        formEp.Show()
    End Sub

End Class
'Otra forma'
'Private connection As MySqlConnection
'Private command As MySqlCommand
'Private adapter As MySqlDataAdapter
'Private dataSet As New DataSet
'Private strConnection As String
'Dim dgv As New DataGridView
'Public Function connect() As DataSet
'    strConnection = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'    Try
'        connection = New MySqlConnection(strConnection)
'        adapter = New MySqlDataAdapter("SELECT * FROM producto", connection)
'        adapter.Fill(dataSet)
'    Catch ex As Exception
'        MsgBox("Failed To Connection " & ex.Message)
'    Finally
'        connection.Close()
'    End Try
'    Return dataSet
'End Function

'Crea un filtro por medio de dos valores'
'Public Function dataBaseLike(query As String) As DataSet
'    strConnection = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'    connection = New MySqlConnection(strConnection)
'    Dim adapter As MySqlDataAdapter
'    Dim dataSet As New DataSet
'    adapter = New MySqlDataAdapter(query, connection)
'    adapter.Fill(dataSet)
'    dataSet.Tables(0).Columns(0).ColumnName = "Nombre Producto"
'    dataSet.Tables(0).Columns(1).ColumnName = "Referencia"
'    dataSet.Tables(0).Columns(2).ColumnName = "Inicial"
'    dataSet.Tables(0).Columns(3).ColumnName = "Entradas"
'    dataSet.Tables(0).Columns(4).ColumnName = "Fecha Ingreso"
'    dataSet.Tables(0).Columns(5).ColumnName = "Salidas"
'    dataSet.Tables(0).Columns(6).ColumnName = "Fecha Egreso"
'    dataSet.Tables(0).Columns(7).ColumnName = "Precio"
'    dataSet.Tables(0).Columns(8).ColumnName = "Factura Compra"
'    Return dataSet
'End Function

'Muestra la base de datos'
'Public Function selectDataBase() As DataSet
'    strConnection = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'    connection = New MySqlConnection(strConnection)
'    Dim adapter As MySqlDataAdapter
'    Dim dataSet As New DataSet
'    adapter = New MySqlDataAdapter(querys.getSelect(), connection)
'    adapter.Fill(dataSet)
'    dataSet.Tables(0).Columns(0).ColumnName = "Nombre Producto"
'    dataSet.Tables(0).Columns(1).ColumnName = "Referencia"
'    dataSet.Tables(0).Columns(2).ColumnName = "Inicial"
'    dataSet.Tables(0).Columns(3).ColumnName = "Entradas"
'    dataSet.Tables(0).Columns(4).ColumnName = "Fecha Ingreso"
'    dataSet.Tables(0).Columns(5).ColumnName = "Salidas"
'    dataSet.Tables(0).Columns(6).ColumnName = "Fecha Egreso"
'    dataSet.Tables(0).Columns(7).ColumnName = "Precio"
'    dataSet.Tables(0).Columns(8).ColumnName = "Factura Compra"
'    Return dataSet
'End Function

'Filtra por un valor'
'Public Function dataBase(value As String) As DataSet
'    strConnection = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'    connection = New MySqlConnection(strConnection)
'    Dim adapter As MySqlDataAdapter
'    Dim query As String
'    Dim dataSet As New DataSet
'    query = querys.getSelectLike(value)
'    adapter = New MySqlDataAdapter(query, connection)
'    adapter.Fill(dataSet)
'    dataSet.Tables(0).Columns(0).ColumnName = "Nombre Producto"
'    dataSet.Tables(0).Columns(1).ColumnName = "Referencia"
'    dataSet.Tables(0).Columns(2).ColumnName = "Inicial"
'    dataSet.Tables(0).Columns(3).ColumnName = "Entradas"
'    dataSet.Tables(0).Columns(4).ColumnName = "Fecha Ingreso"
'    dataSet.Tables(0).Columns(5).ColumnName = "Salidas"
'    dataSet.Tables(0).Columns(6).ColumnName = "Fecha Egreso"
'    dataSet.Tables(0).Columns(7).ColumnName = "Precio"
'    dataSet.Tables(0).Columns(8).ColumnName = "Factura Compra"
'    Return dataSet
'End Function

'Elimina datos de la base de datos'
'Public Function deleteDataBase(value As String) As DataSet
'    strConnection = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'    connection = New MySqlConnection(strConnection)
'    Dim adapter As MySqlDataAdapter
'    Dim query As String
'    Dim dataSet As New DataSet
'    query = value
'    adapter = New MySqlDataAdapter(query, connection)
'    adapter.Fill(dataSet)
'    dataSet = selectDataBase()
'    Return dataSet
'End Function

'Public Function loadDatabaseLike(query As String, dgv As DataGridView) As DataGridView
'    strConnection = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'    connection = New MySqlConnection(strConnection)
'    dgv.Rows.Clear()
'    connection.Open()
'    command = New MySqlCommand
'    command.Connection = connection
'    command.CommandText = query
'    reader = command.ExecuteReader()
'    If reader.HasRows Then
'        While reader.Read
'            Try
'                dgv.Rows.Add(reader("NombProducto"), reader("Referencia"), reader("Inicial"), reader("Entradas"), reader("FechaIngreso"), reader("Salidas"), reader("FechaEgreso"), reader("Precio"), reader("FacturaCompra"))
'            Catch ex As Exception
'                MsgBox("Failed To Connection ")
'            End Try
'        End While
'    End If
'    reader.Close()
'    connection.Close()
'    Return dgv
'End Function

'Public Function loadDatabaseTwoLike(query As String) As DataGridView
'    strConnection = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'    connection = New MySqlConnection(strConnection)
'    dgv.Rows.Clear()
'    connection.Open()
'    command = New MySqlCommand
'    command.Connection = connection
'    command.CommandText = query
'    reader = command.ExecuteReader()
'    If reader.HasRows Then
'        While reader.Read
'            Try
'                dgv.Rows.Add(reader("NombProducto"), reader("Referencia"), reader("Inicial"), reader("Entradas"), reader("FechaIngreso"), reader("Salidas"), reader("FechaEgreso"), reader("Precio"), reader("FacturaCompra"))
'            Catch ex As Exception
'                MsgBox("Failed To Connection " & ex.Message)
'            End Try
'        End While
'    End If
'    reader.Close()
'    connection.Close()
'    Return dgv
'End Function

'Public Function loadDataBase(query As String, dgv As DataGridView) As DataGridView
'    Dim i As Integer
'    strConnection = "server=localhost;database=tblproducts;user id=root;password=geekprogramador"
'    connection = New MySqlConnection(strConnection)
'    dgv.Rows.Clear()
'    connection.Open()
'    command = New MySqlCommand
'    command.Connection = connection
'    command.CommandText = query
'    reader = command.ExecuteReader()
'    If reader.HasRows Then
'        While reader.Read
'            Try
'                dgv.Rows.Add(reader("NombProducto"), reader("Referencia"), reader("Inicial"), reader("Entradas"), reader("FechaIngreso"), reader("Salidas"), reader("FechaEgreso"), reader("Precio"), reader("FacturaCompra"))
'            Catch ex As Exception
'                MsgBox("Failed To Connection " & ex.Message)
'            End Try
'        End While
'    End If
'    reader.Close()
'    connection.Close()
'    Return dgv
'End Function