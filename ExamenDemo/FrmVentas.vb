Imports negocio
Imports dominio
Public Class FrmVentas
    Private listaVentas As New List(Of Venta)
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Public Sub cargar()
        Try
            Dim negocio As New VentaNegocio
            listaVentas = negocio.listar
            dgvListados.DataSource = listaVentas

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

End Class