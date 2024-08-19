Imports dominio
Imports negocio

Public Class FrmNuevaVenta

    Private _clienteSeleccionado As Cliente

    Public Sub New()
        InitializeComponent()
        'Crea el nuevo cliente
    End Sub

    Public Sub New(seleccionado As Cliente)
        Me.New()
        _clienteSeleccionado = seleccionado
        ' Rellena los controles con los datos del cliente seleccionado
        If _clienteSeleccionado IsNot Nothing Then
            txtNombreClienteNuevaVenta.Text = _clienteSeleccionado.Nombre
            txtTelefonoClienteNuevaVenta.Text = _clienteSeleccionado.Telefono
            txtEmailClienteNuevaVenta.Text = _clienteSeleccionado.Email
        End If
    End Sub

    Private Sub btnAgregarArticulos_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulos.Click
        FrmCargaArticulos.ShowDialog()
        dgvDetalleArticulos.DataSource = Nothing
        dgvDetalleArticulos.DataSource = FrmCargaArticulos.ProductosSeleccionados
        lblTotal.Text = "Total a pagar: $" & FrmCargaArticulos.lblValorTotal.Text
        ocultarDataGridView()
        ocultarColumnas()
    End Sub

    Private Sub btnLimpiarCamposNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnLimpiarCamposNuevaVenta.Click
        txtEmailClienteNuevaVenta.Clear()
        txtNombreClienteNuevaVenta.Clear()
        txtTelefonoClienteNuevaVenta.Clear()
    End Sub

    Private Sub FrmNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarDataGridView()
        Me.Text = "Formulario Venta"
    End Sub

    Private Sub ocultarDataGridView()
        If dgvDetalleArticulos.RowCount = 0 Then
            dgvDetalleArticulos.Visible = False
        Else
            dgvDetalleArticulos.Visible = True
        End If
    End Sub
    Private Sub ocultarColumnas()
        If dgvDetalleArticulos.Rows.Count > 0 Then
            dgvDetalleArticulos.Columns("Id").Visible = False
            dgvDetalleArticulos.Columns("Categoria").Visible = False
            dgvDetalleArticulos.Columns("ItemsPrecioTotal").Visible = False
        End If
    End Sub

    Private Sub btnAceptarVenta_Click(sender As Object, e As EventArgs) Handles btnAceptarVenta.Click

        Dim venta As New Venta With {
        .IdCliente = _clienteSeleccionado.Id,
        .Fecha = DateTime.Now,
        .Total = FrmCargaArticulos.lblValorTotal.Text
        }
        Dim negocio As New VentaNegocio

        Try
            'Agregar la venta
            negocio.agregarVenta(venta)
            MessageBox.Show("Carga exitosa.")
            Close()

        Catch ex As Exception
            ' Mostrar el mensaje de error
            MessageBox.Show("Ocurrió un error al agregar la venta: " & ex.Message)
        End Try

    End Sub
End Class