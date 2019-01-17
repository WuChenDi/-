<!DOCTYPE HTML>
<html lang="en-US">
<head>
<meta charset="UTF-8">
<title>index</title>
<link rel="stylesheet" type="text/css" href="../css/admin.css"/>
</head>
<body>
<?php session_start(); 
        if( $_SESSION['name']&& $_SESSION['pwd']) { ?>	
<div class="navbar-inner">
    <ul class="pull-right">
      <li><b>欢迎您！</b></li>
      <li><a href="admin.php"><?php echo $_SESSION['name'] ?></a></li>
      <li><a href="index.php?action=logout">退出</a></li>
    </ul>
    <a class="brand" href="backdoor.php">后台管理系统</a> 
    </div>
<?php
	include "leftframe.php";
	?>
   <div class="content">
  <div class="breadcrumb">
  <ul>
    <li><a href="backdoor.php">首页</a></li>
    <li>>></li>
    <li><a href="backdoor.php">期刊管理</a></li>
    <li>>></li>
    <li class="active">修改期刊</li>
  </ul>
  </div>
        <div class="result-wrap">
          <div class="result-content">
            <form action="qikan-edit-process.php" method="post" >
              <table class="insert-tab" width="98%">
                <tbody>
   <?php  
	
				include("conn.php");
				$sql="select * from  qikan  where id='".$_GET['$id']."'";
                $res = $conn->query($sql);
				$info1 = mysqli_fetch_array($res);  
				?>   
                  <tr>
                    <th>刊名：</th>
                    <input class="common-text" name="ID" size="50" type="hidden" value="<?php echo $info1['id'];?>">
                    <td><input class="common-text" name="KM" size="50" type="text" value="<?php echo $info1['刊名'];?>"></td>
                  </tr>
                   <tr>
                    <th>主办：</th>
                    <td><input class="common-text" name="ZB" size="50" value="<?php echo $info1['主办'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>周期：</th>
                    <td><input class="common-text" name="ZQ" size="50" value="<?php echo $info1['周期'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>出版地：</th>
                    <td><input class="common-text" name="CBD" size="50" value="<?php echo $info1['出版地'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>语种：</th>
                    <td><input class="common-text" name="YZ" size="50" value="<?php echo $info1['语种'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>开本：</th>
                    <td><input class="common-text" name="KB" size="50" value="<?php echo $info1['开本'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>ISSN：</th>
                    <td><input class="common-text" name="ISSN" size="50" value="<?php echo $info1['ISSN'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>CN：</th>
                    <td><input class="common-text" name="CN" size="50" value="<?php echo $info1['CN'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>邮发代号：</th>
                    <td><input class="common-text" name="YFDH" size="50" value="<?php echo $info1['邮发代号'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>复合影响因子：</th>
                    <td><input class="common-text" name="FHYZ" size="50" value="<?php echo $info1['复合影响因子'];?>" type="text"></td>
                  </tr>
                  <tr>
                     <th>综合影响因子：</th>
                    <td><input class="common-text" name="ZHYZ" size="50" value="<?php echo $info1['综合影响因子'];?>" type="text"></td>
                  </tr>
                  <tr>
                    <th>投稿类型：</th>
                    <td><select name="type" class="cs-select">
                       <option value="教育教学">-教育教学-</option>
                       <option value="<?php echo $info1['所属类型'];?>" selected>-<?php echo $info1['所属类型'];?>-</option>
                       <option value="计算机类">-计算机类-</option>
                       <option value="经济管理">-经济管理-</option>
                       <option value="电子通信">-电子通信-</option>
                       <option value="建筑水利">-建筑水利-</option>
                       <option value="学报学刊">-学报学刊-</option>
                       <option value="农林牧渔">-农林牧渔-</option>
                       <option value="医药医学">-医药医学-</option>
                       <option value="文体传播">-文体传播-</option>
                       <option value="社科法制">-社科法制-</option>
                       <option value="综合分类">-综合分类-</option>
                      </select></td>
                  </tr>
                  <tr>
                    <th>添加日期：</th>
                    <td><input class="common-text" name="RQ" size="50" value="<?php echo $info1['添加日期'];?>" type="text"></td>
                  </tr>
                  <tr>
                  <th>期刊简介</th>
                  <td>
                  <script id="container" name="content" type="text/plain">
                             <?php echo $info1['期刊简介'];?>
                              </script>
                  </td>
                  </tr>
                  <tr>
                    <th></th>
                    <td><input class="btn btn-primary" value="提交" type="submit" name="mySent" id="btn-center">
                      <input class="btn" onclick="history.go(-1)" value="返回" type="button"></td>
                  </tr>
                </tbody>
              </table>
            </form>
          </div>
        </div>
      </div>
    </div>

<script type="text/javascript" src="ueditor/ueditor.config.js"></script> 
<!-- 编辑器源码文件 --> 
<script type="text/javascript" src="ueditor/ueditor.all.js"></script> 
<script type="text/javascript" src="ueditor/third-party/jquery-1.10.2.min.js"></script> 
<!-- 实例化编辑器 --> 
<script type="text/javascript">
        var ue = UE.getEditor('container');
    </script>
</body>
</html>

 <?php }
         else
       { echo "无权访问";}
        ?>