<?php
abstract class shopcart {
	abstract function showitem($goodname, $goodprice, $goodcatty);
}
class fruitgoods extends shopcart {
	function showitem($goodname, $goodprice, $goodcatty) {
		echo "您所购买的水果是：$goodname， 其购买价格是：" . $goodprice . "元/斤, 购买斤数是：$goodcatty, 总价格是：" . ($goodprice * $goodcatty) . "元<br/>";
	}
}
class vegetablegoods extends shopcart {
	function showitem($goodname, $goodprice, $goodcatty) {
		echo "您所购买的蔬菜是：$goodname， 其购买价格是：" . $goodprice . "元/斤, 购买斤数是：$goodcatty, 总价格是：" . ($goodprice * $goodcatty) . "元<br/>";
	}
}
$fruit = new fruitgoods ();
$fruit->showitem ( "苹果", "4.5", 2 );

$vegetable = new vegetablegoods ();
$vegetable->showitem ( "土豆", "2.5", 1 );
?>