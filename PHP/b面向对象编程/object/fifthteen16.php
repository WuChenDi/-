<?php
abstract class people {
	private $name;
	private $age;
	private $birth;
	public function getName() {
		return $this->name;
	}
	public function setName($name) {
		$this->name = $name;
	}
	public function getAge() {
		return $this->age;
	}
	public function setAge($age) {
		$this->age = $age;
	}
	public function getBirth() {
		return $this->birth;
	}
	public function setBirth($birth) {
		$this->birth = $birth;
	}
	public function __construct($name, $age, $birth) {
		$this->name = $name;
		$this->age = $age;
		$this->birth = $birth;
	}
	public abstract function speek();
}
class teacher extends people {
	public function speek() {
		echo "��ʦ˵��ͬѧ�Ǻ�<br/>";
	}
}
class student extends people {
	public function speek() {
		echo "ͬѧ��˵����ʦ��<br/>";
	}
}
$teacher = new teacher ( "���", 27, "1986-10-15" );
$teacher->speek ();
$student = new student ( "������", 14, "1999-1-1" );
$student->speek ();
?>