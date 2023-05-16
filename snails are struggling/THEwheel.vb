Imports System.ComponentModel
Imports System.IO
Imports System.Reflection.Emit
Imports System.Threading

Public Class frmWheel
    Public y As Integer
    Dim z As Double
    Dim thing2 As New Random
    Dim thing1 As Integer
    Dim snail As Boolean = False
    Dim pictureval As Integer
    Public scoreval As Integer


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

        If snail = True Then
            If x = 0 Then
                picCircle.Image = My.Resources.Win1
                scoreval = 5000
            ElseIf x = 1 Then
                picCircle.Image = My.Resources.Win2
                scoreval = 0
            ElseIf x = 2 Then
                picCircle.Image = My.Resources.Win3
                scoreval = 1000
            ElseIf x = 3 Then
                picCircle.Image = My.Resources.Win4
                scoreval = 1
            ElseIf x = 4 Then
                picCircle.Image = My.Resources.Win5
                scoreval = 5000
            ElseIf x = 5 Then
                picCircle.Image = My.Resources.Win6
                scoreval = 0
            ElseIf x = 6 Then
                picCircle.Image = My.Resources.Win7
                scoreval = 1000
            ElseIf x = 7 Then
                picCircle.Image = My.Resources.Win8
                scoreval = 1000
            ElseIf x = 8 Then
                picCircle.Image = My.Resources.Win9
                scoreval = 2000
            ElseIf x = 9 Then
                picCircle.Image = My.Resources.Win10
                scoreval = 10000
            ElseIf x = 10 Then
                picCircle.Image = My.Resources.Win11
                scoreval = 1
            ElseIf x = 11 Then
                picCircle.Image = My.Resources.Win12
                scoreval = 0
            ElseIf x = 12 Then
                picCircle.Image = My.Resources.Win13
                scoreval = 5000
            ElseIf x = 13 Then
                picCircle.Image = My.Resources.Win14
                scoreval = 1000
            ElseIf x = 14 Then
                picCircle.Image = My.Resources.Win15
                scoreval = 2000
            ElseIf x = 15 Then
                picCircle.Image = My.Resources.Win16
                scoreval = 1
            ElseIf x = 16 Then
                picCircle.Image = My.Resources.Win17
                scoreval = 1000
            ElseIf x = 17 Then
                picCircle.Image = My.Resources.Win18
                scoreval = 2000
            ElseIf x = 18 Then
                picCircle.Image = My.Resources.Win19
                scoreval = 1000
            ElseIf x = 19 Then
                picCircle.Image = My.Resources.Win20
                scoreval = 0



            End If
        End If
    End Sub

    Private Sub THEwheel_Load(sender As Object, e As EventArgs) Handles Me.Load

        Timer1.Enabled = True
        Timer1.Interval = 50
        snail = False
        thing1 = thing2.Next(19)


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        y += 1
        pictureval = y Mod 20
        lblYvalue.Text = y
        snails(pictureval)

        If y > 40 Then
            If pictureval = thing1 Then
                snail = True
                snails(thing1)
                Timer1.Enabled = False

                Timer2.Enabled = True
            End If
        End If


        z = y Mod 2

        If y = 30 Then
            Timer1.Interval = 100
        ElseIf y = 40 Then
            Timer1.Interval = 150
        ElseIf y >= 60 Then
            Timer1.Interval = 175
        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Dim file As System.IO.StreamWriter
        'file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\ehamilto6561\Documents\VB data files\Chpt 5 DF\VB2017\Chap05\snails are struggling\snails are struggling\Resources\NewScore1.txt", False)

        frmMain.Show()
        If frmMain.gboPlayer1.Enabled = True Then

            If scoreval = 1 Then
                frmMain.gboPlayer1.Enabled = False
                frmMain.gboPlayer2.Enabled = True
                MessageBox.Show("Next players turn!", "Wheel of fortune",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.btnSpin.Enabled = True

            ElseIf scoreval = "0" Then
                frmMain.lblScore1.Text = 0.ToString("C2")
                frmMain.lblTotal1.Text = 0.ToString("C2")
                frmMain.gboPlayer2.Enabled = True
                frmMain.gboPlayer1.Enabled = False
                MessageBox.Show("Next players turn!", "Wheel of fortune",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.btnSpin.Enabled = True

            Else
                frmMain.lblScore1.Text = scoreval.ToString("C2")

            End If


        ElseIf frmMain.gboPlayer2.Enabled = True Then
            If scoreval = 1 Then
                frmMain.gboPlayer2.Enabled = False
                frmMain.gboPlayer1.Enabled = True
                MessageBox.Show("Next players turn!", "Wheel of fortune",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.btnSpin.Enabled = True

            ElseIf scoreval = "0" Then
                frmMain.lblScore2.Text = 0.ToString("C2")
                frmMain.lblTotal2.Text = 0.ToString("C2")
                frmMain.gboPlayer2.Enabled = False
                frmMain.gboPlayer1.Enabled = True
                MessageBox.Show("Next", "Wheel of fortune",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.btnSpin.Enabled = True

            Else
                frmMain.lblScore2.Text = scoreval.ToString("C2")
            End If
        End If
        Timer2.Interval = 20000


        Me.Close()
    End Sub

    Private Sub frmWheel_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Timer2.Enabled = False

    End Sub
End Class