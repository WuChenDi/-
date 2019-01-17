<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>index</title>
<link href="../css/admin.css" rel="stylesheet" type="text/css" />
</head>
<?php session_start(); 
        if( $_SESSION['name']&& $_SESSION['pwd']) { ?>
    <script language="JavaScript">
        
      </script>
<body>

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
    <li class="active">期刊管理</li>
  </ul>
  </div>

        <div class="result-wrap">
          <div class="result-title">
            <div class="result-list"> <a href="qikan-add.php">新增期刊</a></div>
          </div>
          <div class="result-content">
              <form method="post" >

            <table class="result-tab" width="99%">
              <tr>
                  <th>刊名</th>
                  <th>所属类型</th>
                  <th>添加日期</th>
                  <th width="100px">操作</th>
                </tr>
             
             
<?php 
include 'conn.php';	  
$sql="select * from qikan";
$res=$conn->query($sql);
	while ($row = mysqli_fetch_array($res)){
	?> 
              <tr>
           
                <td><?php echo $row['刊名'];?>
                <input type="hidden" name="id" value="<?php echo $row['id']; ?>"></td>
                <td><?php echo $row['所属类型'];?></td>
                <td><?php echo $row['添加日期'];?></td>      
 <td> <a class="btn1" href="qikan-edit.php?$id=<?php echo $row['id'];?>">编辑</a>
                <a class="btn1" href="qikan-edit-delete.php?$id=<?php echo $row['id'];?>">删除</a>
            </td>          </tr>
            <?php
						}
					 ?>
                       </table>
                       </form>
          </div>
 </div></div>
</body>
</html>
 

<?php }
         else
       { echo "无权访问";}
        ?>