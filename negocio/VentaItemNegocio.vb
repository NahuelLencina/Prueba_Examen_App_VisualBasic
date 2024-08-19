Imports dominio
Public Class VentaItemNegocio

    Public Sub agregarVentaItem(nuevo As VentaItem)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("insert into ventasitems(IDVenta,IDProducto,PrecioUnitario,Cantidad,PrecioTotal) values (@IDVenta,@IDProducto,@PrecioUnitario,@Cantidad,@PrecioTotal)")
            datos.setearParametro("@IDVenta", nuevo.IdVenta)
            datos.setearParametro("@IDProducto", nuevo.IdProducto)
            datos.setearParametro("@PrecioUnitario", nuevo.PrecioUnitario)
            datos.setearParametro("@Cantidad", nuevo.Cantidad)
            datos.setearParametro("@PrecioTotal", nuevo.PrecioTotal)

            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Sub



End Class
