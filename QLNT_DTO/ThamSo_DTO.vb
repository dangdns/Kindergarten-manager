Public Class ThamSo_DTO
    Dim intTuoiMax As Integer
    Dim intTuoiMin As Integer
    Dim HSD As Integer
    Dim intSiSoMax As Integer
    Dim intSokhoiMax As Integer
    Dim intSoLopMax As Integer

    Public Sub New()

    End Sub
    Public Sub New(tmax As Integer, tmin As Integer, sstd As Integer, sktd As Integer, sltd As Integer)
        intTuoiMax = tmax
        intTuoiMin = tmin
        intSiSoMax = sstd
        intSokhoiMax = sktd
        intSoLopMax = sltd
    End Sub
    Public Property IntTuoiMax1 As Integer
        Get
            Return intTuoiMax
        End Get
        Set(value As Integer)
            intTuoiMax = value
        End Set
    End Property

    Public Property IntTuoiMin1 As Integer
        Get
            Return intTuoiMin
        End Get
        Set(value As Integer)
            intTuoiMin = value
        End Set
    End Property

    Public Property IntSiSoMax1 As Integer
        Get
            Return intSiSoMax
        End Get
        Set(value As Integer)
            intSiSoMax = value
        End Set
    End Property

    Public Property IntSokhoiMax1 As Integer
        Get
            Return intSokhoiMax
        End Get
        Set(value As Integer)
            intSokhoiMax = value
        End Set
    End Property

    Public Property IntSoLopMax1 As Integer
        Get
            Return intSoLopMax
        End Get
        Set(value As Integer)
            intSoLopMax = value
        End Set
    End Property
End Class
