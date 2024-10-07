Imports dominio
Public Class VentaItemNegocio

    Public Function listar(idVenta As Integer) As List(Of VentaItem)
        Dim lista As New List(Of VentaItem)
        Dim datos As New AccesoDatos

        Try
            datos.setearConsulta("select IdVenta, IdProducto, v.Fecha as Fecha ,p.Nombre as Nombre, PrecioUnitario, Cantidad,PrecioTotal from ventasitems inner join productos p on p.Id = IDProducto inner join ventas v on v.Id =  ventasitems.IDVenta where  idVenta = @idVenta")
            datos.setearParametro("@idVenta", idVenta)
            datos.ejecutarLectura()

            While datos.Lector.Read()
                Dim ventaItem As New VentaItem With {
                 .IdVenta = CInt(datos.Lector("IdVenta")),
                 .Fecha = CDate(datos.Lector("Fecha")),
                 .NombreProducto = CStr(datos.Lector("Nombre")),
                 .IdProducto = CInt(datos.Lector("IdProducto")),
                 .PrecioUnitario = CDec(datos.Lector("PrecioUnitario")),
                 .Cantidad = CInt(datos.Lector("Cantidad")),
                .PrecioTotal = CDec(datos.Lector("PrecioTotal"))
                }
                lista.Add(ventaItem)
            End While

            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function



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

    Public Sub modificarVentaItem(seleccionado As VentaItem)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("  update ventasitems set IdVenta = @Idventa, IdProducto = @IdProducto, PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal where ID = @Id")
            datos.setearParametro("@IDVenta", seleccionado.IdVenta)
            datos.setearParametro("@IDProducto", seleccionado.IdProducto)
            datos.setearParametro("@PrecioUnitario", seleccionado.PrecioUnitario)
            datos.setearParametro("@Cantidad", seleccionado.Cantidad)
            datos.setearParametro("@PrecioTotal", seleccionado.PrecioTotal)
            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub



End Class
