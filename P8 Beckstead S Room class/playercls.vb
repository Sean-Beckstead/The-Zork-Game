Public Class playercls
    Private PlayerDirection As String
    Private spot As RoomCoordinates
    Private FacingExit As Boolean
    Private ExitLockedRm1 As Boolean
    Private FacingTreasure As Boolean
    Private Inventory(9) As Treasure
    Private Gold As Integer
    Private Keyring(9) As key


    Property MyKeyring(ByVal i As Integer) As key
        Get
            Return Keyring(i)
        End Get
        Set(ByVal value As key)
            Keyring(i) = value
        End Set
    End Property

    Property MyInventoryItems(ByVal i As Integer) As String
        Get
            Return Inventory(i).MyItem
        End Get
        Set(ByVal value As String)
            Inventory(i).MyItem = value
        End Set
    End Property

    Property MyGold() As Integer
        Get
            Return Gold
        End Get
        Set(ByVal value As Integer)
            Gold = value
        End Set
    End Property

    Property ImFacing() As String
        Get
            Return PlayerDirection
        End Get
        Set(ByVal value As String)
            PlayerDirection = value
        End Set
    End Property
    Property inroom() As RoomCoordinates
        Get
            Return spot
        End Get
        Set(ByVal value As RoomCoordinates)
            spot = value
        End Set
    End Property

    Property ImFacingExit() As Boolean
        Get
            Return FacingExit
        End Get
        Set(ByVal value As Boolean)
            FacingExit = value
        End Set
    End Property

    Property FacingExitLocked() As Boolean
        Get
            Return ExitLockedRm1
        End Get
        Set(ByVal value As Boolean)
            ExitLockedRm1 = value
        End Set
    End Property

    Property ImFacingTreasure() As Boolean
        Get
            Return FacingTreasure
        End Get
        Set(ByVal value As Boolean)
            FacingTreasure = value
        End Set
    End Property

    Sub New()

        PlayerDirection = "North"
        FacingExit = False
        FacingTreasure = False
        FacingExitLocked = True
        Gold = 0
        spot = New RoomCoordinates(1, 0)


    End Sub

End Class
