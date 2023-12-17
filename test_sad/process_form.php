<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "test_vb_connect";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$firstname = $_POST['firstname'];
$MI = $_POST['MI'];
$lastname = $_POST['lastname'];
$course = $_POST['course'];
$yearlevel = $_POST['yearlevel'];


$studentaddress = $_POST['studentaddress'];
$guardianName = $_POST['guardianName'];
$cpNumber = $_POST['cpNumber'];
$birthdate = $_POST['birthdate'];
$yearlevel = $_POST['yearlevel'];


$sql = "INSERT INTO users (firstname, MI, lastname, course, yearlevel, studentaddress, guardianName, cpNumber, birthdate) VALUES ('$firstname', '$MI','$lastname','$course','$yearlevel','$studentaddress','$guardianName','$cpNumber',''$birthdate)";

if ($conn->query($sql) === TRUE) {
    echo "Record added successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>
