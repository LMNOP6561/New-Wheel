
Public Class frmSpin

    Dim y As Integer = 2
    Private Sub snails(x)
        Select Case x
            Case = 0
                picCircle.Image = My.Resources.Untitled_design__1_
            Case = 1
                picCircle.Image = My.Resources.Untitled_design__2_
            Case = 2
                picCircle.Image = My.Resources.Untitled_design__3_
            Case = 3
                picCircle.Image = My.Resources.Untitled_design__4_
        End Select

    End Sub
    Private Sub frmSpin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Interval = 500
        Dim z As Double
        z = y Mod 2
        Dim thing1 As Integer
        thing1 = Int((Rnd() * 101) + 50)
        Dim pictureval As Integer
        For i As Integer = 0 To thing1
            pictureval = i Mod 25
            snails(pictureval)
        Next



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        y += 1

    End Sub
End Class