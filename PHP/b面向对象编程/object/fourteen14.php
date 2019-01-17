<?php
class teacher {
	public final function testWork() {
		return "老师正在批改作业...";
	}
}
class test extends teacher {
	public function testWork() {
		return "老师正在批改张姚瑶的作业.";
	}
}

?>