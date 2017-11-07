Public Class Datos_Pagos
    Dim _idPago As Integer
    Dim _idproveedor As Integer
    Dim _monto As Decimal
    Dim _fecha As Date
    Dim _id_compra As Integer
    Dim _saldo As Decimal

    Public Property IDPago As Integer
        Get
            IDPago = _idPago
        End Get
        Set(value As Integer)
            _idPago = value
        End Set
    End Property

    Public Property IDProveedor As Integer
        Get
            IDProveedor = _idproveedor
        End Get
        Set(value As Integer)
            _idproveedor = value
        End Set
    End Property


    Public Property Monto As Decimal
        Get
            Monto = _monto
        End Get
        Set(value As Decimal)
            _monto = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Fecha = _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property IDCompra As Integer
        Get
            IDCompra = _id_compra
        End Get
        Set(value As Integer)
            _id_compra = value
        End Set
    End Property

    Public Property Saldo As Decimal
        Get
            Saldo = _saldo
        End Get
        Set(value As Decimal)
            _saldo = value
        End Set
    End Property
End Class
