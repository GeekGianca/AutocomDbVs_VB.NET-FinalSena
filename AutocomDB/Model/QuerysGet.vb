Public Class QuerysGet
    Private selectLike As String
    Private selectAll As String
    Private selectTwoLikes As String
    Private delete As String
    Private update As String
    Private insert As String

    Public Function getSelectLike(filtre As String) As String
        selectLike = "SELECT * FROM producto WHERE NombProducto LIKE '%" & filtre & "%'"
        Return selectLike
    End Function

    Public Function getSelect() As String
        selectAll = "SELECT * FROM producto"
        Return selectAll
    End Function

    Public Function getSelectTwoLike(filtre As String, filtreTwo As String)
        selectTwoLikes = "SELECT * FROM producto WHERE NombProducto LIKE '%" & filtre & "%' AND Referencia LIKE '%" & filtreTwo & "%'"
        Return selectTwoLikes
    End Function

    Public Function getDelete(value As String)
        'Para evitar eliminar os datos mejor se ponen en un estado de desactivado y asi se tiene un registro del dato 
        delete = "UPDATE producto SET Estado =1 WHERE Referencia = '" & value & "'"
        Return delete
    End Function

    Public Function getUpdate(namePro As String, ref As String, ini As Integer, inP As Integer, dateIn As String, out As Integer, price As Double, purcF As String, typePro As String, typeRef As String)
        update = "UPDATE `producto` SET `NombProducto`='" & namePro & "',`Referencia`='" & ref & "',`Inicial`=" & ini & ",`Entradas`=" & inP & ",`FechaIngreso`='" & dateIn & "',`Salidas`=" & out & ",`Precio`=" & price & ",`FacturaCompra`='" & purcF & "' WHERE NombProducto = '" & typePro & "' And Referencia = '" & typeRef & "'"
        Return update
    End Function

    Public Function getInsert(namePro As String, ref As String, ini As Integer, inP As Integer, dateIn As String, out As Integer, dateOut As String, price As Double, purchaseIn As String)
        insert = "INSERT INTO producto ('NombProducto', 'Referencia', 'Inicial', 'Entradas', 'FechaIngreso', 'Salidas', 'FechaEgreso', 'Precio', 'FacturaCompra') VALUES ('" & namePro & "','" & ref & "'," & ini & "," & inP & ",'" & dateIn & "'," & out & ",'" & dateOut & "'," & price & ",'" & purchaseIn & "')"
        Return insert
    End Function
End Class
'Public Function getDelete(value As String, value2 As String)
'    'delete = "DELETE FROM producto WHERE NombProducto ='" & value & "' AND Referencia='" & value2 & "'"
'    delete = "UDATE productó SET Estado = " &  & "
'    Return delete
'End Function