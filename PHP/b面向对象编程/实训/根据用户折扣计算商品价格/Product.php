<?
/* 与产品相关的类放. */
Interface Product { // 定义产品接口
	public function getProductName();
	public function getProductPrice();
}
interface Book extends Product { // book是产品的一个分类
	public function getAuthor();
}
class BookOnline implements Book { // 定义book类.
	private $productName; // 产品名
	private $productPrice; // 产品价格
	private $author; // 作者
	public function __construct($_bookName) { // 放置相关初始化的代码.
		$this->productName = $_bookName;
	}
	public function getProductName() {
		return $this->productName;
	}
	public function getProductPrice() { // 读取价格,假设价格是 100元.
		$this->productPrice = 100;
		return $this->productPrice;
	}
	public function getAuthor() { // 获取作者
		return $this->author;
	}
}
?>
