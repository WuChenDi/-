<?php
function my_func(&$arg = NULL) {
	if ($arg === NULL) {
		echo "\$argΪ��";
	}
}
my_func();
?>