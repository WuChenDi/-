<?php
class teacher {
	private function testWork($stuname) {
		echo "��ʦ�������� $stuname ͬѧ����ҵ.<br/>";
	}
	public function returnWork($stuname) {
		$this->testWork ( $stuname );
		echo "�޸ĺ�������ǣ���ܰ�����ҵ�治��";
	}
}

$obj = new teacher ();
$obj->returnWork ( "�¾�ʿ" );

?>