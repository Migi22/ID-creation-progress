<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_id_card
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.picBarCode = New System.Windows.Forms.PictureBox()
        Me.txtFname_mi = New System.Windows.Forms.TextBox()
        Me.txtCourse_Year = New System.Windows.Forms.TextBox()
        Me.txtStudent_num = New System.Windows.Forms.TextBox()
        Me.front_id = New System.Windows.Forms.Panel()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.lblCourseYearLevel = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtBirthdate = New System.Windows.Forms.TextBox()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.lblSignature = New System.Windows.Forms.Label()
        Me.lblEmergency = New System.Windows.Forms.Label()
        Me.txtGuardianName = New System.Windows.Forms.TextBox()
        Me.txtGuardianNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.back_id = New System.Windows.Forms.Panel()
        Me.lblIDcard = New System.Windows.Forms.Label()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.front_id.SuspendLayout()
        Me.back_id.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrchid
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 1045)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 5)
        Me.Panel1.TabIndex = 1
        '
        'PrintDocument1
        '
        '
        'picProfile
        '
        Me.picProfile.Location = New System.Drawing.Point(133, 47)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(157, 145)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 2
        Me.picProfile.TabStop = False
        '
        'picBarCode
        '
        Me.picBarCode.Location = New System.Drawing.Point(24, 480)
        Me.picBarCode.Name = "picBarCode"
        Me.picBarCode.Size = New System.Drawing.Size(397, 96)
        Me.picBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBarCode.TabIndex = 3
        Me.picBarCode.TabStop = False
        '
        'txtFname_mi
        '
        Me.txtFname_mi.BackColor = System.Drawing.SystemColors.Control
        Me.txtFname_mi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFname_mi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname_mi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFname_mi.Location = New System.Drawing.Point(91, 225)
        Me.txtFname_mi.Name = "txtFname_mi"
        Me.txtFname_mi.ReadOnly = True
        Me.txtFname_mi.Size = New System.Drawing.Size(252, 23)
        Me.txtFname_mi.TabIndex = 5
        Me.txtFname_mi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCourse_Year
        '
        Me.txtCourse_Year.BackColor = System.Drawing.SystemColors.Control
        Me.txtCourse_Year.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCourse_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCourse_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCourse_Year.Location = New System.Drawing.Point(91, 355)
        Me.txtCourse_Year.Name = "txtCourse_Year"
        Me.txtCourse_Year.ReadOnly = True
        Me.txtCourse_Year.Size = New System.Drawing.Size(252, 23)
        Me.txtCourse_Year.TabIndex = 5
        Me.txtCourse_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStudent_num
        '
        Me.txtStudent_num.BackColor = System.Drawing.SystemColors.Control
        Me.txtStudent_num.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudent_num.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudent_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtStudent_num.Location = New System.Drawing.Point(91, 417)
        Me.txtStudent_num.Name = "txtStudent_num"
        Me.txtStudent_num.ReadOnly = True
        Me.txtStudent_num.Size = New System.Drawing.Size(252, 23)
        Me.txtStudent_num.TabIndex = 5
        Me.txtStudent_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'front_id
        '
        Me.front_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.front_id.Controls.Add(Me.lblStudentNumber)
        Me.front_id.Controls.Add(Me.lblCourseYearLevel)
        Me.front_id.Controls.Add(Me.txtStudent_num)
        Me.front_id.Controls.Add(Me.txtCourse_Year)
        Me.front_id.Controls.Add(Me.txtLname)
        Me.front_id.Controls.Add(Me.txtFname_mi)
        Me.front_id.Controls.Add(Me.picBarCode)
        Me.front_id.Controls.Add(Me.picProfile)
        Me.front_id.Location = New System.Drawing.Point(54, 111)
        Me.front_id.Name = "front_id"
        Me.front_id.Size = New System.Drawing.Size(452, 646)
        Me.front_id.TabIndex = 6
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNumber.Location = New System.Drawing.Point(129, 394)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(172, 20)
        Me.lblStudentNumber.TabIndex = 6
        Me.lblStudentNumber.Text = "STUDENT NUMBER"
        '
        'lblCourseYearLevel
        '
        Me.lblCourseYearLevel.AutoSize = True
        Me.lblCourseYearLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseYearLevel.Location = New System.Drawing.Point(113, 332)
        Me.lblCourseYearLevel.Name = "lblCourseYearLevel"
        Me.lblCourseYearLevel.Size = New System.Drawing.Size(216, 20)
        Me.lblCourseYearLevel.TabIndex = 6
        Me.lblCourseYearLevel.Text = "COURSE && YEAR LEVEL"
        '
        'txtLname
        '
        Me.txtLname.BackColor = System.Drawing.SystemColors.Control
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(91, 278)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.ReadOnly = True
        Me.txtLname.Size = New System.Drawing.Size(252, 28)
        Me.txtLname.TabIndex = 5
        Me.txtLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBirthdate
        '
        Me.txtBirthdate.BackColor = System.Drawing.SystemColors.Control
        Me.txtBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBirthdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBirthdate.Location = New System.Drawing.Point(141, 24)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.ReadOnly = True
        Me.txtBirthdate.Size = New System.Drawing.Size(252, 23)
        Me.txtBirthdate.TabIndex = 5
        Me.txtBirthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdate.Location = New System.Drawing.Point(20, 28)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(115, 20)
        Me.lblBirthdate.TabIndex = 6
        Me.lblBirthdate.Text = "BIRTHDATE:"
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(125, 172)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(200, 20)
        Me.lblSignature.TabIndex = 6
        Me.lblSignature.Text = "STUDENT SIGNATURE"
        '
        'lblEmergency
        '
        Me.lblEmergency.AutoSize = True
        Me.lblEmergency.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergency.Location = New System.Drawing.Point(57, 216)
        Me.lblEmergency.Name = "lblEmergency"
        Me.lblEmergency.Size = New System.Drawing.Size(323, 20)
        Me.lblEmergency.TabIndex = 6
        Me.lblEmergency.Text = "IN CASE OF EMERGENCY, CONTACT:"
        '
        'txtGuardianName
        '
        Me.txtGuardianName.BackColor = System.Drawing.SystemColors.Control
        Me.txtGuardianName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuardianName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtGuardianName.Location = New System.Drawing.Point(37, 252)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.ReadOnly = True
        Me.txtGuardianName.Size = New System.Drawing.Size(382, 23)
        Me.txtGuardianName.TabIndex = 5
        Me.txtGuardianName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGuardianNumber
        '
        Me.txtGuardianNumber.BackColor = System.Drawing.SystemColors.Control
        Me.txtGuardianNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuardianNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuardianNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtGuardianNumber.Location = New System.Drawing.Point(100, 305)
        Me.txtGuardianNumber.Name = "txtGuardianNumber"
        Me.txtGuardianNumber.ReadOnly = True
        Me.txtGuardianNumber.Size = New System.Drawing.Size(252, 23)
        Me.txtGuardianNumber.TabIndex = 5
        Me.txtGuardianNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Control
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtAddress.Location = New System.Drawing.Point(37, 370)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(382, 95)
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAddress.WordWrap = False
        '
        'back_id
        '
        Me.back_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.back_id.Controls.Add(Me.lblEmergency)
        Me.back_id.Controls.Add(Me.lblSignature)
        Me.back_id.Controls.Add(Me.lblBirthdate)
        Me.back_id.Controls.Add(Me.txtAddress)
        Me.back_id.Controls.Add(Me.txtGuardianNumber)
        Me.back_id.Controls.Add(Me.txtGuardianName)
        Me.back_id.Controls.Add(Me.txtBirthdate)
        Me.back_id.Location = New System.Drawing.Point(549, 111)
        Me.back_id.Name = "back_id"
        Me.back_id.Size = New System.Drawing.Size(499, 646)
        Me.back_id.TabIndex = 7
        '
        'lblIDcard
        '
        Me.lblIDcard.BackColor = System.Drawing.Color.DarkOrchid
        Me.lblIDcard.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblIDcard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblIDcard.ForeColor = System.Drawing.Color.White
        Me.lblIDcard.Location = New System.Drawing.Point(0, 0)
        Me.lblIDcard.Name = "lblIDcard"
        Me.lblIDcard.Size = New System.Drawing.Size(1100, 36)
        Me.lblIDcard.TabIndex = 0
        Me.lblIDcard.Text = "Identification Card"
        Me.lblIDcard.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form_id_card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 1050)
        Me.Controls.Add(Me.back_id)
        Me.Controls.Add(Me.front_id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblIDcard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form_id_card"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_id_card"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.front_id.ResumeLayout(False)
        Me.front_id.PerformLayout()
        Me.back_id.ResumeLayout(False)
        Me.back_id.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents picBarCode As PictureBox
    Friend WithEvents txtFname_mi As TextBox
    Friend WithEvents txtCourse_Year As TextBox
    Friend WithEvents txtStudent_num As TextBox
    Friend WithEvents front_id As Panel
    Friend WithEvents txtLname As TextBox
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents lblCourseYearLevel As Label
    Friend WithEvents txtBirthdate As TextBox
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents lblSignature As Label
    Friend WithEvents lblEmergency As Label
    Friend WithEvents txtGuardianName As TextBox
    Friend WithEvents txtGuardianNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents back_id As Panel
    Friend WithEvents lblIDcard As Label
End Class
