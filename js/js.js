//case banner
$(function() {
	$("#temp2").Slide({
		effect: "scroolX",
		speed: "normal",
		timer: 3000
	});

	$("#temp4").Slide({
		effect: "scroolLoop",
		autoPlay: true,
		speed: "normal",
		timer: 3000,
		steps: 1
	});
	$("#temp41").Slide({
		effect: "scroolLoop",
		autoPlay: true,
		speed: "normal",
		timer: 3000,
		steps: 1
	});
	$("#temp42").Slide({
		effect: "scroolLoop",
		autoPlay: true,
		speed: "normal",
		timer: 3000,
		steps: 1
	});
	$("#temp43").Slide({
		effect: "scroolLoop",
		autoPlay: true,
		speed: "normal",
		timer: 3000,
		steps: 1
	});
	$("#temp44").Slide({
		effect: "scroolLoop",
		autoPlay: true,
		speed: "normal",
		timer: 3000,
		steps: 1
	});
	$("#temp45").Slide({
		effect: "scroolLoop",
		autoPlay: true,
		speed: "normal",
		timer: 3000,
		steps: 1
	});

	$("#temp8").Slide({
		effect: "scroolLoop",
		autoPlay: false,
		speed: "normal",
		timer: 3000,
		steps: 1
	});

	$("#temp5").Slide({
		effect: "scroolTxt",
		speed: "normal",
		timer: 3000,
		steps: 1
	});
	// 在线客服
	$('.server_wc').hover(function(e) {
		$('.server_wc div').css("display", "block");
	}, function() {
		$('.server_wc div').css("display", "none");
	});

	$('.server_online').click(function(e) {
		$(".server_r").toggle()
	});
	// 产品中心
	$('.product_nav h2 span').click(function(e) {
		$(this).attr('class', 'cur').siblings().attr('class', '');
		$('.product_nav .product_img li').eq($(this).index()).attr('class', 'cur').siblings().attr('class', '');
	});
	// 走进雅泽光
	$(function() {
		$('.about_all li').hover(function(e) {
			//最后改图
			var huode = $(this).children().attr('href');
			$('.about_big').css({
				background: 'url(' + huode + ')'
			})

			$('.about_big').show(300);
			$('.about_big').css({
				left: e.pageX + 20,
				top: e.pageY + 20
			})

		}, function() {
			$('.about_big').hide();
		});

		$('.about_all li').mousemove(function(e) {
			$('.about_big').css({
				left: e.pageX + 20,
				top: e.pageY + 20
			})
		});

	})
	// 新闻news
	$('.news_yzg').click(function() {
		$('.news_yzg').addClass('cur')
		$('.news_hy').removeClass('cur')
		$('.news_con2').css({
			display: 'none',
		});
		$('.news_con1').css({
			display: 'block',
		});

	})
	$('.news_hy').click(function() {
		$('.news_hy').addClass('cur')
		$('.news_yzg').removeClass('cur')
		$('.news_con2').css({
			display: 'block',
		});
		$('.news_con1').css({
			display: 'none',
		});
	})

	// 十二年专注
	$('.focus_con span').mouseenter(function(e) {
		$(this).children('p').stop().animate({
			"top": "0px"
		});
	}).mouseleave(function() {
		$(this).children('p').stop().animate({
			"top": "448px"
		});
	});

	// 客户案例
	$('.case_btn>span').click(function() {
		$(this).attr('class', 'cur').siblings().attr('class', '');
		$('.case_main .case_img>li').eq($(this).index()).show().siblings().hide();
	});
});

// 首页轮播banner
;
(function() {
	//自动播放
	var timer = null;
	var num = 0;

	function autoplay() {
		timer = setInterval(function() {
			num++;
			if(num > 2) {
				num = 0;
			}
			$('.banner ul').animate({
				left: -num * 100 + '%'
			})
			$('.banner .dot_con li').eq(num).addClass('cur').siblings().removeClass('cur');
		}, 3000)
	};
	autoplay()
	//鼠标移上大的范围 all 停止自动播放
	//      鼠标移开继续播放
	$('.banner').hover(function(e) {
		clearInterval(timer);
	}, function() {
		clearInterval(timer);
		autoplay()
	});
	//移上角标相应图片进行切换
	$('.banner ol li').click(function(e) {
		$(this).addClass('cur').siblings().removeClass('cur');
		$('.banner ul').stop().animate({
			left: -$(this).index() * 100 + '%'
		});
		num = $(this).index();
	});
})();
// team 左边轮播
;
(function() {
	//自动播放
	var timer = null;
	var num = 0;

	function go() {
		timer = setInterval(function() {
			num++;
			if(num > 2) {
				num = 0;
			}
			$('.team_banner ul').animate({
				left: -num * 100 + '%'
			})
			$('.team_banner .team_dot_con li').eq(num).addClass('team_cur').siblings().removeClass('team_cur');
		}, 3000)
	};
	go()
	//鼠标移上大的范围 all 停止自动播放
	//      鼠标移开继续播放
	$('.team_banner').hover(function(e) {
		clearInterval(timer);
	}, function() {
		clearInterval(timer);
		go()
	});
	//移上角标相应图片进行切换
	$('.team_banner ol li').click(function(e) {
		$(this).addClass('team_cur').siblings().removeClass('team_cur');
		$('.team_banner ul').stop().animate({
			left: -$(this).index() * 100 + '%'
		});
		num = $(this).index();
	});

})();

// team 中间无缝滚动
;
(function() {
	//自动播放
	var timer = null;
	var num = 0;

	function go() {
		timer = setInterval(function() {
			num += 2;
			if(num > 676) {
				num = 0;
			}
			$('.all ul').css({
				left: -num
			})
			$('.all ul').delay(2000)
		}, 30)
	};
	go();
	//鼠标移上，鼠标移出
	$('.all').hover(function(e) {
		clearInterval(timer)
	}, function() {
		clearInterval(timer);
		go();
	});
	//突出显示
	$('.all li').hover(function(e) {
		$(this).siblings().stop().fadeTo(300, 0.4);
	}, function() {
		$('.all li').stop().fadeTo(300, 1);
	});

})();

// case 右边无缝滚动
;
(function() {
	//自动播放
	var timer = null;
	var num = 0;

	function go() {
		timer = setInterval(function() {
			num += 1;
			if(num > 576) {
				num = 0;
			}
			$('.case_logo ul').css({
				top: -num
			})
			$('.case_logo ul').delay(2000)
		}, 30)
	};
	go();
	//鼠标移上，鼠标移出
	$('.case_logo').hover(function(e) {
		clearInterval(timer)
	}, function() {
		clearInterval(timer);
		go();
	});
	//突出显示
	$('.case_logo li').hover(function(e) {
		$(this).siblings().stop().fadeTo(300, 0.4);
	}, function() {
		$('.case_logo li').stop().fadeTo(300, 1);
	});

})();

// news 右边无缝滚动
;
(function() {
	//自动播放
	var timer = null;
	var num = 0;

	function go() {
		timer = setInterval(function() {
			num += 1;
			if(num > 804) {
				num = 0;
			}
			$('.news_con_r ul').css({
				top: -num
			})
			$('.news_con_r ul').delay(2000)
		}, 30)
	};
	go();
	//鼠标移上，鼠标移出
	$('.news_con_r').hover(function(e) {
		clearInterval(timer)
	}, function() {
		clearInterval(timer);
		go();
	});
	//突出显示
	$('.news_con_r li').hover(function(e) {
		$(this).siblings().stop().fadeTo(300, 0.4);
	}, function() {
		$('.news_con_r li').stop().fadeTo(300, 1);
	});

})();