Public Class FrmProductos
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim altaProducto As New FrmAltaProducto
        FrmAltaProducto.ShowDialog()
    End Sub
End Class