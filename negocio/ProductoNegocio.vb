Imports dominio


Public Class ProductoNegocio

    Public Function listar() As List(Of Producto)

        Dim lista As New List(Of Producto)
        Dim datos As New AccesoDatos

        Try
            datos.setearConsulta("select Id, Nombre, Precio, Categoria from productos")
            datos.ejecutarLectura()

            While datos.Lector.Read()
                Dim producto As New Producto With {
                .Nombre = CStr(datos.Lector("Nombre")),
                .Id = CInt(datos.Lector("Id")),
                .Precio = CDec(datos.Lector("Precio")),
                .Categoria = CStr(datos.Lector("Categoria"))
                }
                lista.Add(producto)

            End While


            Return lista

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function


    Public Sub agregar(nuevo As Producto)
        Dim datos As New AccesoDatos()

        Try
            ' Configurar la consulta SQL con parámetros
            datos.setearConsulta("INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@nombre, @precio, @categoria)")

            ' Establecer los parámetros de la consulta
            datos.setearParametro("@nombre", nuevo.Nombre)
            datos.setearParametro("@precio", nuevo.Precio)
            datos.setearParametro("@categoria", nuevo.Categoria)
            ' Ejecutar la acción para insertar el producto
            datos.ejecutarAccion()

        Catch ex As Exception
            ' Manejo de excepciones
            Throw ex
        Finally
            ' Cerrar la conexión a la base de datos
            datos.cerrarConexion()
        End Try
    End Sub

    Public Sub eliminar(Id As Integer)
        Dim datos As New AccesoDatos()

        Try
            datos.setearConsulta("DELETE from productos where Id = @Id")
            datos.setearParametro("@Id", Id)
            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Sub

    Public Sub modificar(modificar As Producto)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("update productos Set Nombre = @nombre, Precio = @precio, Categoria = @categoria where Id = @Id")
            datos.setearParametro("@nombre", modificar.Nombre)
            datos.setearParametro("@precio", modificar.Precio)
            datos.setearParametro("@categoria", modificar.Categoria)
            datos.setearParametro("@Id", modificar.Id)
            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Sub


    Public Function filtrar(campo As String) As List(Of Producto)
        Dim lista As New List(Of Producto)
        Dim datos As New AccesoDatos


        Return lista
    End Function

End Class
