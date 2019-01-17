<?php
class teacher {
	public function speek() {
		echo "老师正在讲课...";
	}
}
class student {
	public function oper() {
		echo "学生正在听课...";
	}
}
class postman {
	public function action() {
		echo "邮递员正在送快递...";
	}
}
function peopleworking($obj) {
	if ($obj instanceof teacher) {
		$obj->speek ();
	} else if ($obj instanceof student) {
		$obj->oper ();
	} else if ($obj instanceof postman) {
		$obj->action ();
	} else {
		echo "传入的对象错误";
	}
}
peopleworking ( new teacher ());
peopleworking ( new student () );
peopleworking ( new postman () );
?>