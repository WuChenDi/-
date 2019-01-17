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
         <style type="text/css">
       *{
	margin:0 auto;
	padding:0
	}
        .detail{
            width: 980px;;
           
          }
          .qikaninfo
          {
             width:760px;
	height:630px;
        float:right;
         margin-top:150px;
         border: solid 1px #aaa;
          }
          .right
          {
              width:440px;
              height: 300px;
             }
             ul{
                border-left: solid 1px #00a0e9;
                width:760px;
                height: 30px;  
                margin-top: 10px;
                background-color: #aaa;
                line-height: 30px;
             }
             .breadcrumb li{
                 margin-right: 10px;
                 list-style-type: none;
                 float: left;
             }
             .breadcrumb li a{
                 text-decoration: none;
             }
             .cart-title{
                 text-align: center;
                 margin-top: 20px;
                 margin-bottom: 10px;
             }
             .cart-pic img{
                 width:200px;
                 height: 300px;
                 float:left;
             }
             .info{
                 margin-left: 120px;
                  align:center;
                  margin-top: 20px;
             }
             .cart-infowarp
             {
                
                // margin:0 auto;
                width:300px;
                height: 280px;  
                margin-left: 10px;
               //text-align: center;
                padding-left: 20px;
             }
             .cart-infotitle{
                  border-bottom: solid 1px #0066cc;
                 float:left;
                 margin-top:10px;
                 
               }
               .cart-info{
                   border-bottom: solid 1px #0066cc;
                   margin-top: 10px;
                 //  padding-left: 30px; 
                  }
          </style>
         <link href="css/main.css" rel="stylesheet" type="text/css">
        <link href="css/left.css" rel="stylesheet" type="text/css">
    </head>
    <body>
        <div class="detail">
        <?php
         
        include "top.php";
        include "left3.php";
        ?>
            <div class="qikaninfo">
                
       <ul class="breadcrumb">
         <?php  
		   //     error_reporting(0);  
                    include("conn.php");
	$sql="select * from  qikan  where 刊名='".$_GET['$id']."'";
                $sql1=$conn->query($sql);
	$info1 = mysqli_fetch_array($sql1);  
				?>
    <li> <a href="index.php">首页/</a> <span class="divider"></span> </li>
    <li> <a href="fenlei.php">期刊分类/</a> <span class="divider"></span> </li>
     <li> <a href="fenlei.php?$id=<?php echo $info1['刊名'];?>">教育教学类期刊/</a> <span class="divider"></span> </li>
    <li class="active"><?php echo $info1['刊名'];?></li>
  </ul>
      <div class="cart-title"><?php echo $info1['刊名'];?></div>
      <div class="info">
      <div class="cart-pic"><img src="uploadfile/images/<?php echo $info1['图片URL'];?>"></div>
      <div class="cart-infowarp"> 
        <span class="cart-infotitle">刊名</span>
        <div class="cart-info"><?php echo $info1['刊名'];?></div>
        <span class="cart-infotitle">主办</span>
        <div class="cart-info"><?php echo $info1['主办'];?></div>
        <span class="cart-infotitle">周期</span>
        <div class="cart-info"><?php echo $info1['周期'];?></div>
        <span class="cart-infotitle">出版地</span>
        <div class="cart-info"><?php echo $info1['出版地'];?></div>
        <span class="cart-infotitle">语种</span>
        <div class="cart-info"><?php echo $info1['语种'];?></div>
        <span class="cart-infotitle">开本</span>
        <div class="cart-info"><?php echo $info1['开本'];?></div>
        <span class="cart-infotitle">ISSN</span>
        <div class="cart-info"><?php echo $info1['ISSN'];?></div>
        <span class="cart-infotitle">CN</span>
        <div class="cart-info"><?php echo $info1['CN'];?></div>
        <span class="cart-infotitle">邮发代号</span>
        <div class="cart-info"><?php echo $info1['邮发代号'];?></div>
        <span class="cart-infotitle">更新日期</span>
        <div class="cart-info"><?php echo $info1['添加日期'];?></div>
      </div>
                  <div class="cart-content"> <?php echo $info1['期刊简介'];?></div>

      </div>
            </div>
        </div>
        
    </body>
</html>
