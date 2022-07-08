<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pdfResumeCreatorVB
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
        Me.btnGeneratePDF = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.picBoxGif = New System.Windows.Forms.PictureBox()
        CType(Me.picBoxGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGeneratePDF
        '
        Me.btnGeneratePDF.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneratePDF.Location = New System.Drawing.Point(12, 63)
        Me.btnGeneratePDF.Name = "btnGeneratePDF"
        Me.btnGeneratePDF.Size = New System.Drawing.Size(252, 73)
        Me.btnGeneratePDF.TabIndex = 0
        Me.btnGeneratePDF.Text = "Generate PDF"
        Me.btnGeneratePDF.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PDF Resume Creator"
        '
        'exitBtn
        '
        Me.exitBtn.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(12, 154)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(252, 72)
        Me.exitBtn.TabIndex = 2
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'picBoxGif
        '
        Me.picBoxGif.BackColor = System.Drawing.Color.Transparent
        Me.picBoxGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBoxGif.Image = Global.PDF_Resume_VB.My.Resources.Resources.takodachigif
        Me.picBoxGif.Location = New System.Drawing.Point(270, 63)
        Me.picBoxGif.Name = "picBoxGif"
        Me.picBoxGif.Size = New System.Drawing.Size(166, 163)
        Me.picBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxGif.TabIndex = 3
        Me.picBoxGif.TabStop = False
        '
        'pdfResumeCreatorVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PDF_Resume_VB.My.Resources.Resources.background_pdf
        Me.ClientSize = New System.Drawing.Size(448, 258)
        Me.Controls.Add(Me.picBoxGif)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGeneratePDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pdfResumeCreatorVB"
        Me.Text = "PDF Resume Creator VB"
        CType(Me.picBoxGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents exitBtn As Button
    Friend WithEvents picBoxGif As PictureBox
End Class
