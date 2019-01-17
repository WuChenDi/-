<?php
interface IAnimal {
	function eat($food);
}
interface IManmal {
	function breastfeeding($food);
	function checkgender($gender);
}
class animalinfo {
	private $name;
	public function getName() {
		return $this->name;
	}
	public function setName($name) {
		$this->name = $name;
	}
}
class dog extends animalinfo implements IAnimal, IManmal {
	public $gender = "male";
	function eat($food) {
		if ($food == "cookie") {
			echo "味道还不错<br/>";
		} else {
			echo "除了饼干，其他东西我都不喜欢吃.<br/>";
		}
	}
	function breastfeeding($food) {
		if ($food != "cookie") {
			echo "不想吃别的东西<br/>";
		} else {
			echo "强烈建议母乳喂养<br/>";
		}
	}
	function checkgender($gender) {
		parent::setName ( "哈根达斯" );
		$name = parent::getName ();
		if ($this->gender == $gender) {
			echo $name . "可是个男性啊<br/>";
		} else {
			echo $name . "我是一个女性<br/>";
		}
	}
}

$dog = new dog ();
$dog->eat ( "cookie" );
$dog->breastfeeding ( "cookie" );
$dog->checkgender ( "male" ); // 性别

?>