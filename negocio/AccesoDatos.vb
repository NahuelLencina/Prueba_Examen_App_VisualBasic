Imports System.Data.SqlClient

Public Class AccesoDatos
    Private conexion As SqlConnection
    Private comando As SqlCommand
    Private lectorField As SqlDataReader

    ' Property
    Public ReadOnly Property Lector As SqlDataReader
        Get
            Return lectorField
        End Get
    End Property

    ' Constructor 
    Public Sub New()
        conexion = New SqlConnection("server=.\SQLEXPRESS;Initial Catalog=pruebademo;Integrated Security=True")
        comando = New SqlCommand()
    End Sub

    ' Setear consulta
    Public Sub setearConsulta(consulta As String)
        comando.CommandType = CommandType.Text
        comando.CommandText = consulta
        comando.Parameters.Clear()
    End Sub

    ' Ejecutar lectura
    Public Sub ejecutarLectura()
        comando.Connection = conexion
        Try
            conexion.Open()
            lectorField = comando.ExecuteReader()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ' Setear parámetro
    Public Sub setearParametro(nombre As String, valor As Object)
        comando.Parameters.AddWithValue(nombre, valor)
    End Sub

    ' Ejecutar acción
    Public Sub ejecutarAccion()
        comando.Connection = conexion
        Try
            conexion.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cerrarConexion()
        End Try
    End Sub

    ' Cerrar conexión
    Public Sub cerrarConexion()
        If lectorField IsNot Nothing AndAlso Not lectorField.IsClosed Then
            lectorField.Close()
        End If
        If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

End Class
