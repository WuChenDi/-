<?php
header('content-type:text/html;charset="utf-8"');
error_reporting(0);

$arr1 = array('wuchendi', 'momo', 'zhangsan');

//$arr2 = array('username'=>'wuchendi','age'=>21);

echo json_encode($arr1);
