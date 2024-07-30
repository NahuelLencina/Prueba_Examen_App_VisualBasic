Imports dominio
Imports negocio

Public Class ClienteNegocio
    Public Function listar() As List(Of Cliente)

        Dim lista As New List(Of Cliente)
        Dim datos As New AccesoDatos

        Try
            datos.setearConsulta("select Id,Cliente,Telefono,Correo from clientes")
            datos.ejecutarLectura()

            While datos.Lector.Read()
                Dim cliente As New Cliente With {
                .Nombre = CStr(datos.Lector("Cliente")),
                .Id = CInt(datos.Lector("Id")),
                .Telefono = CStr(datos.Lector("Telefono")),
                .Email = CStr(datos.Lector("Correo"))
                }
                lista.Add(cliente)

            End While

            datos.cerrarConexion()
            Return lista

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Sub agregar(nuevo As Cliente)
        Dim datos As New AccesoDatos()

        Try
            ' Configurar la consulta SQL con parámetros
            datos.setearConsulta("INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@nombre, @telefono, @correo)")

            ' Establecer los parámetros de la consulta
            datos.setearParametro("@nombre", nuevo.Nombre)
            datos.setearParametro("@telefono", nuevo.Telefono)
            datos.setearParametro("@correo", nuevo.Email)

            ' Ejecutar la acción para insertar el cliente
            datos.ejecutarAccion()

        Catch ex As Exception
            ' Manejo de excepciones, por ejemplo, loggear el error
            Throw ex
        Finally
            ' Cerrar la conexión a la base de datos
            datos.cerrarConexion()
        End Try
    End Sub

    Public Sub eliminar(Id As Integer)
        Dim datos As New AccesoDatos()

        Try
            datos.setearConsulta("DELETE from clientes where Id = @Id")
            datos.setearParametro("@Id", Id)
            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Sub

    Public Sub modificar(modificar As Cliente)
        Dim datos As New AccesoDatos
        Try
            datos.setearConsulta("update clientes Set Cliente = @nombre, Telefono = @telefono, Correo = @correo where Id = @Id")
            datos.setearParametro("@nombre", modificar.Nombre)
            datos.setearParametro("@telefono", modificar.Telefono)
            datos.setearParametro("@correo", modificar.Email)
            datos.setearParametro("@Id", modificar.Id)
            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try

    End Sub


    Public Function filtrar(campo As String) As List(Of Cliente)
        Dim lista As New List(Of Cliente)
        Dim datos As New AccesoDatos


        Return lista
    End Function

End Class
