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

    Public Sub agregarVenta(nuevo As Venta)
        Dim datos As New AccesoDatos()
        Try
            datos.setearConsulta("INSERT INTO ventas (idCliente, Fecha, Total) VALUES (@idCliente, @Fecha, @Total)")

            datos.setearParametro("@idCliente", nuevo.IdCliente)
            datos.setearParametro("@fecha", nuevo.Fecha)
            datos.setearParametro("@total", nuevo.Total)

            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try


    End Sub

    Public Sub modificarVenta(modificar As Venta)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("update ventas Set Total = @total, Fecha = @fecha, IdCliente = @IdCliente where Id = @Id")
            datos.setearParametro("@total", modificar.Total)
            datos.setearParametro("@IdCliente", modificar.IdCliente)
            datos.setearParametro("@Fecha", modificar.Fecha)
            datos.ejecutarAccion()

            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub

    ' Método para obtener el último ID insertado
    Public Function obtenerUltimoIdVenta() As Integer
        Dim datos As New AccesoDatos()
        Dim ultimoId As Integer = -1 ' Valor predeterminado para indicar que no se encontró un ID

        Try
            datos.setearConsulta("SELECT TOP 1 v.Id FROM Ventas v ORDER BY v.Id DESC")
            datos.ejecutarLectura()

            If datos.Lector.Read() Then
                If Not IsDBNull(datos.Lector("Id")) Then
                    ultimoId = Convert.ToInt32(datos.Lector("Id"))
                End If
            End If

            Return ultimoId

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

End Class
