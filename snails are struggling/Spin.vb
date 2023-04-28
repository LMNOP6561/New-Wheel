Public Class frmSpin

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
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim thing1 As Integer
        thing1 = Int(Rnd() * 100 + 50)
        Dim pictureval As Integer

        For range = 0 To thing1
            pictureval = pictureval Mod 25
            snails(pictureval)
        Next
    End Sub
End Class