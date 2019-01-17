<?php
class goods {
	private static $goodno = 1000;
	public static $goodname = "娃哈哈纯净水";
	public static function increno() { // 自动增加编号
		return self::$goodno ++ . "<br/>";
	}
	public function outputname() {
		echo self::$goodname . "最我的最爱<br/>";
	}
}
echo goods::increno ();
echo goods::increno ();
echo goods::increno ();
$good = new goods ();
$good->outputname ();

?>