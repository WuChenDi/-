<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
 include("conn.php");
  
	$id=$_GET['$id'];
	$sql="delete from qikan where id='$id'";
	if($conn->query($sql))
	{
	 echo "<script language=javascript>alert('删除成功!');window.location.href='backdoor.php';</script>";
     } else {
	echo "<script>alert('删除失败！');</script>";
     }

?>
    </body>
</html>
