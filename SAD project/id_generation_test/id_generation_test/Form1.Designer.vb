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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtSelectQueue_ID = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.OPDPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.picImportStudent = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQueue_ID = New System.Windows.Forms.TextBox()
        Me.txtMi = New System.Windows.Forms.TextBox()
        Me.lblMi = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtYearlevel = New System.Windows.Forms.TextBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.txtGuardianName = New System.Windows.Forms.TextBox()
        Me.lblGuardian = New System.Windows.Forms.Label()
        Me.txtGuardianContactNumber = New System.Windows.Forms.TextBox()
        Me.lblGuardianContactNumber = New System.Windows.Forms.Label()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnGenerateIDCard = New System.Windows.Forms.Button()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImportStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(565, 735)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(129, 58)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(390, 246)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersWidth = 62
        Me.dgvUsers.RowTemplate.Height = 100
        Me.dgvUsers.Size = New System.Drawing.Size(954, 434)
        Me.dgvUsers.TabIndex = 1
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(168, 74)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.ReadOnly = True
        Me.txtFname.Size = New System.Drawing.Size(173, 26)
        Me.txtFname.TabIndex = 2
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(66, 80)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(86, 20)
        Me.lblFname.TabIndex = 3
        Me.lblFname.Text = "First Name"
        '
        'txtSelectQueue_ID
        '
        Me.txtSelectQueue_ID.Location = New System.Drawing.Point(390, 703)
        Me.txtSelectQueue_ID.Name = "txtSelectQueue_ID"
        Me.txtSelectQueue_ID.Size = New System.Drawing.Size(129, 26)
        Me.txtSelectQueue_ID.TabIndex = 4
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(390, 735)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(129, 58)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(168, 121)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.ReadOnly = True
        Me.txtLname.Size = New System.Drawing.Size(173, 26)
        Me.txtLname.TabIndex = 2
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(66, 124)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(86, 20)
        Me.lblLname.TabIndex = 3
        Me.lblLname.Text = "Last Name"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(31, 571)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(129, 58)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(212, 571)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 58)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'picStudent
        '
        Me.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudent.Location = New System.Drawing.Point(390, 12)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(191, 177)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 6
        Me.picStudent.TabStop = False
        '
        'txtPhoto
        '
        Me.txtPhoto.Location = New System.Drawing.Point(1010, 24)
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.ReadOnly = True
        Me.txtPhoto.Size = New System.Drawing.Size(334, 26)
        Me.txtPhoto.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(1191, 56)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(153, 63)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSaveImage
        '
        Me.btnSaveImage.Location = New System.Drawing.Point(1191, 125)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(153, 63)
        Me.btnSaveImage.TabIndex = 7
        Me.btnSaveImage.Text = "SAVE IMAGE"
        Me.btnSaveImage.UseVisualStyleBackColor = True
        '
        'OPDPhoto
        '
        Me.OPDPhoto.FileName = "OPDPhoto"
        '
        'picImportStudent
        '
        Me.picImportStudent.Location = New System.Drawing.Point(1010, 56)
        Me.picImportStudent.Name = "picImportStudent"
        Me.picImportStudent.Size = New System.Drawing.Size(175, 132)
        Me.picImportStudent.TabIndex = 8
        Me.picImportStudent.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Queue_ID"
        '
        'txtQueue_ID
        '
        Me.txtQueue_ID.Location = New System.Drawing.Point(168, 32)
        Me.txtQueue_ID.Name = "txtQueue_ID"
        Me.txtQueue_ID.ReadOnly = True
        Me.txtQueue_ID.Size = New System.Drawing.Size(173, 26)
        Me.txtQueue_ID.TabIndex = 2
        '
        'txtMi
        '
        Me.txtMi.Location = New System.Drawing.Point(168, 163)
        Me.txtMi.Name = "txtMi"
        Me.txtMi.ReadOnly = True
        Me.txtMi.Size = New System.Drawing.Size(173, 26)
        Me.txtMi.TabIndex = 2
        '
        'lblMi
        '
        Me.lblMi.AutoSize = True
        Me.lblMi.Location = New System.Drawing.Point(115, 169)
        Me.lblMi.Name = "lblMi"
        Me.lblMi.Size = New System.Drawing.Size(35, 20)
        Me.lblMi.TabIndex = 3
        Me.lblMi.Text = "M.I."
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(168, 205)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(173, 26)
        Me.txtCourse.TabIndex = 2
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(90, 211)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(60, 20)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "Course"
        '
        'txtYearlevel
        '
        Me.txtYearlevel.Location = New System.Drawing.Point(168, 246)
        Me.txtYearlevel.Name = "txtYearlevel"
        Me.txtYearlevel.ReadOnly = True
        Me.txtYearlevel.Size = New System.Drawing.Size(173, 26)
        Me.txtYearlevel.TabIndex = 2
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Location = New System.Drawing.Point(66, 249)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(84, 20)
        Me.lblYearLevel.TabIndex = 3
        Me.lblYearLevel.Text = "Year Level"
        '
        'txtGuardianName
        '
        Me.txtGuardianName.Location = New System.Drawing.Point(168, 338)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.ReadOnly = True
        Me.txtGuardianName.Size = New System.Drawing.Size(173, 26)
        Me.txtGuardianName.TabIndex = 2
        '
        'lblGuardian
        '
        Me.lblGuardian.AutoSize = True
        Me.lblGuardian.Location = New System.Drawing.Point(18, 344)
        Me.lblGuardian.Name = "lblGuardian"
        Me.lblGuardian.Size = New System.Drawing.Size(132, 20)
        Me.lblGuardian.TabIndex = 3
        Me.lblGuardian.Text = "Guardian's Name"
        '
        'txtGuardianContactNumber
        '
        Me.txtGuardianContactNumber.Location = New System.Drawing.Point(168, 396)
        Me.txtGuardianContactNumber.Name = "txtGuardianContactNumber"
        Me.txtGuardianContactNumber.ReadOnly = True
        Me.txtGuardianContactNumber.Size = New System.Drawing.Size(173, 26)
        Me.txtGuardianContactNumber.TabIndex = 2
        '
        'lblGuardianContactNumber
        '
        Me.lblGuardianContactNumber.AutoSize = True
        Me.lblGuardianContactNumber.Location = New System.Drawing.Point(27, 382)
        Me.lblGuardianContactNumber.Name = "lblGuardianContactNumber"
        Me.lblGuardianContactNumber.Size = New System.Drawing.Size(125, 40)
        Me.lblGuardianContactNumber.TabIndex = 3
        Me.lblGuardianContactNumber.Text = "Guardian's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact Number"
        Me.lblGuardianContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(168, 295)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.ReadOnly = True
        Me.txtBirthday.Size = New System.Drawing.Size(173, 26)
        Me.txtBirthday.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Birthday"
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Location = New System.Drawing.Point(168, 486)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.ReadOnly = True
        Me.txtStudentNumber.Size = New System.Drawing.Size(173, 26)
        Me.txtStudentNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 492)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(168, 438)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(173, 26)
        Me.txtAddress.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(82, 444)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(68, 20)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGenerateIDCard
        '
        Me.btnGenerateIDCard.Location = New System.Drawing.Point(735, 735)
        Me.btnGenerateIDCard.Name = "btnGenerateIDCard"
        Me.btnGenerateIDCard.Size = New System.Drawing.Size(123, 58)
        Me.btnGenerateIDCard.TabIndex = 9
        Me.btnGenerateIDCard.Text = "Generate ID Card"
        Me.btnGenerateIDCard.UseVisualStyleBackColor = True
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Location = New System.Drawing.Point(390, 214)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(954, 26)
        Me.txtSearchBox.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1356, 957)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Controls.Add(Me.btnGenerateIDCard)
        Me.Controls.Add(Me.picImportStudent)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picStudent)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtSelectQueue_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblGuardianContactNumber)
        Me.Controls.Add(Me.lblGuardian)
        Me.Controls.Add(Me.lblYearLevel)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblMi)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.txtPhoto)
        Me.Controls.Add(Me.txtStudentNumber)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtGuardianContactNumber)
        Me.Controls.Add(Me.txtGuardianName)
        Me.Controls.Add(Me.txtYearlevel)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtMi)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtQueue_ID)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.btnRefresh)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImportStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents txtSelectQueue_ID As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents picStudent As System.Windows.Forms.PictureBox
    Friend WithEvents txtPhoto As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnSaveImage As System.Windows.Forms.Button
    Friend WithEvents OPDPhoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents picImportStudent As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQueue_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtMi As System.Windows.Forms.TextBox
    Friend WithEvents lblMi As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents txtYearlevel As System.Windows.Forms.TextBox
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents txtGuardianName As System.Windows.Forms.TextBox
    Friend WithEvents lblGuardian As System.Windows.Forms.Label
    Friend WithEvents txtGuardianContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblGuardianContactNumber As System.Windows.Forms.Label
    Friend WithEvents txtBirthday As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents btnGenerateIDCard As System.Windows.Forms.Button
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox

End Class
