
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Windows.Forms.ComponentModel.Com2Interop

Public Class frmMain
    Dim Clue As String
    Dim help As Button
    Dim Hidden As String = ""
    Dim lstindex As Integer
    Dim worms As System.IO.StreamReader
    Dim fileEdit As System.IO.StreamWriter
    Dim globalfilepath As String
    Dim score As Integer
    Dim stuff As String
    Dim thing1 As New Random
    Public Sub reset()
        For Each button As Button In gboLetters.Controls.OfType(Of Button)
            If TypeOf button Is Button Then
                button.Enabled = True
            End If
        Next button

        btnNew.Enabled = False
        gboLetters.Enabled = False
        MsgBox("Spin the wheel!")
        btnSpin.Enabled = True

        lblScore1.Text = "$0.00"
        lblScore2.Text = "$0.00"
        lblTotal1.Text = "$0.00"
        lblTotal2.Text = "$0.00"

    End Sub
    Public Sub Spin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        frmWheel.Show()
        Me.Hide()


        gboLetters.Enabled = True
        btnSpin.Enabled = False
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        btnNew.Enabled = False
        For Each button As Button In gboLetters.Controls.OfType(Of Button)
            If TypeOf button Is Button Then
                AddHandler button.Click, AddressOf button_click
            End If
        Next button

    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        lstClues.Items.Clear()
        Dim snails As New OpenFileDialog()
        snails.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"
        snails.CheckFileExists = True
        snails.Title = "OpenFile"
        Dim strLineNames As String

        If snails.ShowDialog() = DialogResult.OK Then
            globalfilepath = snails.FileName
        End If


        Try
            worms = System.IO.File.OpenText(snails.FileName)
            Do Until worms.Peek = -1
                strLineNames = worms.ReadLine
                lstClues.Items.Add(strLineNames)
            Loop
            worms.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        lstindex = (lstClues.Items.Count)
        Dim phrasevalue As Integer = thing1.Next(lstindex)
        lstClues.SelectedIndex = phrasevalue
        Label1.Text = phrasevalue
        btnNew.Enabled = True
        btnSpin.Enabled = False
        gboLetters.Enabled = False
        MsgBox("Player 1 Starts! Click New Phrase to begin")
    End Sub

    Public Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        reset()

        lblState.Text = ""
        Hidden = ""
        lstindex = (lstClues.Items.Count)

        lstClues.SelectedIndex = thing1.Next(lstindex)

        Dim counter As Integer

        Label2.Text = lstClues.SelectedItem
        Clue = lstClues.SelectedItem.toupper


        While counter < Clue.Length
            For x As Integer = 0 To Len(Clue) - 1
                If Clue(x) = " " Then
                    Hidden += " "
                ElseIf Clue(x) Like "[A-Z]" Then
                    Hidden += "-"
                End If
                counter += 1
            Next

        End While

        lblState.Text = Hidden





    End Sub





    Public Sub button_click(sender As Object, e As EventArgs)
        btnNew.Enabled = False
        btnGive.Visible = True
        Clue = lstClues.SelectedItem.toupper
        Dim hiddenstring As String
        hiddenstring = lblState.Text
        Dim vari As Integer = 0
        sender.enabled = False

        If Clue.Contains(sender.text) Then
            For intindex As Integer = 0 To Clue.Length - 1
                If Clue(intindex) = sender.text Then
                    vari += 1
                    hiddenstring = hiddenstring.Remove(intindex, 1)
                    hiddenstring = hiddenstring.Insert(intindex, sender.text)
                End If
            Next

            btnSpin.Enabled = True
            btnSolve.Visible = True
            'MsgBox("Spin again!")
            gboLetters.Enabled = False
        ElseIf Clue.Contains(sender.text) = False Then
            If gboPlayer1.Enabled = True Then
                lblScore1.Text = "$0.00"
                btnGive.Location = New Point(144, 276)
                gboPlayer1.Enabled = False
                gboPlayer2.Enabled = True
                btnSpin.Enabled = True
            Else
                lblScore2.Text = "$0.00"
                btnGive.Location = New Point(87, 29)
                gboPlayer2.Enabled = False
                gboPlayer1.Enabled = True
                btnSpin.Enabled = True
            End If
            MsgBox("Next players turn! Spin the wheel!")
            gboLetters.Enabled = False
        End If
        lblState.Text = hiddenstring


        Dim score2 As Integer = Int(lblScore1.Text.Trim("$"))
        Dim score3 As Integer = Int(lblScore2.Text.Trim("$"))

        If gboPlayer1.Enabled = True Then
            score += score2 * vari
            lblTotal1.Text = (Int(lblTotal1.Text.Trim("$") + score).ToString("C2"))

        ElseIf gboPlayer2.Enabled = True Then
            score += score3 * vari
            lblTotal2.Text = (Int(lblTotal2.Text.Trim("$") + score).ToString("C2"))

        End If
        score = 0



    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        Clue = lstClues.SelectedItem.toupper
        Dim solve As String

        solve = InputBox("Solve the Phrase: ", "Wheel of Fortune")



        If solve.ToUpper = Clue.ToUpper Then
            lblState.Text = Clue.ToUpper
            If gboPlayer1.Enabled = True Then
                lblTotal1.Text = (Int(lblTotal1.Text.Trim("$") + 3000).ToString("C2"))
                MsgBox("Player 1 Wins!")
            ElseIf gboPlayer2.Enabled = True Then
                lblTotal2.Text = (Int(lblTotal2.Text.Trim("$") + 3000).ToString("C2"))
                MsgBox("Player 2 Wins!")
            End If
        End If

    End Sub

    Private Sub lblState_TextChanged(sender As Object, e As EventArgs) Handles lblState.TextChanged
        If lblState.Text.Contains("-") = False Then
            btnNew.Enabled = True
            btnSolve.Visible = False
        End If
    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub gboPlayer_EnabledChanged(sender As Object, e As EventArgs) Handles gboPlayer2.EnabledChanged, gboPlayer1.EnabledChanged
        btnSpin.Enabled = True

        frmWheel.Timer2.Enabled = False
        gboLetters.Enabled = False
    End Sub

    Private Sub btnGive_Click(sender As Object, e As EventArgs) Handles btnGive.Click
        MsgBox(Clue)
        reset()

    End Sub
End Class