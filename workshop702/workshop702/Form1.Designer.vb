<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnnum = New System.Windows.Forms.Button()
        Me.btntext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(35, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(396, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(36, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnnum
        '
        Me.btnnum.Enabled = False
        Me.btnnum.Location = New System.Drawing.Point(35, 81)
        Me.btnnum.Name = "btnnum"
        Me.btnnum.Size = New System.Drawing.Size(187, 32)
        Me.btnnum.TabIndex = 2
        Me.btnnum.Text = "เปลี่ยนเป็นเลขไทย"
        Me.btnnum.UseVisualStyleBackColor = True
        '
        'btntext
        '
        Me.btntext.Enabled = False
        Me.btntext.Location = New System.Drawing.Point(244, 81)
        Me.btntext.Name = "btntext"
        Me.btntext.Size = New System.Drawing.Size(187, 32)
        Me.btntext.TabIndex = 3
        Me.btntext.Text = "เปลี่ยนเป็นข้อความไทย"
        Me.btntext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 195)
        Me.Controls.Add(Me.btntext)
        Me.Controls.Add(Me.btnnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnum As Button
    Friend WithEvents btntext As Button
End Class
