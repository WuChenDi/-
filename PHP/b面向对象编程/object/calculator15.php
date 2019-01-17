<?php
class calculator {
	public static function calcular($num1, $num2, $oper) {
		if (is_int ( $num1 ) && is_int ( $num2 )) {
			if ($oper == "+") {
				return $num1 + $num2;
			} else if ($oper == "-") {
				return $num1 - $num2;
			} else if ($oper == "*") {
				return $num1 * $num2;
			} else if ($oper == "/") {
				if ($num2 == 0) {
					return "被除数不能为0，请重新输入";
				} else {
					return $num1 / $num2;
				}
			} else if ($oper == "%") {
				if ($num2 == 0) {
					return "被除数不能为0，请重新输入";
				} else {
					return $num1 % $num2;
				}
			} else {
				return "操作符错误，请重新输入（必须是+、-、*、/、%的一种）";
			}
		} else {
			return "输入的前两个参数必须是整数";
		}
	}
}
$result = calculator::calcular ( 130, 25, "-" );
echo $result;
?>