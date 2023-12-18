Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Form_id_card
    Private bitmap As Bitmap
    Private WithEvents ppd As New PrintPreviewDialog
    Private studentNumber As String
    Private fullName As String
    Private courseYear As String
    Private studentPicPath As String

    ' Modify the constructor to receive information
    Public Sub New(studentNumber As String, fullName As String, courseYear As String, studentPicPath As String)
        InitializeComponent()
        Me.studentNumber = studentNumber
        Me.fullName = fullName
        Me.courseYear = courseYear
        Me.studentPicPath = studentPicPath
        MessageBox.Show(studentPicPath)
        
    End Sub

    Private Sub Form_id_card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudent_num.Text = studentNumber
        txtFullName.Text = fullName
        txtCourse_Year.Text = courseYear



        Dim generator As New MessagingToolkit.Barcode.BarcodeEncoder
        generator.BackColor = Color.White
        generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        generator.IncludeLabel = True
        generator.CustomLabel = txtStudent_num.Text

        Try
            picBarCode.Image = New Bitmap(generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, txtStudent_num.Text))
        Catch ex As Exception
            picBarCode.Image = Nothing
        End Try
        LoadProfile()

    End Sub

    Public Sub LoadProfile()
        Dim connectionString As String = "server=localhost;user=root;password=;database=id_process;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Perform database operations to update user data
            Dim query As String = "Select image FROM id_queue WHERE student_number = @student_number"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@student_number", txtStudent_num.Text)

            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            
            If dataTable.Rows.Count > 0 Then
                If String.IsNullOrEmpty(dataTable.Rows(0).Item("image").ToString) Then
                    picProfile.ImageLocation = Application.StartupPath & "\Profiles\default.png"
                Else
                    picProfile.ImageLocation = Application.StartupPath & "\Profiles\" & dataTable.Rows(0).Item("image").ToString
                End If
            End If



        Catch ex As Exception
            MessageBox.Show("Error Load Image: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub txtStudent_num_TextChanged(sender As Object, e As EventArgs) Handles txtStudent_num.TextChanged
        LoadProfile()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 50, 50)
    End Sub

    Public Sub Print()
        'Create a bitmap of the specific area (panel) you want to print
        Dim rect As New Rectangle(front_id.Location, front_id.Size)

        bitmap = New Bitmap(rect.Width, rect.Height)
        front_id.DrawToBitmap(bitmap, rect)

        ' Set up the PrintDocument and PrintPreviewDialog
        PrintDocument1.DefaultPageSettings.Landscape = False
        ppd.Document = PrintDocument1

        ' Display the print preview dialog
        ppd.ShowDialog()
        Return



    End Sub


    Private Sub picProfile_Click(sender As Object, e As EventArgs) Handles picProfile.Click
        Print()
    End Sub
End Class