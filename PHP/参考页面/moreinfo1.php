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
         <link href="css/main.css" rel="stylesheet" type="text/css">
        <link href="css/left.css" rel="stylesheet" type="text/css">
           <style type="text/css">
       *{
	margin:0 auto;
	padding:0
	}
        .all{
            width: 980px;   
          }
          .more{
              width:780px;
	height:630px;
        float:right;
         margin-top:150px;
          }
          .more li{
              list-style-type: none;
             border-bottom: solid 1px #00A0E9;
              margin-top: 10px;
          }
          .morecenter
          {
               margin-left: 100px;
              margin-top: 50px;
          }
          .more li span{
              float:  right;
               margin-top: -20px; 
          }
          </style>
    </head>
    <body>
        <div class="all">
        <?php
          include "top.php";
        include "left3.php";
      include("conn.php");?>
      <div class="more">
          <div class='morecenter'>
	<?php $sql="select * from  qikan  where 所属类型='".$_GET['$id']."'";
                $sql1=$conn->query($sql);
	      $row= mysqli_fetch_array($sql1); 
              $i=0;
               do{
                   $i++;
			   ?>
            <li> <?php echo $i;?>;&nbsp&nbsp&nbsp<a href="qikandetail.php?$id=<?php echo $row['刊名'];?>" target="_blank"><?php echo $row['刊名'];?></a><span><?php echo $row['添加日期'];?></span></li>
      
                                <?php 
                                
                                }while($row=mysqli_fetch_array($sql1));
                                
                                ?>	
          </div>
        </div>
        </div>
      
    </body>
</html>
