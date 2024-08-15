Imports dominio

Public Class VentaNegocio
    Public Function listar() As List(Of Venta)

        Dim lista As New List(Of Venta)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("select v.Id, v.IdCliente,v.Fecha,v.Total, c.cliente from Ventas v, clientes c where c.ID = v.IDCliente")
            datos.ejecutarLectura()

            While datos.Lector.Read()

                Dim venta As New Venta With {
                .Id = CInt(datos.Lector("Id")),
                .IdCliente = CInt(datos.Lector("IdCliente")),
                .Fecha = CDate(datos.Lector("Fecha")),
                .Total = CDec(datos.Lector("Total")),
                .Nombre = CStr(datos.Lector("cliente"))
                }
                lista.Add(venta)
            End While
            datos.cerrarConexion()
            Return lista
        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Sub eliminar(Id As Integer)
        Dim datos As New AccesoDatos()

        Try
            ' Eliminar de ventasItems
            datos.setearConsulta("Delete from ventasitems where IDVenta = @Id")
            datos.setearParametro("@Id", Id)
            datos.ejecutarAccion()

            ' Eliminar de Ventas
            datos.setearConsulta("DELETE from Ventas where Id = @Id")
            datos.setearParametro("@Id", Id)
            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Sub

    Public Sub nuevaVenta(nuevo As Venta)
        Dim datos As New AccesoDatos()
        Try
            datos.setearConsulta("")

        Catch ex As Exception
            Throw
        Finally
            datos.cerrarConexion()
        End Try


    End Sub

End Class
