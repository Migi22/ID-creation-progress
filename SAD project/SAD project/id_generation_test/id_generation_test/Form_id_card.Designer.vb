<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_id_card
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
        Me.lblIDcard = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.picBarCode = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCourse_Year = New System.Windows.Forms.Label()
        Me.lblStudent_num = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtCourse_Year = New System.Windows.Forms.TextBox()
        Me.txtStudent_num = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIDcard
        '
        Me.lblIDcard.BackColor = System.Drawing.Color.DarkOrchid
        Me.lblIDcard.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblIDcard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblIDcard.ForeColor = System.Drawing.Color.White
        Me.lblIDcard.Location = New System.Drawing.Point(0, 0)
        Me.lblIDcard.Name = "lblIDcard"
        Me.lblIDcard.Size = New System.Drawing.Size(949, 36)
        Me.lblIDcard.TabIndex = 0
        Me.lblIDcard.Text = "Identification Card"
        Me.lblIDcard.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrchid
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 546)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 5)
        Me.Panel1.TabIndex = 1
        '
        'picProfile
        '
        Me.picProfile.Location = New System.Drawing.Point(47, 75)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(157, 145)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 2
        Me.picProfile.TabStop = False
        '
        'picBarCode
        '
        Me.picBarCode.Location = New System.Drawing.Point(6, 443)
        Me.picBarCode.Name = "picBarCode"
        Me.picBarCode.Size = New System.Drawing.Size(931, 96)
        Me.picBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBarCode.TabIndex = 3
        Me.picBarCode.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(230, 75)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblCourse_Year
        '
        Me.lblCourse_Year.AutoSize = True
        Me.lblCourse_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse_Year.Location = New System.Drawing.Point(230, 125)
        Me.lblCourse_Year.Name = "lblCourse_Year"
        Me.lblCourse_Year.Size = New System.Drawing.Size(233, 25)
        Me.lblCourse_Year.TabIndex = 4
        Me.lblCourse_Year.Text = "Course and Year Level"
        '
        'lblStudent_num
        '
        Me.lblStudent_num.AutoSize = True
        Me.lblStudent_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent_num.Location = New System.Drawing.Point(230, 177)
        Me.lblStudent_num.Name = "lblStudent_num"
        Me.lblStudent_num.Size = New System.Drawing.Size(168, 25)
        Me.lblStudent_num.TabIndex = 4
        Me.lblStudent_num.Text = "Student Number"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.SystemColors.Control
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFullName.Location = New System.Drawing.Point(479, 75)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(289, 23)
        Me.txtFullName.TabIndex = 5
        '
        'txtCourse_Year
        '
        Me.txtCourse_Year.BackColor = System.Drawing.SystemColors.Control
        Me.txtCourse_Year.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCourse_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCourse_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCourse_Year.Location = New System.Drawing.Point(479, 125)
        Me.txtCourse_Year.Name = "txtCourse_Year"
        Me.txtCourse_Year.Size = New System.Drawing.Size(289, 23)
        Me.txtCourse_Year.TabIndex = 5
        '
        'txtStudent_num
        '
        Me.txtStudent_num.BackColor = System.Drawing.SystemColors.Control
        Me.txtStudent_num.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudent_num.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudent_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtStudent_num.Location = New System.Drawing.Point(479, 177)
        Me.txtStudent_num.Name = "txtStudent_num"
        Me.txtStudent_num.Size = New System.Drawing.Size(289, 23)
        Me.txtStudent_num.TabIndex = 5
        '
        'PrintDocument1
        '
        '
        'Form_id_card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 551)
        Me.Controls.Add(Me.txtStudent_num)
        Me.Controls.Add(Me.txtCourse_Year)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblStudent_num)
        Me.Controls.Add(Me.lblCourse_Year)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picBarCode)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblIDcard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form_id_card"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_id_card"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDcard As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents picBarCode As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCourse_Year As System.Windows.Forms.Label
    Friend WithEvents lblStudent_num As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse_Year As System.Windows.Forms.TextBox
    Friend WithEvents txtStudent_num As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
