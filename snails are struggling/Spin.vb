﻿
Public Class frmSpin

    Dim y As Integer = 19
    Dim z As Double


    Private Sub snails(x)
        If x = 0 Then
            picCircle.Image = My.Resources.Untitled_design
        ElseIf x = 1 Then
            picCircle.Image = My.Resources.Untitled_design__1_
        ElseIf x = 2 Then
            picCircle.Image = My.Resources.Untitled_design__2_
        ElseIf x = 3 Then
            picCircle.Image = My.Resources.Untitled_design__3_
        ElseIf x = 4 Then
            picCircle.Image = My.Resources.Untitled_design__4_
        ElseIf x = 5 Then
            picCircle.Image = My.Resources.Untitled_design__5_
        ElseIf x = 6 Then
            picCircle.Image = My.Resources.Untitled_design__6_
        ElseIf x = 7 Then
            picCircle.Image = My.Resources.Untitled_design__7_
        ElseIf x = 8 Then
            picCircle.Image = My.Resources.Untitled_design__8_
        ElseIf x = 9 Then
            picCircle.Image = My.Resources.Untitled_design__9_
        ElseIf x = 10 Then
            picCircle.Image = My.Resources.Untitled_design__10_
        ElseIf x = 11 Then
            picCircle.Image = My.Resources.Untitled_design__11_
        ElseIf x = 12 Then
            picCircle.Image = My.Resources.Untitled_design__12_
        ElseIf x = 13 Then
            picCircle.Image = My.Resources.Untitled_design__13_
        ElseIf x = 14 Then
            picCircle.Image = My.Resources.Untitled_design__14_
        ElseIf x = 15 Then
            picCircle.Image = My.Resources.Untitled_design__15_
        ElseIf x = 16 Then
            picCircle.Image = My.Resources.Untitled_design__16_
        ElseIf x = 17 Then
            picCircle.Image = My.Resources.Untitled_design__17_
        ElseIf x = 18 Then
            picCircle.Image = My.Resources.Untitled_design__18_
        ElseIf x = 19 Then
            picCircle.Image = My.Resources.Untitled_design__19_
        ElseIf x = 20 Then
            picCircle.Image = My.Resources.Untitled_design__20_
        End If

    End Sub
    Private Sub frmSpin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Interval = 100

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        y += 1
        Label1.Text = y.ToString
        z = y Mod 2
        Dim thing1 As Integer
        thing1 = Int(Rnd() * 101 + 50)
        Dim pictureval As Integer

        pictureval = y Mod 20
        snails(pictureval)
        Label2.Text = pictureval.ToString




        'If z = 0 Then
        '    For i As Integer = 0 To thing1
        '        pictureval = i Mod 25
        '        snails(pictureval)
        '        Label2.Text = pictureval.ToString
        '    Next i
        'End If

    End Sub
End Class