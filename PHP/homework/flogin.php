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
             include 'mysql.php';
             if(isset($_POST['submit']))
             {
                 $id=$_POST['text'];
                 $pwd=$_POST['pwd'];
                $sqlstr= "select * from info where id='$id' and pwd='$pwd'";//验证编号、密码
                $result = $con->query($sqlstr);
                
                if($result->num_rows>0){
                    session_start();
                    $_SESSION['$id'] = $id;
                    echo "<script language=javascript>alert('登录成功！');window.open('second.php?".$id."','_parent')</script>";
                     $result->close();
                    $conn->close();  
                } else {
                        echo "<script language=javascript>alert('账户或密码错误！请重新输入。');window.open('index.php','_parent')</script>";
                        exit();
                        }  
             }
        ?>
    </body>
</html>
