
Public Class VentaItem
        Public Property Producto As Producto
        Public Property Cantidad As Integer
        Public ReadOnly Property PrecioUnitario As Decimal
            Get
                Return Producto.Precio
            End Get
        End Property
        Public ReadOnly Property PrecioTotal As Decimal
            Get
                Return PrecioUnitario * Cantidad
            End Get
        End Property
    End Class

    Public Class Venta
        Public Property Id As Integer
        Public Property Cliente As Cliente
        Public Property Fecha As DateTime
        Public Property Items As List(Of VentaItem)
        Public ReadOnly Property TotalGeneral As Decimal
            Get
                Return Items.Sum(Function(item) item.PrecioTotal)
            End Get
        End Property
    End Class

