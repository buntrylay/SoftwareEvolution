<h1>Leap Year Calculator</h1>
<form action = "index.php" method = "GET" >
<label for="year">Enter the year: </label>
<input type="text" name="year" id="year" required>
<button type="submit">Check Leap Year</button>
<style>
    body {
        font-family: Arial, sans-serif;
        margin: 20px;
    }
    h1 {
        background-color: azure;
    }
    label, input, button {
        font-size: 1.2em;
        margin: 5px 0;
        display: block;
        }
    form{
        background-color: lightgray;
        padding: 20px;
        border-radius: 5px;
        width: 300px;
    }s

</style>
</form>
<?php
if (isset($_GET["year"])) {
    $leapyear = $_GET["year"];
    if (is_numeric($leapyear) && $leapyear > 0) { // check if input is a positive integer
        $leapyear = round($leapyear); // convert to integer
        if (($year % 4 == 0 && $year % 100 != 0) || ($year % 400 == 0)) {
            echo "<p>$leapyear is a leap year.</p>";
        } else {
            echo "<p>$leapyear is not a leap year.</p>";
        } // obtain the form data and convert to integer
    } else {
        echo "<p>Please enter a valid year.</p>";
    }
} else {
    echo "<p>Please enter a year to check.</p>";
}
?>