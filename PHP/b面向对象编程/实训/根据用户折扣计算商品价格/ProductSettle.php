<?
include_once ("User.php");
include_once ("Product.php");
// ���˲�Ʒ���׶���Ǯ��?
class ProductSettle {
	public static function finalPrice(User $_user, Product $_product, $number = 1) {
		$price = $_user->getDiscount () * $_product->getProductPrice () * $number;
		return $price;
	}
}
?>
