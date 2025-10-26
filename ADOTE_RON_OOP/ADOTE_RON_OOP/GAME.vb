Imports System.Media
Imports System.Net.Mime.MediaTypeNames
Imports Windows.Win32.System

Public Class GAME
    Dim rIsland As New List(Of String) From {"P1", "P2", "P3", "M1", "M2", "M3"}
    Dim lIsland As New List(Of String)
    Dim boat As New List(Of String)
    Dim isRight As Boolean = True
    Private Sub GAME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssets()
        LoadSound()
    End Sub

    Public Sub LoadAssets()
        RboatImg.Parent = oceanBg
        LboatImg.Parent = oceanBg

        RH1.Parent = oceanBg
        RH2.Parent = oceanBg
        RH3.Parent = oceanBg
        RM1.Parent = oceanBg
        RM2.Parent = oceanBg
        RM3.Parent = oceanBg

        RBH1.Parent = oceanBg
        RBH2.Parent = oceanBg
        RBH3.Parent = oceanBg
        RBM1.Parent = oceanBg
        RBM2.Parent = oceanBg
        RBM3.Parent = oceanBg

        LH1.Parent = oceanBg
        LH2.Parent = oceanBg
        LH3.Parent = oceanBg
        LM1.Parent = oceanBg
        LM2.Parent = oceanBg
        LM3.Parent = oceanBg

        LBH1.Parent = oceanBg
        LBH2.Parent = oceanBg
        LBH3.Parent = oceanBg
        LBM1.Parent = oceanBg
        LBM2.Parent = oceanBg
        LBM3.Parent = oceanBg

        H1.Parent = oceanBg
        H2.Parent = oceanBg
        H3.Parent = oceanBg

        bgBoat.Parent = oceanBg
        Label1.Parent = oceanBg
        sunImg.Parent = oceanBg
        rightIslandImg.Parent = oceanBg
        leftIslandImg.Parent = oceanBg
        bgPlane.Parent = oceanBg
        whateImg.Parent = oceanBg

    End Sub


    Public Sub LoadSound()
        'Dim sound As New SoundPlayer("C:\Users\CLIENT\Downloads\Party Tunes – Brainrot Rap [Official Video].wav")
        'sound.PlayLooping()
    End Sub

    Dim planeX As Integer = 1231
    Dim boatX As Integer = -148

    Private Sub planeTimer_Tick(sender As Object, e As EventArgs) Handles PlaneTimer.Tick
        planeX -= 1
        If planeX < -bgPlane.Width Then
            planeX = Me.ClientSize.Width
        End If
        bgPlane.Location = New Point(planeX, 210)
    End Sub

    Private Sub boatTimer_Tick(sender As Object, e As EventArgs) Handles BoatTimer.Tick
        boatX += 1
        If boatX > Me.ClientSize.Width Then
            boatX = -bgBoat.Width
        End If
        bgBoat.Location = New Point(boatX, 510)
    End Sub

    'rightSide main process starts
    Private Sub RH1_Click(sender As Object, e As EventArgs) Handles RH1.Click, RH2.Click, RH3.Click, RM1.Click, RM2.Click, RM3.Click
        Dim btn As PictureBox = DirectCast(sender, PictureBox)
        If checkFull() Then
            MsgBox("The Boat is Full!", vbInformation, "Boat is Full!!")
            Exit Sub
        End If
        Select Case btn.Name
            Case "RH1"
                moveElementInBoat("RBH1")
                addToRightBoat("P1")
                btn.Visible = False
            Case "RH2"
                moveElementInBoat("RBH2")
                addToRightBoat("P2")
                btn.Visible = False
            Case "RH3"
                moveElementInBoat("RBH3")
                addToRightBoat("P3")
                btn.Visible = False
            Case "RM1"
                moveElementInBoat("RBM1")
                addToRightBoat("M1")
                btn.Visible = False
            Case "RM2"
                moveElementInBoat("RBM2")
                addToRightBoat("M2")
                btn.Visible = False
            Case "RM3"
                moveElementInBoat("RBM3")
                addToRightBoat("M3")
                btn.Visible = False
        End Select
    End Sub

    Private Sub rightBoat_Click(sender As Object, e As EventArgs) Handles RBH1.Click, RBH2.Click, RBH3.Click, RBM1.Click, RBM2.Click, RBM3.Click
        Dim btn As PictureBox = DirectCast(sender, PictureBox)
        Select Case btn.Name
            Case "RBH1"
                backToRightIslandFromBoat("P1", "RH1")
                btn.Visible = False
            Case "RBH2"
                backToRightIslandFromBoat("P2", "RH2")
                btn.Visible = False
            Case "RBH3"
                backToRightIslandFromBoat("P3", "RH3")
                btn.Visible = False
            Case "RBM1"
                backToRightIslandFromBoat("M1", "RM1")
                btn.Visible = False
            Case "RBM2"
                backToRightIslandFromBoat("M2", "RM2")
                btn.Visible = False
            Case "RBM3"
                backToRightIslandFromBoat("M3", "RM3")
                btn.Visible = False
        End Select
        adjustPosition(btn.Name)
    End Sub

    Private Sub RboatImg_Click(sender As Object, e As EventArgs) Handles RboatImg.Click
        If checkBoatIfEmpty() Then
            MsgBox("BOAT IS EMPTY!", vbInformation, "BOAT EMPTY!")
            Exit Sub
        End If
        LboatImg.Visible = True
            RboatImg.Visible = False
            displaycount()
            makevisible()
        isRight = False
    End Sub
    'rightSide main process end


    'rightSide methods start
    Public Function checkFull()
        If boat.Count >= 2 Then
            Return True
        End If
        Return False
    End Function

    Public Sub moveElementInBoat(name As String)
        Dim pb As PictureBox = CType(oceanBg.Controls(name), PictureBox)
        If boat.Count = 1 Then
            Dim pont As New Point(776, 621)
            If IsLocationUsedInRightBoat(pont) Then
                pb.Location = New Point(861, 621)
            Else
                pb.Location = New Point(776, 621)
            End If
        End If
        pb.Visible = True
    End Sub

    Public Sub addToRightBoat(rightBoatElement As String)
        For Each elem In rIsland
            If elem = rightBoatElement Then
                boat.Add(elem)
            End If
        Next
        displaycount()
    End Sub

    Public Sub backToRightIslandFromBoat(rightIslandElement As String, rightboat As String)
        For Each elem In rIsland
            If elem = rightIslandElement Then
                boat.Remove(rightIslandElement)
                Dim pbs As PictureBox = CType(oceanBg.Controls(rightboat), PictureBox)
                pbs.Visible = True
                displaycount()
                Exit Sub
            End If
        Next
        rIsland.Add(rightIslandElement)
        boat.Remove(rightIslandElement)
        displaycount()
        Dim pb As PictureBox = CType(oceanBg.Controls(rightboat), PictureBox)
        pb.Visible = True
    End Sub

    Public Sub adjustPosition(elem As String)
        Dim check As New Point(776, 621)
        Dim pb As PictureBox = CType(oceanBg.Controls(elem), PictureBox)
        If pb.Location = check Then
            pb.Location = New Point(861, 621)
        End If
    End Sub

    Private Function IsLocationUsedInRightBoat(checkPoint As Point) As Boolean
        For Each pb As PictureBox In oceanBg.Controls.OfType(Of PictureBox)()
            If pb.Location = checkPoint Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function countPriestOnRightIsland()
        Dim count As Integer
        For Each e In rIsland
            If e.StartsWith("P") Then
                count += 1
            End If
        Next
        Return count
    End Function
    Public Function countMonsterOnRightIsland()
        Dim count As Integer
        For Each e In rIsland
            If e.StartsWith("M") Then
                count += 1
            End If
        Next
        Return count
    End Function
    Public Function countPriestOnBoat()
        Dim count As Integer
        For Each e In boat
            If e.StartsWith("P") Then
                count += 1
            End If
        Next
        Return count
    End Function

    Public Function countMonsterOnBoat()
        Dim count As Integer
        For Each e In boat
            If e.StartsWith("M") Then
                count += 1
            End If
        Next
        Return count
    End Function

    Public Sub displaycount()
        txtBoatP.Text = "P: " & countPriestOnBoat()
        txtBoatM.Text = "M: " & countMonsterOnBoat()
        txtRislandP.Text = "P: " & countPriestOnRightIsland()
        txtRislandM.Text = "M: " & countMonsterOnRightIsland()
    End Sub

    Public Function checkBoatIfEmpty()
        If boat.Count = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Sub makevisible()
        For Each e In boat.ToList
            lIsland.Add(e)
            rIsland.Remove(e)
            Select Case e
                Case "P1"
                    LBH1.Visible = True
                    RBH1.Visible = False
                    If RBH1.Location = New Point(861, 621) Then
                        LBH1.Location = New Point(423, 621)
                    Else
                        RBH1.Location = New Point(861, 621)
                    End If
                    Exit Select
                Case "P2"
                    LBH2.Visible = True
                    RBH2.Visible = False
                    If RBH2.Location = New Point(861, 621) Then
                        LBH2.Location = New Point(423, 621)
                    Else
                        RBH2.Location = New Point(861, 621)
                    End If
                    Exit Select
                Case "P3"
                    LBH3.Visible = True
                    RBH3.Visible = False
                    If RBH3.Location = New Point(861, 621) Then
                        LBH3.Location = New Point(423, 621)
                    Else
                        RBH3.Location = New Point(861, 621)
                    End If
                    Exit Select
                Case "M1"
                    LBM1.Visible = True
                    RBM1.Visible = False
                    If RBM1.Location = New Point(861, 621) Then
                        LBM1.Location = New Point(423, 621)
                    Else
                        RBM1.Location = New Point(861, 621)
                    End If
                    Exit Select
                Case "M2"
                    LBM2.Visible = True
                    RBM2.Visible = False
                    If RBM2.Location = New Point(861, 621) Then
                        LBM2.Location = New Point(423, 621)
                    Else
                        RBM2.Location = New Point(861, 621)
                    End If
                    Exit Select
                Case "M3"
                    LBM3.Visible = True
                    RBM3.Visible = False
                    If RBM3.Location = New Point(861, 621) Then
                        LBM3.Location = New Point(423, 621)
                    End If
                    Exit Select
            End Select
        Next
    End Sub
    Public Sub resetPositionInRight()
        For Each ctrl As Control In oceanBg.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim a As PictureBox = DirectCast(ctrl, PictureBox)
                If a.Location = New Point(776, 621) Then
                    a.Location = New Point(861, 621)
                End If
            End If
        Next
    End Sub

    'right methods ends






    'left main process starts
    Private Sub LH1_Click(sender As Object, e As EventArgs) Handles LH1.Click, LH2.Click, LH3.Click, LM1.Click, LM2.Click, LM3.Click
        Dim btn As PictureBox = DirectCast(sender, PictureBox)
        If isRight Then
            If checkFull() Then
                MsgBox("The Boat is Full!", vbInformation, "Boat is Full!!")
                Exit Sub
            End If
            Select Case btn.Name
                Case "LH1"
                    moveElementInBoat("LBH1")
                    addToLeftBoat("P1")
                    btn.Visible = False
                Case "LH2"
                    moveElementInBoat("LBH2")
                    addToLeftBoat("P2")
                    btn.Visible = False
                Case "LH3"
                    moveElementInBoat("LBH3")
                    addToLeftBoat("P3")
                    btn.Visible = False
                Case "LM1"
                    moveElementInBoat("LBM1")
                    addToLeftBoat("M1")
                    btn.Visible = False
                Case "LM2"
                    moveElementInBoat("LBM2")
                    addToLeftBoat("M2")
                    btn.Visible = False
                Case "LM3"
                    moveElementInBoat("LBM3")
                    addToLeftBoat("M3")
                    btn.Visible = False
            End Select
        Else
            MsgBox("BOAT IS ON RIGHT")
        End If
    End Sub
    Private Sub leftBoat_Click(sender As Object, e As EventArgs) Handles LBH1.Click, LBH2.Click, LBH3.Click, LBM1.Click, LBM2.Click, LBM3.Click
        Dim btn As PictureBox = DirectCast(sender, PictureBox)
        Select Case btn.Name
            Case "LBH1"
                backToLeftIslandFromBoat("P1", "LH1")
                adjustPosition(btn.Name)
                btn.Visible = False
            Case "LBH2"
                backToLeftIslandFromBoat("P2", "LH2")
                adjustPosition(btn.Name)
                btn.Visible = False
            Case "LBH3"
                backToLeftIslandFromBoat("P3", "LH3")
                adjustPosition(btn.Name)
                btn.Visible = False
            Case "LBM1"
                backToLeftIslandFromBoat("M1", "LM1")
                adjustPosition(btn.Name)
                btn.Visible = False
            Case "LBM2"
                backToLeftIslandFromBoat("M2", "LM2")
                adjustPosition(btn.Name)
                btn.Visible = False
            Case "LBM3"
                backToLeftIslandFromBoat("M3", "LM3")
                adjustPosition(btn.Name)
                btn.Visible = False
        End Select
    End Sub


    Private Sub LboatImg_Click(sender As Object, e As EventArgs) Handles LboatImg.Click
        LboatImg.Visible = False
        RboatImg.Visible = True
        transferBoatFromLeftToRightCount()
        SyncFromLeftToRight()
        resetPositionInLeft()
        isRight = True
        displaycount()
    End Sub
    'left main process ends

    'left methods starts
    Public Sub SyncFromLeftToRight()
        If LBH1.Visible = True Then
            RBH1.Visible = True
            LBH1.Visible = False
        End If
        If LBH2.Visible = True Then
            RBH2.Visible = True
            LBH2.Visible = False
        End If
        If LBH3.Visible = True Then
            RBH3.Visible = True
            LBH3.Visible = False
        End If

        If LBM1.Visible = True Then
            RBM1.Visible = True
            LBM1.Visible = False
        End If
        If LBM2.Visible = True Then
            RBM2.Visible = True
            LBM2.Visible = False
        End If
        If LBM3.Visible = True Then
            RBM3.Visible = True
            LBM3.Visible = False
        End If
    End Sub

    Public Sub addToLeftBoat(asss As String)

    End Sub
    Public Sub resetPositionInLeft()
        For Each ctrl As Control In oceanBg.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim a As PictureBox = DirectCast(ctrl, PictureBox)
                If a.Location = New Point(423, 621) Then
                    a.Location = New Point(336, 621)
                End If
            End If
        Next
    End Sub

    Public Sub transferBoatFromLeftToRightCount()
        For Each e In boat.ToList
            rIsland.Add(e)
            lIsland.Remove(e)
        Next
    End Sub

    Public Sub backToLeftIslandFromBoat(LeftIslandElement As String, leftboat As String)
        For Each elem In lIsland
            If elem = LeftIslandElement Then
                boat.Remove(LeftIslandElement)
                Dim pbs As PictureBox = CType(oceanBg.Controls(leftboat), PictureBox)
                pbs.Visible = True
                displaycount()
                Exit Sub
            End If
        Next
        lIsland.Add(LeftIslandElement)
        boat.Remove(LeftIslandElement)
        displaycount()
        Dim pb As PictureBox = CType(oceanBg.Controls(leftboat), PictureBox)
        pb.Visible = True
    End Sub
    'left method ends
End Class