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
        <link href="second.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
        <div class="main">
            <div class="left fl">
                <ul style="border: 2px solid #000;font-size:25px;">
                    <li style="list-style: none;font-size:35px;"><a style="text-decoration: none;" href="#top"><strong>学生信息管理</strong></a></li>
                    <?php 
                        include 'mysql.php';
                        Session_Start();
                        $n=$_SESSION['$id'];
                        $sqlstr="select * from info";
                        $result=$con->query($sqlstr);
                        while ($row=$result->fetch_array())
                        {
                            if($n==$row['id'])
                            {
                            ?>
                    <li style="list-style: none;"><a href="second.php?$id=<?php echo $row['id'] ?>" style="color: brown;" ><?php echo $row['name']?>(登录者)</a></li>
                             <?php
                             
                            }
                             else{ ?>
                    <li style="list-style: none;"><a href="second.php?$id=<?php echo $row['id'] ?>" ><?php echo $row['name']?></a></li>
                             <?php            
                             }      
                        }       
                    ?>
                </ul>         
            </div>
            
            <div  style="height: 500px;width:60%;float: left;border: 1px solid black;">
                            <?php
                if(isset($_GET['$id']))
                {
                    $ID=$_GET['$id'];
                    $sqlstr="select * from info where id='$ID'";
                    $result=$con->query($sqlstr);
                    $row=$result->fetch_array(); 
                    ?>
                        
                <form method="post" action="edit.php" style=" width: 500px;height: 500px;">
                    
                    <input type="image" src="<?php echo $row['PIC'];?>" width="150px" height="120px"/><br/>
                            <label>I　D: </label><input type="text" readonly="" value="<?php echo $row['id'] ?>" name="id"/><br/>
                            <label>姓名：</label><input type="text" value="<?php echo $row['name'] ?>" name="name"/><br/>
                            <label>性别：</label><input type="text" value="<?php echo $row['sex'] ?>" name="sex"/><br/>
                            <label>爱好：</label><input type="text" value="<?php echo $row['hobby'] ?>" name="hobby"/><br/>
                            <label>班级：</label><input type="text" value="<?php echo $row['class'] ?>" name="class"/><br/>
                            <input type="submit" value="编辑" name="submit"/>&nbsp;&nbsp;
                            <a style="font-size: 25px;" href="del.php?$id=<?php echo $row['id'];?>">删除</a><br/>
                        </form>
                        <?php
                      }     
                      ?>
            </div>
          
                
            
        </div>
    </body>
</html>
