Imports dominio
Imports negocio

Public Class FrmAltaProducto

    Private _ProductoSeleccionado As Producto

    Public Sub New()
        InitializeComponent()
        'Crea el nuevo cliente
        Me.Text = "Agregar Nuevo Producto"
    End Sub

    Public Sub New(seleccionado As Producto)
        Me.New()
        _ProductoSeleccionado = seleccionado
        Me.Text = "Modificar Producto"
        ' Rellenar los controles con los datos del cliente seleccionado
        If _ProductoSeleccionado IsNot Nothing Then
            txtNombreProducto.Text = _ProductoSeleccionado.Nombre
            txtPrecioProducto.Text = _ProductoSeleccionado.Precio
            txtCategoriaProducto.Text = _ProductoSeleccionado.Categoria
        End If
    End Sub



    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        Close()
    End Sub

    Private Sub btnAceptarProducto_Click(sender As Object, e As EventArgs) Handles btnAceptarProducto.Click

        Dim producto As New Producto With {
        .Nombre = txtNombreProducto.Text,
        .Precio = Decimal.Parse(txtPrecioProducto.Text),
        .Categoria = txtCategoriaProducto.Text
        }
        Dim negocio As New ProductoNegocio()

        If _ProductoSeleccionado Is Nothing Then
            Try
                ' Intentar agregar el nuevo cliente
                negocio.agregar(producto)
                MessageBox.Show("Producto agregado exitosamente.")
                Close()

            Catch ex As Exception
                ' Mostrar el mensaje de error
                MessageBox.Show("Ocurrió un error al agregar el producto: " & ex.Message)
            End Try

        Else
            Try
                producto.Id = _ProductoSeleccionado.Id
                negocio.modificar(producto)
                MessageBox.Show("Producto modificado exitosamente.")
                Close()
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al modificar el producto: " & ex.Message)
            End Try

        End If
    End Sub
End Class