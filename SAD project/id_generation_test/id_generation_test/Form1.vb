Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form1
    Private queueIdToEdit As Integer = -1 ' Variable to store the user ID being edited

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Load all data into DataGridView
        LoadDataIntoDataGridView()
    End Sub

    'DATAGRIDVIEW

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        ' Handle the selection change in the DataGridView
        If dgvUsers.SelectedRows.Count > 0 Then
            ' Get the selected user's ID
            Dim queue_ID As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("queue_ID").Value)

            ' Load user data based on the selected ID
            LoadUserDataById(queue_ID)
        End If
    End Sub

    'Click feature for data grid

    Private Sub dgvUsers_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsers.CellMouseClick
        Try
            With dgvUsers
                txtQueue_ID.Text = .CurrentRow.Cells("queue_ID").Value.ToString
                txtFname.Text = .CurrentRow.Cells("fname").Value.ToString
                txtLname.Text = .CurrentRow.Cells("lname").Value.ToString
                txtMi.Text = .CurrentRow.Cells("m_i").Value.ToString
                txtCourse.Text = .CurrentRow.Cells("course").Value.ToString
                txtYearlevel.Text = .CurrentRow.Cells("year_level").Value.ToString
                txtGuardianName.Text = .CurrentRow.Cells("guardian_name").Value.ToString
                txtGuardianContactNumber.Text = .CurrentRow.Cells("guardian_contact_number").Value.ToString
                txtAddress.Text = .CurrentRow.Cells("address").Value.ToString
                txtBirthday.Text = .CurrentRow.Cells("student_Birthday").Value.ToString
                txtStudentNumber.Text = .CurrentRow.Cells("student_number").Value.ToString
                LoadImage()
            End With
        Catch ex As Exception

        End Try
    End Sub

    'BUTTONS

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Load user data based on the queue_ID
        If Not String.IsNullOrEmpty(txtSelectQueue_ID.Text) Then
            Dim selectedQueue_ID As Integer
            If Integer.TryParse(txtSelectQueue_ID.Text, selectedQueue_ID) Then
                LoadUserDataById(selectedQueue_ID)
            Else
                MessageBox.Show("Invalid queue_ID. Please enter a valid numeric ID.")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save changes to the database
        SaveChangesToDatabase()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Enable editing
        EnableEditing()
    End Sub

    'LOAD DATA INTO DATA GRID VIEW

    Private Sub LoadDataIntoDataGridView()
        Dim connectionString As String = "server=localhost;user=root;password=;database=id_process;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Perform database operations
            Dim query As String = "SELECT * FROM id_queue"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Bind DataTable to DataGridView
            dgvUsers.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    'LOAD USER DATA TO THE TEXT BOX

    Private Sub LoadUserDataById(queueID As Integer)
        Dim connectionString As String = "server=localhost;user=root;password=;database=id_process;"
        Dim connection As New MySqlConnection(connectionString)

        'debug
        MessageBox.Show("Proceed")

        Try
            connection.Open()

            ' Perform database operations to get user data by ID
            Dim query As String = "SELECT * FROM id_queue WHERE queue_ID = @queue_ID"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@queue_ID", queueID)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Enable or disable the "Edit" button based on whether data is found
            btnEdit.Enabled = reader.HasRows
            btnSave.Enabled = False ' Disable the "Save" button until editing is initiated

            ' Display the result in TextBox
            If reader.Read() Then
                txtQueue_ID.Text = reader("queue_ID").ToString()
                txtFname.Text = reader("fname").ToString()
                txtLname.Text = reader("lname").ToString()
                txtMi.Text = reader("m_i").ToString()
                txtCourse.Text = reader("course").ToString()
                txtYearlevel.Text = reader("year_level").ToString()
                txtGuardianName.Text = reader("guardian_name").ToString()
                txtGuardianContactNumber.Text = reader("guardian_contact_number").ToString()
                txtAddress.Text = reader("guardian_address").ToString()
                txtBirthday.Text = reader("student_Birthday").ToString()
                txtStudentNumber.Text = reader("student_number").ToString()
                LoadImage()

            Else
                txtQueue_ID.Text = String.Empty
                txtFname.Text = String.Empty
                txtLname.Text = String.Empty
                txtMi.Text = String.Empty
                txtCourse.Text = String.Empty
                txtYearlevel.Text = String.Empty
                txtGuardianName.Text = String.Empty
                txtGuardianContactNumber.Text = String.Empty
                txtAddress.Text = String.Empty
                txtBirthday.Text = String.Empty
                txtStudentNumber.Text = String.Empty
                LoadImage()
                MessageBox.Show("No data found for the selected user ID.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    'THIS WILL ENABLE THE EDITING

    Private Sub EnableEditing()
        ' Enable editing in the TextBox controls
        txtFname.ReadOnly = False
        txtLname.ReadOnly = False
        txtMi.ReadOnly = False
        txtCourse.ReadOnly = False
        txtYearlevel.ReadOnly = False
        txtGuardianName.ReadOnly = False
        txtGuardianContactNumber.ReadOnly = False
        txtAddress.ReadOnly = False
        txtBirthday.ReadOnly = False
        txtStudentNumber.ReadOnly = False


        ' Store the user ID being edited from the txtSelectID TextBox
        If Not String.IsNullOrEmpty(txtSelectQueue_ID.Text) Then
            queueIdToEdit = Convert.ToInt32(txtSelectQueue_ID.Text)
        End If

        ' Debugging output
        MessageBox.Show("EnableEditing clicked. queueIdToEdit: " & queueIdToEdit.ToString())

        btnSave.Enabled = True ' Enable the "Save" button
    End Sub

    'THIS WILL SAVE THE CHANGES TO THE DATABASE

    Private Sub SaveChangesToDatabase()
        ' Save changes to the database based on the user ID being edited
        If queueIdToEdit <> -1 Then
            Dim connectionString As String = "server=localhost;user=root;password=;database=id_process;"
            Dim connection As New MySqlConnection(connectionString)

            Try
                connection.Open()

                ' Perform database operations to update user data
                Dim query As String = "UPDATE id_queue SET fname = @fname, lname = @lname, m_i = @m_i, course = @course, " & _
                                   "year_level = @year_level, guardian_name = @guardian_name, " & _
                                   "guardian_contact_number = @guardian_contact_number, " & _
                                   "guardian_address = @guardian_address, student_Birthday = @student_Birthday " & _
                                   "WHERE queue_ID = @queue_ID"

                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@fname", txtFname.Text)
                command.Parameters.AddWithValue("@lname", txtLname.Text)
                command.Parameters.AddWithValue("@m_i", txtMi.Text)
                command.Parameters.AddWithValue("@course", txtCourse.Text)
                command.Parameters.AddWithValue("@year_level", txtYearlevel.Text)
                command.Parameters.AddWithValue("@guardian_name", txtGuardianName.Text)
                command.Parameters.AddWithValue("@guardian_contact_number", txtGuardianContactNumber.Text)
                command.Parameters.AddWithValue("@guardian_address", txtAddress.Text)
                command.Parameters.AddWithValue("@student_Birthday", txtBirthday.Text)
                command.Parameters.AddWithValue("@queue_ID", queueIdToEdit)

                command.ExecuteNonQuery()

                ' Disable editing after saving changes
                txtFname.ReadOnly = True
                txtLname.ReadOnly = True
                txtMi.ReadOnly = True
                txtCourse.ReadOnly = True
                txtYearlevel.ReadOnly = True
                txtGuardianName.ReadOnly = True
                txtGuardianContactNumber.ReadOnly = True
                txtAddress.ReadOnly = True
                txtBirthday.ReadOnly = True
                txtStudentNumber.ReadOnly = True
                btnSave.Enabled = False

                ' Refresh the DataGridView
                LoadDataIntoDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub


    'BTN browse image

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OPDPhoto
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "jpg"
                .DereferenceLinks = True
                .FileName = ""
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All Files|*.*"
                .Multiselect = False
                .RestoreDirectory = True
                .Title = "SELECT FILE TO OPEN"
                .ValidateNames = True

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Try
                        txtPhoto.Text = .FileName
                        picImportStudent.ImageLocation = .FileName
                        picImportStudent.SizeMode = PictureBoxSizeMode.StretchImage
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    'BTN SAVE IMAGE'

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        ' Enabling the edit
        EnableEditing()

        Try
            If String.IsNullOrEmpty(txtPhoto.Text) OrElse String.IsNullOrEmpty(txtFname.Text) Then
                MessageBox.Show("You need to select an image first", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf Directory.Exists(Application.StartupPath & "\Profiles\" & txtFname.Text & ".png") Then
                Directory.Delete(txtFname.Text)
            Else
                picImportStudent.Image.Save(Application.StartupPath & "\Profiles\" & txtFname.Text & ".png")

                If queueIdToEdit <> -1 Then
                    Dim connectionString As String = "server=localhost;user=root;password=;database=id_process;"
                    Dim connection As New MySqlConnection(connectionString)

                    Try
                        connection.Open()

                        ' Perform database operations to update user data
                        Dim query As String = "UPDATE id_queue SET image = @image WHERE queue_ID = @queue_ID"
                        Dim command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@image", txtFname.Text & ".png")
                        command.Parameters.AddWithValue("@queue_ID", queueIdToEdit)

                        command.ExecuteNonQuery()

                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Load the image of the Student

    Private Sub LoadImage()
        'enable editing
        'EnableEditing()



        Dim connectionString As String = "server=localhost;user=root;password=;database=id_process;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Perform database operations to update user data
            Dim query As String = "Select image FROM id_queue WHERE queue_ID = @queue_ID"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@queue_ID", txtQueue_ID.Text)

            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            MessageBox.Show(dataTable.Rows.Count)
            MessageBox.Show(txtFname.Text)
            If dataTable.Rows.Count > 0 Then
                ' debug
                MessageBox.Show("Proceed")
                If String.IsNullOrEmpty(dataTable.Rows(0).Item("image").ToString) Then
                    picStudent.ImageLocation = Application.StartupPath & "\Profiles\default.png"
                Else
                    picStudent.ImageLocation = Application.StartupPath & "\Profiles\" & dataTable.Rows(0).Item("image").ToString
                End If
            End If



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    
    
    
    
    
    
    
    
    
End Class
