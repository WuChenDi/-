<?php
interface User {
	function getName();
	function setName($name);
	function getDiscount();
}
abstract class AbstractUser implements \User {
	private $name = ""; // Ућзж
	protected $discount = 0; // елПл
	protected $grade = ""; // МЖБ№
	public function __construct($name) {
		$this->setName ( $name );
	}
	public function getName() {
		return $this->name;
	}
	public function getDiscount() {
		return $this->discount;
	}
	public function setName($name) {
		$this->name = $name;
	}
	public function getGrade() {
		return $this->grade;
	}
}
class NormalUser extends AbstractUser {
	protected $discount = 1.0;
	protected $grade = "NormalUser";
}
class VipUser extends AbstractUser {
	protected $discount = 0.8;
	protected $grade = "VipUser";
}
class InnerUser extends AbstractUser {
	protected $discount = 0.7;
	protected $grade = "InnerUser";
}

?>