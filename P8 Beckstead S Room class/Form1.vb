
Public Class Form1
    Dim BD As New Door
    Dim Door1 As New Door(True, True, False, 1)
    Dim Door2 As New Door(True, False, True, 2)
    Dim door3 As New Door(True, True, True, 3)
    Dim door4 As New Door(True, True, False, 4)
    Dim door5 As New Door(True, False, False, 5)
    Dim door6 As New Door(True, False, False, 6)
    Dim door7 As New Door(True, True, False, 7)
    Dim door8 As New Door(True, True, False, 8)
    Dim door9 As New Door(True, False, False, 9)
    Dim door10 As New Door(True, False, False, 10)
    Dim BlankRoom As New clsRoom



    Dim NoKey As New key
    Dim Key1 As New key(1, "Key 1", False)
    Dim key2 As New key(2, "Key 2", False)
    Dim key3 As New key(3, "Key 3", False)
    Dim key4 As New key(4, "Key 4", False)
    Dim key5 As New key(5, "Key 5", False)

    Dim room1 As clsRoom = BlankRoom
    Dim Room2 As New clsRoom(Color.Indigo, "Room2", BD, BD, door7, BD)
    Dim Room3 As New clsRoom(Color.LightGoldenrodYellow, "Room3", BD, door4, BD, door7)
    Dim Room4 As New clsRoom(Color.Aqua, "Room4", BD, BD, Door1, BD)
    Dim Room5 As New clsRoom(Color.Red, "Room5", BD, door3, Door2, Door1)
    Dim Room6 As New clsRoom(Color.Azure, "Room6", door4, door5, BD, Door2)
    Dim Room7 As New clsRoom(Color.Orange, "Room7", BD, door8, door6, BD)
    Dim Room8 As New clsRoom(Color.Green, "Room8", Door2, BD, BD, door6)
    Dim Room9 As New clsRoom(Color.Magenta, "Room9", door5, BD, BD, BD)
    Dim Room10 As New clsRoom(Color.LightGray, "Room10", door8, BD, BD, BD)
    Dim room11 As clsRoom = BlankRoom
    Dim room12 As clsRoom = BlankRoom



    Dim phealth As Integer = 100

    Dim GameRooms(4, 3) As clsRoom
    Dim character As New playercls
    Public BeenThere1 As Boolean
    Public BeenThere2 As Boolean
    Public BeenThere3 As Boolean
    Public BeenThere4 As Boolean
    Public BeenThere5 As Boolean
    Public BeenThere6 As Boolean
    Public BeenThere7 As Boolean
    Public BeenThere8 As Boolean
    Public BeenThere9 As Boolean



    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Map.Close()
        InventoryForm.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
        pbxLoadBox.Width = Me.Width
        pbxLoadBox.Height = Me.Height

        GameRooms(0, 0) = BlankRoom
        GameRooms(0, 1) = Room2
        GameRooms(0, 2) = Room3
        GameRooms(1, 0) = Room4
        GameRooms(1, 1) = Room5
        GameRooms(1, 2) = Room6
        GameRooms(2, 0) = Room7
        GameRooms(2, 1) = Room8
        GameRooms(2, 2) = Room9
        GameRooms(3, 0) = Room10
        GameRooms(3, 1) = BlankRoom
        GameRooms(3, 2) = BlankRoom

        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
        PbxWall.BackColor = GameRooms(character.inroom._row, character.inroom._column).newroomcolor
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint


        LbLMessage.BackColor = Me.PbxWall.BackColor

        If character.ImFacingExit = True Then
            pbxDoor.Visible = True
        Else
            pbxDoor.Visible = False
        End If

        If character.ImFacingTreasure = True Then
            PbxTreasure.Visible = True
        Else
            PbxTreasure.Visible = False
        End If

        Dim MyCanvas As Graphics = Me.CreateGraphics

        Dim RoomPaintColor As Color = GameRooms(character.inroom._row, character.inroom._column).newroomcolor

        Dim MyBrush As New SolidBrush(RoomPaintColor)
        Dim CeilingBrush As New SolidBrush(Color.SkyBlue)
        Dim floorBrush As New TextureBrush(My.Resources.Floor)

        Dim mypen As New Pen(Color.Black, 2)

        Dim LeftWall() As Point = {New Point(0, 0), New Point(PbxWall.Left, PbxWall.Top), New Point(PbxWall.Left, PbxWall.Bottom), New Point(0, 552)}
        Dim rightwall() As Point = {New Point(795, 0), New Point(PbxWall.Right, PbxWall.Top), New Point(PbxWall.Right, PbxWall.Bottom), New Point(795, 552)}
        Dim Ceiling() As Point = {New Point(2, 0), New Point(PbxWall.Location), New Point(PbxWall.Right, PbxWall.Top), New Point(793, 0)}
        Dim floor() As Point = {New Point(0, 552), New Point(PbxWall.Left, PbxWall.Bottom), New Point(PbxWall.Right, PbxWall.Bottom), New Point(793, 552)}

        MyCanvas.FillPolygon(MyBrush, LeftWall)
        MyCanvas.FillPolygon(MyBrush, rightwall)
        MyCanvas.FillPolygon(CeilingBrush, Ceiling)
        MyCanvas.FillPolygon(floorBrush, floor)
        MyCanvas.DrawLines(mypen, LeftWall)
        MyCanvas.DrawLines(mypen, rightwall)
        MyCanvas.DrawLines(mypen, floor)
        MyCanvas.DrawLines(mypen, Ceiling)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxDoor.Click
        Select Case character.inroom._row

            Case 0
                Select Case character.inroom._column
                    Case 1
                        Select Case character.ImFacing
                            Case "East"
                                If character.ImFacing = "East" And door7.IsLocked = False Then
                                    character.inroom._column = 2
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "East" And key4.PlayerHasKey = True > 0 And door7.IsLocked = True Then
                                    character.inroom._column = 2
                                    MsgBox("You use a key to unlock the door")
                                    door7.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If
                        End Select
                    Case 2
                        Select Case character.ImFacing
                            Case "West"
                                If character.ImFacing = "West" And door7.IsLocked = False Then
                                    character.inroom._column = 1
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "West" And key4.PlayerHasKey = True And door7.IsLocked = True Then
                                    character.inroom._column = 1
                                    MsgBox("You use a key to unlock the door")
                                    door7.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If

                            Case "South"

                                If character.ImFacing = "South" And door4.IsLocked = False Then
                                    character.inroom._row = 1
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "South" And NoKey.PlayerHasKey = True And door4.IsLocked = True Then
                                    character.inroom._row = 1
                                    MsgBox("You use a key to unlock the door")
                                    door4.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If
                        End Select
                End Select

            Case 1

                Select Case character.inroom._column
                    Case 0
                        If character.ImFacing = "East" And Door1.IsLocked = False Then
                            character.inroom._column = 1
                            MsgBox("Door was unlocked")
                            Exit Select
                        End If

                        If character.ImFacing = "East" And Key1.PlayerHasKey = True And Door1.IsLocked = True Then
                            character.inroom._column = 1
                            MsgBox("You use a key to unlock the door")
                            Door1.IsLocked = False
                        Else
                            MsgBox("Door is locked you need to find a key.")
                        End If
                    Case 1
                        Select Case character.ImFacing
                            Case "West"
                                If character.ImFacing = "West" And Door1.IsLocked = False Then
                                    character.inroom._column = 0
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "West" And Key1.PlayerHasKey = True And Door1.IsLocked = True Then
                                    character.inroom._column = 0
                                    MsgBox("You use a key to unlock the door")
                                    Door1.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If

                            Case "East"

                                If character.ImFacing = "East" And Door2.IsLocked = False Then
                                    character.inroom._column = 2
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "East" And NoKey.PlayerHasKey = True And Door2.IsLocked = True Then
                                    character.inroom._column = 2
                                    MsgBox("You use a key to unlock the door")
                                    Door2.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If

                            Case "South"

                                If character.ImFacing = "South" And door3.IsLocked = False Then
                                    character.inroom._row = 2
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "South" And key2.PlayerHasKey = True And door3.IsLocked = True Then
                                    character.inroom._row = 2
                                    MsgBox("You use a key to unlock the door")
                                    door3.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If
                        End Select
                    Case 2
                        Select Case character.ImFacing
                            Case "West"
                                If character.ImFacing = "West" And Door2.IsLocked = False Then
                                    character.inroom._column = 1
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = True
                                    Exit Select
                                End If

                                If character.ImFacing = "West" And NoKey.PlayerHasKey = True And Door2.IsLocked = True Then
                                    character.inroom._column = 1
                                    MsgBox("You use a key to unlock the door")
                                    Door2.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If

                            Case "North"

                                If character.ImFacing = "North" And door4.IsLocked = False Then
                                    character.inroom._row = 0
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "North" And key3.PlayerHasKey = True And door4.IsLocked = True Then
                                    character.inroom._row = 0
                                    MsgBox("You use a key to unlock the door")
                                    door4.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If

                            Case "South"

                                If character.ImFacing = "South" And door5.IsLocked = False Then
                                    character.inroom._row = 2
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "South" And NoKey.PlayerHasKey = True And door5.IsLocked = True Then
                                    character.inroom._row = 2
                                    MsgBox("You use a key to unlock the door")
                                    door5.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If
                        End Select
                End Select
            Case 2
                Select Case character.inroom._column
                    Case 0
                        Select Case character.ImFacing
                            Case "East"
                                If character.ImFacing = "East" And door6.IsLocked = False Then
                                    character.inroom._column = 1
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    character.ImFacingTreasure = True
                                    Exit Select
                                End If

                                If character.ImFacing = "East" And NoKey.PlayerHasKey = True > 0 And door6.IsLocked = True Then
                                    character.inroom._column = 1
                                    MsgBox("You use a key to unlock the door")
                                    door6.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If

                            Case "South"

                                If character.ImFacing = "South" And door8.IsLocked = False Then
                                    character.inroom._row = 3
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "South" And key3.PlayerHasKey = True And door8.IsLocked = True Then
                                    character.inroom._row = 3
                                    MsgBox("You use a key to unlock the door")
                                    door8.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If
                        End Select
                    Case 1
                        Select Case character.ImFacing
                            Case "West"
                                If character.ImFacing = "West" And door6.IsLocked = False Then
                                    character.inroom._column = 0
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "West" And NoKey.PlayerHasKey = True And door6.IsLocked = True Then
                                    character.inroom._column = 0
                                    MsgBox("You use a key to unlock the door")
                                    door6.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If

                            Case "North"

                                If character.ImFacing = "North" And door3.IsLocked = False Then
                                    character.inroom._row = 1
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "North" And key2.PlayerHasKey = True And door3.IsLocked = True Then
                                    character.inroom._row = 1
                                    MsgBox("You use a key to unlock the door")
                                    door3.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If
                        End Select
                    Case 2
                        Select Case character.ImFacing
                            Case "North"
                                If character.ImFacing = "North" And door5.IsLocked = False Then
                                    character.inroom._row = 1
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = True
                                    Exit Select
                                End If

                                If character.ImFacing = "North" And NoKey.PlayerHasKey = True And door5.IsLocked = True Then
                                    character.inroom._row = 1
                                    MsgBox("You use a key to unlock the door")
                                    door7.IsLocked = False
                                    character.ImFacingExit = True
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If
                        End Select
                End Select

            Case 3
                Select Case character.inroom._column
                    Case 0
                        Select Case character.ImFacing
                            Case "North"
                                If character.ImFacing = "North" And door8.IsLocked = False Then
                                    character.inroom._row = 2
                                    MsgBox("Door was unlocked")
                                    character.ImFacingExit = False
                                    Exit Select
                                End If

                                If character.ImFacing = "North" And key3.PlayerHasKey = True > 0 And door8.IsLocked = True Then
                                    character.inroom._row = 2
                                    MsgBox("You use a key to unlock the door")
                                    door8.IsLocked = False
                                    character.ImFacingExit = False
                                Else
                                    MsgBox("Door is locked you need to find a key.")
                                End If
                        End Select
                End Select
        End Select


        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
        PbxWall.BackColor = GameRooms(character.inroom._row, character.inroom._column).newroomcolor
        pbxLoadBox.Show()
        pbxLoadBox.Hide()

    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click

        Select Case GameRooms(character.inroom._row, character.inroom._column).RoomName
            Case "Room4"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select
            Case "Room5"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select


            Case "Room6"

                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select
            Case "Room8"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select
            Case "Room3"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select

            Case "Room7"

                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select
            Case "Room10"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select
            Case "Room2"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select

            Case "Room9"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthL(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "West"
                        Call WestL(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "South"
                        Call SouthL(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                    Case "East"
                        Call EastL(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Select
                End Select
        End Select
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        Select Case GameRooms(character.inroom._row, character.inroom._column).RoomName
            Case "Room4"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        Call EastR(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
            Case "Room5"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        character.ImFacing = "South"
                        Call EastR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
            Case "Room6"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        Call EastR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
            Case "Room8"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        Call EastR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
            Case "Room3"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        Call EastR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
            Case "Room7"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        Call EastR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
            Case "Room10"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        Call EastR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
            Case "Room2"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        Call EastR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
            Case "Room9"
                Select Case character.ImFacing
                    Case "North"
                        Call NorthR(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "West"
                        Call WestR(True, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "South"
                        Call SouthR(False, True)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                    Case "East"
                        Call EastR(False, False)

                        Label1.Text = GameRooms(character.inroom._row, character.inroom._column).RoomName
                        Exit Sub
                End Select
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Map.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 50

        If character.ImFacing = "East" Then
            LblEast.ForeColor = Color.Red
        Else : LblEast.ForeColor = Color.Black
        End If
        If character.ImFacing = "West" Then
            LblWest.ForeColor = Color.Red
        Else : LblWest.ForeColor = Color.Black
        End If
        If character.ImFacing = "South" Then
            LblSouth.ForeColor = Color.Red
        Else : LblSouth.ForeColor = Color.Black
        End If
        If character.ImFacing = "North" Then
            LblNorth.ForeColor = Color.Red
        Else : LblNorth.ForeColor = Color.Black
        End If

        MapCheck()

    End Sub

    Private Sub PbxTreasure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxTreasure.Click
        Select Case GameRooms(character.inroom._row, character.inroom._column).RoomName
            Case "Room2"
                Exit Select
            Case "Room3"
                Exit Select
            Case "Room4"
                Key1.PlayerHasKey = True
                MsgBox("You recieve Key 1")
                Exit Select
            Case "Room5"
                Exit Select
            Case "Room6"
                Exit Select
            Case "Room7"
                Exit Select
            Case "Room8"
                key3.PlayerHasKey = True
                MsgBox("You recieve Key 3")
                Exit Select
            Case "Room9"
                If character.ImFacing = "East" Then
                    key2.PlayerHasKey = True
                    MsgBox("You recieve Key 2")
                End If
                If character.ImFacing = "West" Then
                    character.MyGold = 100
                    MsgBox("You recieve 100 gold")
                End If
                Exit Select
            Case "Room10"
                If character.ImFacing = "East" Then
                    key4.PlayerHasKey = True
                    MsgBox("You recieve Key 4")
                End If
                If character.ImFacing = "West" Then
                    character.MyGold = 100
                    MsgBox("You recieve 100 gold")
                End If
                Exit Select
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        InventoryForm.Show()
        InventoryForm.lstInventory.Items.Clear()
        InventoryForm.lstInventory.Items.Add("Gold: " & character.MyGold)

        InventoryForm.lstInventory.Items.Add("Keys: ")
        If Key1.PlayerHasKey = True Then InventoryForm.lstInventory.Items.Add(Key1.theRmKey)
        If key2.PlayerHasKey = True Then InventoryForm.lstInventory.Items.Add(key2.theRmKey)
        If key3.PlayerHasKey = True Then InventoryForm.lstInventory.Items.Add(key3.theRmKey)
        If key4.PlayerHasKey = True Then InventoryForm.lstInventory.Items.Add(key4.theRmKey)

    End Sub

    Sub MapCheck()

        Select Case GameRooms(character.inroom._row, character.inroom._column).RoomName
            Case "Room4"
                BeenThere1 = True
            Case "Room5"
                BeenThere2 = True
            Case "Room6"
                BeenThere3 = True
            Case "Room8"
                BeenThere4 = True
            Case "Room3"
                BeenThere5 = True
            Case "Room7"
                BeenThere6 = True
            Case "Room10"
                BeenThere7 = True
            Case "Room2"
                BeenThere8 = True
            Case "Room9"
                BeenThere9 = True
        End Select

        If BeenThere1 = True Then Map.MapRoom1.Visible = True

        If BeenThere2 = True Then
            Map.MapRoom2.Visible = True
            Map.MapRoomPath1.Visible = True
        End If

        If BeenThere3 = True Then
            Map.MapRoom3.Visible = True
            Map.MapRoomPath2.Visible = True
        End If

        If BeenThere4 = True Then
            Map.MapRoom4.Visible = True
            Map.MapRoomPath3.Visible = True
        End If

        If BeenThere5 = True Then
            Map.MapRoom5.Visible = True
            Map.MapRoomPath4.Visible = True
        End If

        If BeenThere6 = True Then
            Map.MapRoom6.Visible = True
            Map.MapRoomPath7.Visible = True
        End If

        If BeenThere7 = True Then
            Map.MapRoom7.Visible = True
            Map.MapRoomPath8.Visible = True
        End If

        If BeenThere8 = True Then
            Map.MapRoom8.Visible = True
            Map.MapRoomPath5.Visible = True
        End If

        If BeenThere9 = True Then
            Map.MapRoom9.Visible = True
            Map.MapRoomPath6.Visible = True
        End If
    End Sub

    Sub NorthL(ByVal E As Boolean, ByVal T As Boolean)

        character.ImFacing = "West"
        character.ImFacingExit = E
        character.ImFacingTreasure = T

        pbxLoadBox.Show()
        pbxLoadBox.Hide()
    End Sub

    Sub WestL(ByVal E As Boolean, ByVal t As Boolean)

        character.ImFacing = "South"
        character.ImFacingExit = E
        character.ImFacingTreasure = t

        pbxLoadBox.Show()
        pbxLoadBox.Hide()
    End Sub

    Sub SouthL(ByVal E As Boolean, ByVal T As Boolean)

        character.ImFacing = "East"
        character.ImFacingExit = E
        character.ImFacingTreasure = T

        pbxLoadBox.Show()
        pbxLoadBox.Hide()
    End Sub

    Sub EastL(ByVal E As Boolean, ByVal T As Boolean)

        character.ImFacing = "North"
        character.ImFacingExit = E
        character.ImFacingTreasure = T

        pbxLoadBox.Show()
        pbxLoadBox.Hide()
    End Sub

    Sub EastR(ByVal E As Boolean, ByVal T As Boolean)

        character.ImFacing = "South"
        character.ImFacingExit = E
        character.ImFacingTreasure = T

        pbxLoadBox.Show()
        pbxLoadBox.Hide()
    End Sub

    Sub WestR(ByVal E As Boolean, ByVal T As Boolean)

        character.ImFacing = "North"
        character.ImFacingExit = E
        character.ImFacingTreasure = T

        pbxLoadBox.Show()
        pbxLoadBox.Hide()
    End Sub

    Sub NorthR(ByVal E As Boolean, ByVal T As Boolean)

        character.ImFacing = "East"
        character.ImFacingExit = E
        character.ImFacingTreasure = T

        pbxLoadBox.Show()
        pbxLoadBox.Hide()
    End Sub

    Sub SouthR(ByVal E As Boolean, ByVal T As Boolean)

        character.ImFacing = "West"
        character.ImFacingExit = E
        character.ImFacingTreasure = T

        pbxLoadBox.Show()
        pbxLoadBox.Hide()
    End Sub
End Class
