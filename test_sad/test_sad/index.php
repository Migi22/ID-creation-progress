<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP Form</title>
    <link rel="stylesheet" href="index.css">

</head>
<body>

     <div class="first-top-container">
        <h1>JMC Identification Card Request</h1>
    <div class="second-top-container">

    <form action="process_form.php" method="post">
       
    <div class="inner-first">
        
        <label for="firstname">First name </label>
        <input type="text" name="firstname" required>
        
        <label for="MI">MI </label>
        <input type="text" name="MI" required>
        
        <label for="lastname">Last Name </label>
        <input type="text" name="lastname" required>
    </div>
    <div class="head-container"> 
        
        <label for="course">Course </label>
        <input type="text" name="course" required>

        <label for="yearlevel">Year Level </label>
        <input type="text" name="yearlevel" required>
    </div>
    

    <div class="inner-second">

        <label for="guardian_address">Student Address </label>
        <input type="text" name="guardian_address" required>
        
        <label for="guardian_name">Guardian's Name   </label>
        <input type="text" name="guardian_name" required>

        <label for="guardian_contact_number">Guardian's Contact No.  </label>
        <input type="tel"  pattern="[0-9]{11}" name="guardian_contact_number" required>
        
        <label for="student_Birthday">Student's Birth Date</label>
        <input type="date" id="birthday" name="student_Birthday">
    </div>
    

    <div class="submit-container">
        <input type="submit" value="Submit">
    </div>
       
    </form>
    </div>
    </div>
</body>
</html>
