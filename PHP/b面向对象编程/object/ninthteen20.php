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
			echo "ζ��������<br/>";
		} else {
			echo "���˱��ɣ����������Ҷ���ϲ����.<br/>";
		}
	}
	function breastfeeding($food) {
		if ($food != "cookie") {
			echo "����Ա�Ķ���<br/>";
		} else {
			echo "ǿ�ҽ���ĸ��ι��<br/>";
		}
	}
	function checkgender($gender) {
		parent::setName ( "������˹" );
		$name = parent::getName ();
		if ($this->gender == $gender) {
			echo $name . "���Ǹ����԰�<br/>";
		} else {
			echo $name . "����һ��Ů��<br/>";
		}
	}
}

$dog = new dog ();
$dog->eat ( "cookie" );
$dog->breastfeeding ( "cookie" );
$dog->checkgender ( "male" ); // �Ա�

?>