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
    <div class="jmclogo"><img  src="jmc.png" alt="Italian Trulli"></div>
    <div class="inner-first">
        
        <label for="firstname">First name </label>
        <input type="text" name="firstname" required>
        
        <label for="MI">MI </label>
        <input type="text" name="MI" required>
        
        <label for="lastname">Last Name </label>
        <input type="text" name="lastname" required>
    </div>
        <div class="head-container"> 
        <div class="custome-select">
        <label for="course">Course </label>
        <select name="course" id="course">
            <option value="BECEd">BECEd</option>
            <option value="BEEd">BEEd</option>
            <option value="BSA">BSA</option>
            <option value="BSMA">BSMA</option>
            <option value="BSTM">BSTM</option>
            <option value="BSE-CE">BSE-CE</option>
            <option value="BSE-SE">BSE-SE</option>
            <option value="BSCrim">BSCrim</option>
            <option value="BSIT">BSIT</option>
            <option value="BSEMC">BSEMC</option>
            <option value="BSN">BSN</option>
            <option value="BSP">BSP</option>
            <option value="BSRT">BSRT</option>
            <option value="BSAg">BSAg</option>
            <option value="BSBio">BSBio</option>
            <option value="BSPsych">BSPsych</option>
            <option value="BSSW">BSSW</option>
        </select>
            </div>
        <div class="custome-select">
            <label for="yearlevel">Year Level </label>
        <select name="yearlevel" id="yearlevel">
            <option value="1st">1st Year</option>
            <option value="2nd">2nd Year</option>
            <option value="3rd">3rd Year</option>
            <option value="4th">4th Year</option>
        </select>
        </div>
        </div>
    

    <div class="inner-second">

        <label for="guardian_address">Student Address </label>
        <input type="text" name="guardian_address" required>
        
        <label for="guardian_name">Guardian's Name   </label>
        <input type="text" name="guardian_name" required>

        <label for="guardian_contact_number">Guardian's Contact No.</label>
        <input pattern="[0-9]{11}" name="guardian_contact_number" type="tel" required>

        
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
