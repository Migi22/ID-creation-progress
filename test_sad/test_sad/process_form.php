<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "id_process";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$firstname = $_POST['firstname'];
$MI = $_POST['MI'];
$lastname = $_POST['lastname'];
$course = $_POST['course'];
$yearlevel = $_POST['yearlevel'];
$guardian_address = $_POST['guardian_address'];
$guardian_name = $_POST['guardian_name'];
$guardian_contact_number = $_POST['guardian_contact_number'];
$student_Birthday = date("F j, Y", strtotime($_POST["student_Birthday"]));


$sql = "INSERT INTO id_queue (fname, m_i, lname, course, year_level, guardian_address, guardian_name, guardian_contact_number, student_Birthday) 
        VALUES ('$firstname', '$MI', '$lastname', '$course', '$yearlevel', '$guardian_address', '$guardian_name', '$guardian_contact_number', '$student_Birthday')";

if ($conn->query($sql) === TRUE) {
    echo "Record added successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>
