<?php
class teacher {
	private function testWork($stuname) {
		echo "老师正在批改 $stuname 同学的作业.<br/>";
	}
	public function returnWork($stuname) {
		$this->testWork ( $stuname );
		echo "修改后的评语是：你很棒，作业真不错！";
	}
}

$obj = new teacher ();
$obj->returnWork ( "陈军士" );

?>