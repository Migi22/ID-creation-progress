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

        <label for="studentaddress">Student Address </label>
        <input type="text" name="studentaddress" required>
        
        <label for="guardianName">Guardian's Name   </label>
        <input type="tel"  pattern="[0-9]{10}" name="guardianName" required>

        <label for="cpNumber">Guardian's Contact No.  </label>
        <input type="tel"  pattern="[0-9]{10}" name="cpNumber" required>
        
        <label for="birthdate">Student's Birth Date</label>
        <input type="date" id="birthday" name="birthdate">
    </div>
    

    <div class="submit-container">
        <input type="submit" value="Submit">
    </div>
       
    </form>
    </div>
    </div>
</body>
</html>
