<?php
class goods {
	private static $goodno = 1000;
	public static $goodname = "�޹�������ˮ";
	public static function increno() { // �Զ����ӱ��
		return self::$goodno ++ . "<br/>";
	}
	public function outputname() {
		echo self::$goodname . "���ҵ��<br/>";
	}
}
echo goods::increno ();
echo goods::increno ();
echo goods::increno ();
$good = new goods ();
$good->outputname ();

?>