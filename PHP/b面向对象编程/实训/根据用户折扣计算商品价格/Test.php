<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=GBK" />
<title>�����û������ۿۼ�����Ʒ�۸�</title>
<link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body>
	<div id="container">
		<!-- ============= header start ============= -->
		<div id="header">
			<div id="banner">
				<h1 class="logo">Itzcn���</h1>
			</div>
			<!-- ============= �˵���(��ʼ) ============= -->
			<div id="menubar">
				<ul>
					<li class="active_menu">
						<a href="#">��ҳ</a>
					</li>
					<li>
						<a href="#">�������</a>
					</li>
					<li>
						<a href="#">�����б�</a>
					</li>
					<li>
						<a href="#">ͼ��ר��</a>
					</li>
					<li>
						<a href="#">�ҵ��˺�</a>
					</li>
					<li>
						<a href="#">�û�ע��</a>
					</li>
					<li>
						<a href="#">��ϵ����</a>
					</li>
					<li>
						<a href="#">�˲���Ƹ</a>
					</li>
				</ul>
			</div>
			<!-- ============= �˵���(����) ============= -->
		</div>
		<!-- ============= header end ============= -->
		<div id="body" class="clear">
			<!-- ============= body_left start ============= -->
			<div id="body_left">
				<form id="form1">
					<h2>
						<img src="imgs/bullet1.gif" />
						����ͼ�鹺��
					</h2>
					<?php
					include_once 'User.php';
					include_once 'Product.php';
					include_once 'ProductSettle.php';
					
					$number = 10;
					$book = new BookOnline ( "���ģʽ" );
					$user = new NormalUser ( "Tom" );
					$price = ProductSettle::finalPrice ( $user, $book, $number );
					$str = "���ã��𾴵��û� " . $user->getName () . " <br>";
					$str .= "���ļ����� " . $user->getGrade () . ", <br>";
					$str .= "�����ۿ��� " . $user->getDiscount () . "<br>";
					$str .= "���� $number �� �� " . $book->getProductName ();
					$str .= "���ļ۸��� $price <br><br>";
					echo $str;
					
					$user = new vipUser ( "Tom" );
					$price = ProductSettle::finalPrice ( $user, $book, $number );
					$str = "���ã��𾴵��û� " . $user->getName () . " <br>";
					$str .= "���ļ����� " . $user->getGrade () . ", <br>";
					$str .= "�����ۿ��� " . $user->getDiscount () . "<br>";
					$str .= "���� $number �� �� " . $book->getProductName ();
					$str .= "���ļ۸��� $price <br><br>";
					echo $str;
					
					$user = new InnerUser ( "Tom" );
					$price = ProductSettle::finalPrice ( $user, $book, $number );
					$str = "���ã��𾴵��û� " . $user->getName () . " <br>";
					$str .= "���ļ����� " . $user->getGrade () . ", <br>";
					$str .= "�����ۿ��� " . $user->getDiscount () . "<br>";
					$str .= "���� $number �� �� " . $book->getProductName ();
					$str .= "���ļ۸��� $price <br><br>";
					echo $str;
					?>
					
				</form>
				<br />
				<div class="prod" id="fileContent"></div>
				<!-- ============= �����Ƽ�����ʼ�� ============= -->
				<h2>
					<img src="imgs/bullet1.gif" />
					�����Ƽ�
				</h2>
				<div class="prod clear">
					<img src="imgs/G8100758.jpg" class="pic" />
					<div class="explain_box">
						<div class="top"></div>
						<div class="content">
							<div class="title">
								<a href="#">��Ӱ�籩��Maya��Ϸ�������ع�</a>
							</div>
							<div class="details">�����������Maya�������������Ϸ��ʵ�ּ��������ݰ���
								Maya�Ļ���֪ʶ����ģ���������ʡ��ƹ��Ӧ�ã���Ϸ��������Ϸ��ɫ����Ϸ��Ч��ơ�</div>
							<div class="more">
								<a href="#">- ��ϸ˵�� -</a>
							</div>
						</div>
						<div class="bottom"></div>
					</div>
				</div>
				<div class="prod clear">
					<img src="imgs/G7024623.jpg" class="pic" />
					<div class="explain_box">
						<div class="top"></div>
						<div class="content">
							<div class="title">
								<a href="#">SQL Server 2008��ȫѧϰ�ֲ�</a>
							</div>
							<div class="details">��������ݿ�Ļ���֪ʶ���֣�ȫ�����SQL Server
								2008���ݿ�Ӧ��֪ʶ��ȫ�����ݰ������ݲ�ѯ�͹����洢���̣�����������ȫ���ƣ����ɷ��񣬷�������ͱ����������ݡ�</div>
							<div class="more">
								<a href="#">- ��ϸ˵�� -</a>
							</div>
						</div>
						<div class="bottom"></div>
					</div>
				</div>
				<!-- ============= �����Ƽ��������� ============= -->
				<!-- ============= �����ϼܣ���ʼ�� ============= -->
				<h2>
					<img src="imgs/bullet2.gif" />
					�����ϼ�
				</h2>
				<div class="clear">
					<div class="show_prod">
						<a href="#">NetBeans</a>
						<div class="pic">
							<img src="imgs/new_icon.gif" class="icon" />
							<a href="#">
								<img src="imgs/N07023858.jpg" class="prod_pic" />
							</a>
						</div>
					</div>
					<div class="show_prod">
						<a href="#">Ruby on Rail</a>
						<div class="pic">
							<img src="imgs/new_icon.gif" class="icon" />
							<a href="#">
								<img src="imgs/N207022820.jpg" class="prod_pic" />
							</a>
						</div>
					</div>
					<div class="show_prod">
						<a href="#">SSH</a>
						<div class="pic">
							<img src="imgs/new_icon.gif" class="icon" />
							<a href="#">
								<img src="imgs/N207024411.jpg" class="prod_pic" />
							</a>
						</div>
					</div>
				</div>
				<!-- ============= �����ϼܣ������� ============= -->
			</div>
			<!-- ============= body_left end ============= -->
			<div id="body_right">
				<div id="cart" class="clear">
					<h2>
						<img src="imgs/cart.gif" width="21" height="18" />
						���ﳵ
					</h2>
					<div class="info">
						30����Ʒ |
						<span>�ܼƣ�2500��</span>
						<a href="#">�鿴���ﳵ</a>
					</div>
				</div>
				<img src="imgs/border.gif" width="329" height="31" />
				<div id="about_our">
					<h2>
						<img src="imgs/bullet3.gif" width="26" height="25" />
						�������
					</h2>
					<div class="details clear">
						<img src="imgs/about.jpg" />
						<p>
							���ǿƼ���˾��עIT������ѵ�г��ķ�չ�ͱ仯�����������߽������ƽ���ֽ����ѧ���̡���������www.itzcn.com��������������ʵ�����󣬷�����Flex��C#��Java��ASP.NET��JSP��ϵ����Ƶ�̡̳�</p>
					</div>
				</div>
				<img src="imgs/border.gif" width="329" height="31" />
				<div id="promotions">
					<h2>
						<img src="imgs/bullet4.gif" width="26" height="25" />
						�Ż�ͼ��
					</h2>
					<div class="show_prod">
						<a href="#">3ds Max 2009</a>
						<div class="pic">
							<img src="imgs/promo_icon.gif" class="icon" />
							<a href="#">
								<img src="imgs/S528092300.jpg" class="prod_pic" />
							</a>
						</div>
					</div>
					<div class="show_prod">
						<a href="#">3ds max 9</a>
						<div class="pic">
							<img src="imgs/promo_icon.gif" class="icon" />
							<a href="#">
								<img src="imgs/S528093229.jpg" class="prod_pic" />
							</a>
						</div>
					</div>
					<div class="show_prod">
						<a href="#">Premiere Pro 2.0</a>
						<div class="pic">
							<img src="imgs/promo_icon.gif" class="icon" />
							<a href="#">
								<img src="imgs/S528093724.jpg" class="prod_pic" />
							</a>
						</div>
					</div>
				</div>
				<div class="right_box">
					<h2>
						<img src="imgs/bullet5.gif" width="26" height="25" />
						ͼ�����
					</h2>
					<ul class="list">
						<li>
							<a href="#">��ά����</a>
						</li>
						<li>
							<a href="#">.NET����</a>
						</li>
						<li>
							<a href="#">Java����</a>
						</li>
						<li>
							<a href="#">PHP����</a>
						</li>
						<li>
							<a href="#">��������</a>
						</li>
						<li>
							<a href="#">Webǰ��</a>
						</li>
						<li>
							<a href="#">���ݿ⼼��</a>
						</li>
						<li>
							<a href="#">����Ӧ��</a>
						</li>
					</ul>
				</div>
				<div class="right_box">
					<h2>
						<img src="imgs/bullet6.gif" width="26" height="25" />
						��������
					</h2>
					<ul class="list">
						<li>
							<a href="#">������</a>
						</li>
						<li>
							<a href="#">������̳</a>
						</li>
						<li>
							<a href="#">Google����</a>
						</li>
						<li>
							<a href="#">�ٶ�����</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<!-- ============= footer start ============= -->
		<div id="footer">
			<div class="logo">
				<img src="imgs/logo.png" />
				<img src="imgs/itzcn.gif" />
			</div>
			<div class="nav">
				<ul>
					<li>
						<a href="#">��ҳ</a>
					</li>
					<li>
						<a href="#">��������</a>
					</li>
					<li>
						<a href="#">����</a>
					</li>
					<li>
						<a href="#">����Э��</a>
					</li>
					<li>
						<a href="#">��ϵ����</a>
					</li>
				</ul>
			</div>
			<img src="imgs/footer_bg.gif" />
		</div>
		<!-- ============= footer end ============= -->
	</div>
</body>
</html>
