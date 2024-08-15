Public Class FrmPresentacion
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim Frmcliente As New FrmClientes
        Frmcliente.ShowDialog()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim FrmProducto As New FrmProductos
        FrmProducto.ShowDialog()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim FrmVenta As New FrmVentas
        FrmVentas.ShowDialog()
    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        FrmClientes.ShowDialog()
    End Sub
End Class
