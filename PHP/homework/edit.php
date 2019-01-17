<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
<?php
 include("mysql.php");
  if(isset($_POST["submit"]))
        {
      $id=$_POST['id'];
       $name=$_POST['name'];   
       $sex=$_POST['sex'];
       $hobby=$_POST['hobby'];
       $class=$_POST['class'];
       
       $sql =$con->query("update info set name='$name' ,sex='$sex' ,hobby='$hobby' ,class='$class' where id='$id'");    
       if ($sql){
           echo "<script>alert('修改成功');document.location='second.php';</script>";
            
         }else {
           echo "<script>alert('修改失败');history.back(-1);</script> ";
		}
}
?>
    </body>
</html>