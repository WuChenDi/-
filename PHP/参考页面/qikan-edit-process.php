<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
<?php
 include("conn.php");
  if(isset($_POST["mySent"]))
        {
       $ID=$_POST['ID'];   
       $KM=$_POST['KM'];
       $ZB=$_POST['ZB'];
       $ZQ=$_POST['ZQ'];
       $CBD=$_POST['CBD'];
       $YZ=$_POST['YZ'];
       $KB=$_POST['KB'];
       $ISSN=$_POST['ISSN'];
       $CN=$_POST['CN'];
       $YFDH=$_POST['YFDH'];
       $FHYZ=$_POST['FHYZ'];
       $ZHYZ=$_POST['ZHYZ'];
       $type=$_POST['type'];
	   $RQ=$_POST['RQ'];
	   $content=$_POST['content']; 
       $sql =$conn->query("update qikan set 刊名='$KM' ,主办='$ZB' ,周期='$ZQ' ,出版地='$CBD',语种='$YZ' ,开本='$KB',ISSN='$ISSN' ,CN='$CN',邮发代号='$YFDH' ,复合影响因子='$FHYZ',综合影响因子='$ZHYZ' ,所属类型='$type',添加日期='$RQ' ,期刊简介='$content' where id='$ID'");    
       if ($sql){
           echo "<script>alert('修改成功');document.location='backdoor.php';</script>";
         }else {
           echo "<script>alert('修改失败');history.back(-1);</script> ";
		}
}
?>
    </body>
</html>