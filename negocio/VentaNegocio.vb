Imports dominio

Public Class VentaNegocio
    Public Function listar() As List(Of Venta)

        Dim lista As New List(Of Venta)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("select v.Id, v.IdCliente,v.Fecha,v.Total, c.cliente from Ventas v inner join clientes c on c.ID = v.IDCliente")
            datos.ejecutarLectura()

            While datos.Lector.Read()
                Dim venta As New Venta With {
                .Id = CInt(datos.Lector("Id")),
                .IdCliente = CInt(datos.Lector("IdCliente")),
                .Fecha = CDate(datos.Lector("Fecha")),
                .Total = CDec(datos.Lector("Total"))
                }
                lista.Add(venta)

            End While

            datos.cerrarConexion()
                Return lista
        Catch ex As Exception
            Throw ex
        End Try


    End Function

End Class
