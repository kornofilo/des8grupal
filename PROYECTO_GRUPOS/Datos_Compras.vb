
Public Class Datos_Compras
    Dim _idcompra As Integer
    Dim _idprovee As Integer
    Dim _nombre As String
    Dim _fecha As Date
    Dim _idproduc As Integer
    Dim _produc As String
    Dim _cant As Integer
    Dim _costouni As Double
    Dim _totalcompr As Double
    Dim _tipocompr As String
    Dim _cxp As Integer

    Public Property idcompra As Integer
        Get
            idcompra = _idcompra
        End Get
        Set(value As Integer)
            _idcompra = value
        End Set
    End Property
    Public Property idproveedor As Integer
        Get
            idproveedor = _idprovee
        End Get
        Set(value As Integer)
            _idprovee = value
        End Set
    End Property
    Public Property nombre As String

        Get
            nombre = _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property fecha As Date
        Get
            fecha = _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property idproducto As Integer
        Get
            idproducto = _idproduc
        End Get
        Set(value As Integer)
            _idproduc = value
        End Set
    End Property
    Public Property producto As String
        Get
            producto = _produc
        End Get
        Set(value As String)
            _produc = value
        End Set

    End Property
    Public Property cantidad As Integer
        Get
            cantidad = _cant
        End Get
        Set(value As Integer)
            _cant = value
        End Set

    End Property
    Public Property costounidad As Double
        Get
            costounidad = _costouni
        End Get
        Set(value As Double)
            _costouni = value
        End Set

    End Property
    Public Property totalcompra As String
        Get
            totalcompra = _totalcompr
        End Get
        Set(value As String)
            _totalcompr = value
        End Set

    End Property
    Public Property tipocompra As String
        Get
            tipocompra = _tipocompr
        End Get
        Set(value As String)
            _tipocompr = value
        End Set

    End Property
    Public Property cxp As String
        Get
            cxp = _cxp
        End Get
        Set(value As String)
            _cxp = value
        End Set

    End Property
End Class
