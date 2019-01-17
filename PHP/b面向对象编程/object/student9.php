<?php
class teacher {
	private $name; // 人的名子
	private $sex; // 人的性别
	private $age; // 人的年龄
	public function getName() {
		return $this->name;
	}
	public function setName($name) {
		$this->name = $name;
	}
	public function getSex() {
		return $this->sex;
	}
	public function setSex($sex) {
		$this->sex = $sex;
	}
	public function getAge() {
		if ($this->age < 18 || $this->age > 100) {
			return 24;
		} else {
			return $this->age;
		}
	}
	public function setAge($age) {
		$this->age = $age;
	}
}
$p1 = new teacher ();
$p1->setName ( "王飞飞" );
$p1->setSex ( "女" );
$p1->setAge ( 10 );
echo $p1->getName ();
echo $p1->getSex ();
echo $p1->getAge ();
?>