<?
/* ���Ʒ��ص����. */
Interface Product { // �����Ʒ�ӿ�
	public function getProductName();
	public function getProductPrice();
}
interface Book extends Product { // book�ǲ�Ʒ��һ������
	public function getAuthor();
}
class BookOnline implements Book { // ����book��.
	private $productName; // ��Ʒ��
	private $productPrice; // ��Ʒ�۸�
	private $author; // ����
	public function __construct($_bookName) { // ������س�ʼ���Ĵ���.
		$this->productName = $_bookName;
	}
	public function getProductName() {
		return $this->productName;
	}
	public function getProductPrice() { // ��ȡ�۸�,����۸��� 100Ԫ.
		$this->productPrice = 100;
		return $this->productPrice;
	}
	public function getAuthor() { // ��ȡ����
		return $this->author;
	}
}
?>
