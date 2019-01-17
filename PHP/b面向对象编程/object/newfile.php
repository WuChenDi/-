<?php
function my_func(&$arg = NULL) {
	if ($arg === NULL) {
		echo "\$argЮЊПе";
	}
}
my_func();
?>