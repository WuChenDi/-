<?php
class teacher {
	public function speek() {
		echo "��ʦ���ڽ���...";
	}
}
class student {
	public function oper() {
		echo "ѧ����������...";
	}
}
class postman {
	public function action() {
		echo "�ʵ�Ա�����Ϳ��...";
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
		echo "����Ķ������";
	}
}
peopleworking ( new teacher ());
peopleworking ( new student () );
peopleworking ( new postman () );
?>