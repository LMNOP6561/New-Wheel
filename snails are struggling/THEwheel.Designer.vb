<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWheel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picCircle = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblYvalue = New System.Windows.Forms.Label()
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCircle
        '
        Me.picCircle.Image = Global.snails_are_struggling.My.Resources.Resources.Untitled_design__20_
        Me.picCircle.Location = New System.Drawing.Point(36, 12)
        Me.picCircle.Name = "picCircle"
        Me.picCircle.Size = New System.Drawing.Size(471, 404)
        Me.picCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCircle.TabIndex = 1
        Me.picCircle.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'lblYvalue
        '
        Me.lblYvalue.AutoSize = True
        Me.lblYvalue.Location = New System.Drawing.Point(12, 419)
        Me.lblYvalue.Name = "lblYvalue"
        Me.lblYvalue.Size = New System.Drawing.Size(35, 13)
        Me.lblYvalue.TabIndex = 2
        Me.lblYvalue.Text = "Snails"
        '
        'frmWheel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 457)
        Me.Controls.Add(Me.lblYvalue)
        Me.Controls.Add(Me.picCircle)
        Me.Name = "frmWheel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "THEwheel"
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCircle As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblYvalue As Label
End Class
