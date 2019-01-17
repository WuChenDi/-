<?php
$con = new mysqli("localhost", "root","","test")
                or die("Could not connect: ".mysql_error());
        mysqli_query($con,"set names 'utf8'");