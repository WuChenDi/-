<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=GBK" />
<title>根据用户享受折扣计算商品价格</title>
<link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body>
	<div id="container">
		<!-- ============= header start ============= -->
		<div id="header">
			<div id="banner">
				<h1 class="logo">Itzcn书店</h1>
			</div>
			<!-- ============= 菜单条(开始) ============= -->
			<div id="menubar">
				<ul>
					<li class="active_menu">
						<a href="#">首页</a>
					</li>
					<li>
						<a href="#">关于书店</a>
					</li>
					<li>
						<a href="#">新书列表</a>
					</li>
					<li>
						<a href="#">图书专辑</a>
					</li>
					<li>
						<a href="#">我的账号</a>
					</li>
					<li>
						<a href="#">用户注册</a>
					</li>
					<li>
						<a href="#">联系我们</a>
					</li>
					<li>
						<a href="#">人才招聘</a>
					</li>
				</ul>
			</div>
			<!-- ============= 菜单条(结束) ============= -->
		</div>
		<!-- ============= header end ============= -->
		<div id="body" class="clear">
			<!-- ============= body_left start ============= -->
			<div id="body_left">
				<form id="form1">
					<h2>
						<img src="imgs/bullet1.gif" />
						在线图书购买
					</h2>
					<?php
					include_once 'User.php';
					include_once 'Product.php';
					include_once 'ProductSettle.php';
					
					$number = 10;
					$book = new BookOnline ( "设计模式" );
					$user = new NormalUser ( "Tom" );
					$price = ProductSettle::finalPrice ( $user, $book, $number );
					$str = "您好，尊敬的用户 " . $user->getName () . " <br>";
					$str .= "您的级别是 " . $user->getGrade () . ", <br>";
					$str .= "您的折扣是 " . $user->getDiscount () . "<br>";
					$str .= "购买 $number 本 《 " . $book->getProductName ();
					$str .= "》的价格是 $price <br><br>";
					echo $str;
					
					$user = new vipUser ( "Tom" );
					$price = ProductSettle::finalPrice ( $user, $book, $number );
					$str = "您好，尊敬的用户 " . $user->getName () . " <br>";
					$str .= "您的级别是 " . $user->getGrade () . ", <br>";
					$str .= "您的折扣是 " . $user->getDiscount () . "<br>";
					$str .= "购买 $number 本 《 " . $book->getProductName ();
					$str .= "》的价格是 $price <br><br>";
					echo $str;
					
					$user = new InnerUser ( "Tom" );
					$price = ProductSettle::finalPrice ( $user, $book, $number );
					$str = "您好，尊敬的用户 " . $user->getName () . " <br>";
					$str .= "您的级别是 " . $user->getGrade () . ", <br>";
					$str .= "您的折扣是 " . $user->getDiscount () . "<br>";
					$str .= "购买 $number 本 《 " . $book->getProductName ();
					$str .= "》的价格是 $price <br><br>";
					echo $str;
					?>
					
				</form>
				<br />
				<div class="prod" id="fileContent"></div>
				<!-- ============= 好书推荐（开始） ============= -->
				<h2>
					<img src="imgs/bullet1.gif" />
					好书推荐
				</h2>
				<div class="prod clear">
					<img src="imgs/G8100758.jpg" class="pic" />
					<div class="explain_box">
						<div class="top"></div>
						<div class="content">
							<div class="title">
								<a href="#">电影风暴：Maya游戏场景大曝光</a>
							</div>
							<div class="details">本书介绍利用Maya软件开发网络游戏的实现技术。内容包括
								Maya的基础知识，建模技术，材质、灯光的应用；游戏场景、游戏角色、游戏特效设计。</div>
							<div class="more">
								<a href="#">- 详细说明 -</a>
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
								<a href="#">SQL Server 2008完全学习手册</a>
							</div>
							<div class="details">本书从数据库的基础知识入手，全面介绍SQL Server
								2008数据库应用知识。全书内容包括数据查询和管理，存储过程，触发器，安全机制，集成服务，分析服务和报表服务等内容。</div>
							<div class="more">
								<a href="#">- 详细说明 -</a>
							</div>
						</div>
						<div class="bottom"></div>
					</div>
				</div>
				<!-- ============= 好书推荐（结束） ============= -->
				<!-- ============= 新书上架（开始） ============= -->
				<h2>
					<img src="imgs/bullet2.gif" />
					新书上架
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
				<!-- ============= 新书上架（结束） ============= -->
			</div>
			<!-- ============= body_left end ============= -->
			<div id="body_right">
				<div id="cart" class="clear">
					<h2>
						<img src="imgs/cart.gif" width="21" height="18" />
						购物车
					</h2>
					<div class="info">
						30件商品 |
						<span>总计：2500￥</span>
						<a href="#">查看购物车</a>
					</div>
				</div>
				<img src="imgs/border.gif" width="329" height="31" />
				<div id="about_our">
					<h2>
						<img src="imgs/bullet3.gif" width="26" height="25" />
						关于书店
					</h2>
					<div class="details clear">
						<img src="imgs/about.jpg" />
						<p>
							汇智科技公司关注IT教育培训市场的发展和变化，致力于在线教育，推进无纸化教学进程。窗内网（www.itzcn.com）结合软件开发的实际需求，发布了Flex、C#、Java、ASP.NET和JSP等系列视频教程。</p>
					</div>
				</div>
				<img src="imgs/border.gif" width="329" height="31" />
				<div id="promotions">
					<h2>
						<img src="imgs/bullet4.gif" width="26" height="25" />
						优惠图书
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
						图书分类
					</h2>
					<ul class="list">
						<li>
							<a href="#">三维动画</a>
						</li>
						<li>
							<a href="#">.NET技术</a>
						</li>
						<li>
							<a href="#">Java技术</a>
						</li>
						<li>
							<a href="#">PHP技术</a>
						</li>
						<li>
							<a href="#">其它语言</a>
						</li>
						<li>
							<a href="#">Web前端</a>
						</li>
						<li>
							<a href="#">数据库技术</a>
						</li>
						<li>
							<a href="#">基础应用</a>
						</li>
					</ul>
				</div>
				<div class="right_box">
					<h2>
						<img src="imgs/bullet6.gif" width="26" height="25" />
						友情链接
					</h2>
					<ul class="list">
						<li>
							<a href="#">窗内网</a>
						</li>
						<li>
							<a href="#">窗内论坛</a>
						</li>
						<li>
							<a href="#">Google搜索</a>
						</li>
						<li>
							<a href="#">百度搜索</a>
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
						<a href="#">首页</a>
					</li>
					<li>
						<a href="#">关于我们</a>
					</li>
					<li>
						<a href="#">服务</a>
					</li>
					<li>
						<a href="#">保密协议</a>
					</li>
					<li>
						<a href="#">联系我们</a>
					</li>
				</ul>
			</div>
			<img src="imgs/footer_bg.gif" />
		</div>
		<!-- ============= footer end ============= -->
	</div>
</body>
</html>
