<?php
abstract class shopcart {
	abstract function showitem($goodname, $goodprice, $goodcatty);
}
class fruitgoods extends shopcart {
	function showitem($goodname, $goodprice, $goodcatty) {
		echo "���������ˮ���ǣ�$goodname�� �乺��۸��ǣ�" . $goodprice . "Ԫ/��, ��������ǣ�$goodcatty, �ܼ۸��ǣ�" . ($goodprice * $goodcatty) . "Ԫ<br/>";
	}
}
class vegetablegoods extends shopcart {
	function showitem($goodname, $goodprice, $goodcatty) {
		echo "����������߲��ǣ�$goodname�� �乺��۸��ǣ�" . $goodprice . "Ԫ/��, ��������ǣ�$goodcatty, �ܼ۸��ǣ�" . ($goodprice * $goodcatty) . "Ԫ<br/>";
	}
}
$fruit = new fruitgoods ();
$fruit->showitem ( "ƻ��", "4.5", 2 );

$vegetable = new vegetablegoods ();
$vegetable->showitem ( "����", "2.5", 1 );
?>