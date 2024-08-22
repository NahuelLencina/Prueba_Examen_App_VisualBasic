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
            ocultarColumnas()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Private Sub ocultarColumnas()
        dgvListados.Columns("ID").Visible = False
        dgvListados.Columns("IdCliente").Visible = False
    End Sub

    Private Sub dgvListados_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListados.SelectionChanged
        If dgvListados.CurrentRow IsNot Nothing Then
            Dim seleccionado As Venta = CType(dgvListados.CurrentRow.DataBoundItem, Venta)
        End If
    End Sub

    Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
        Dim negocio As New VentaNegocio
        Dim seleccionado As Venta
        Try
            If dgvListados.CurrentRow IsNot Nothing Then
                Dim respuesta As DialogResult = MessageBox.Show("¿Vas a eliminar esta venta?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If respuesta = DialogResult.Yes Then
                    seleccionado = DirectCast(dgvListados.CurrentRow.DataBoundItem, Venta)
                    negocio.eliminar(seleccionado.Id)
                    cargar()
                    ' MessageBox.Show("Venta eliminada exitosamente...")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs)

    End Sub
End Class