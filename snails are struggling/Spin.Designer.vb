<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpin
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
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCircle
        '
        Me.picCircle.Image = Global.snails_are_struggling.My.Resources.Resources.Untitled_design__20_
        Me.picCircle.Location = New System.Drawing.Point(114, 37)
        Me.picCircle.Name = "picCircle"
        Me.picCircle.Size = New System.Drawing.Size(464, 365)
        Me.picCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCircle.TabIndex = 0
        Me.picCircle.TabStop = False
        '
        'frmSpin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 467)
        Me.Controls.Add(Me.picCircle)
        Me.Name = "frmSpin"
        Me.Text = "Spin"
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCircle As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
