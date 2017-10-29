Public Class Datos_Provee
    Dim _codigo As Integer
    Dim _ruc As String
    Dim _dv As Integer
    Dim _nombre As String
    Dim _telefono As String
    Dim _fax As String
    Dim _direccion As String
    Dim _email As String
    Dim _tipoproveedor As String
    Public Property codigo As Integer

        Get
            codigo = _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property
    Public Property RUC As String
        Get
            RUC = _ruc
        End Get
        Set(value As String)
            _ruc = value
        End Set
    End Property
    Public Property DV As Integer

        Get
            DV = _dv
        End Get
        Set(value As Integer)
            _dv = value
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
    Public Property telefono As String
        Get
            telefono = _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Public Property fax As String
        Get
            fax = _fax
        End Get
        Set(value As String)
            _fax = value
        End Set

    End Property
    Public Property direccion As String
        Get
            direccion = _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set

    End Property
    Public Property email As String
        Get
            email = _email
        End Get
        Set(value As String)
            _email = value
        End Set

    End Property
    Public Property tipoproveedor As String
        Get
            tipoproveedor = _tipoproveedor
        End Get
        Set(value As String)
            _tipoproveedor = value
        End Set

    End Property
End Class
