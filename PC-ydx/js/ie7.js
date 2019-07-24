$('#main').css({"overflow-x":"scroll"});
$(function(){
	$('.menu_btn').click(function(){
		if($('.TraderClock').hasClass('f-left')){
			$('.trader_r').css({"width":"97%"});
		}else{
			$('.trader_r').css({"width":"90%"});
		}
	})
	
});
// $(function(){
// 	$('.menu_btn').click(function(){
// 		var w = parseInt($('.menu').width());
// 		if(w < 60){
// 			$('.trader_r').css({"width":"97%"});
// 			// alert(w);
// 		}else{
// 			$('.trader_r').css({"width":"90%"});
// 			// alert(w);
// 		}
// 	})
	
// });