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
					return "����������Ϊ0������������";
				} else {
					return $num1 / $num2;
				}
			} else if ($oper == "%") {
				if ($num2 == 0) {
					return "����������Ϊ0������������";
				} else {
					return $num1 % $num2;
				}
			} else {
				return "�������������������루������+��-��*��/��%��һ�֣�";
			}
		} else {
			return "�����ǰ������������������";
		}
	}
}
$result = calculator::calcular ( 130, 25, "-" );
echo $result;
?>