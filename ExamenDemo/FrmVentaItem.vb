Imports negocio
Imports dominio

Public Class FrmVentaItem

    Private listaVentaItem As New List(Of VentaItem)
    Private ventaId As Integer

    'Constructor que recibe un id

    Public Sub New(id As Integer)
        InitializeComponent()
        ventaId = id
    End Sub

    Private Sub ocultarColumnas()
        dgvItemsVentas.Columns("IdVenta").Visible = False
        dgvItemsVentas.Columns("IdProducto").Visible = False
        dgvItemsVentas.Columns("IdVenta").Visible = False
    End Sub

    Private Sub FrmVentaItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
    Public Sub cargar()
        Try
            Dim negocio As New VentaItemNegocio
            listaVentaItem = negocio.listar(ventaId)
            dgvItemsVentas.DataSource = listaVentaItem
            ocultarColumnas()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub btnAtrasVentas_Click(sender As Object, e As EventArgs) Handles btnAtrasVentas.Click
        Close()
    End Sub
End Class