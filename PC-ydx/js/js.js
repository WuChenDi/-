
// 头部点击切换模块
$(document).ready(function(){
       $(".nav1").click(function(){
           $("iframe").attr("src","html/main.html")
           })
       $(".nav2").click(function(){
           $("iframe").attr("src","html/jy-Index.html");
           })
       $(".nav3").click(function(){
           $("iframe").attr("src","html/yx-3-1.html");
           })
        $(".nav4").click(function(){
           $("iframe").attr("src","html/yx-guangli4-1.html");
          
           })
        $(".nav5").click(function(){
           $("iframe").attr("src","html/hy-changyongfenzu5-1.html")
          })
        $(".nav6").click(function(){
           $("iframe").attr("src","html/pj-GoodEvaluate.html")
          })
        $(".nav7").click(function(){
           $("iframe").attr("src","html/sj-RFM_Model.html")
          })
        $(".nav8").click(function(){
           $("iframe").attr("src","html/my-OrderInquiry.html")
          })
      // 头部导航点击切换颜色背景
        $(".header_left li").click(function(){
          $(this).addClass("current").siblings().removeClass("current");;
        })

 })
  



$(function(){

 
// 头部导航
  $(".header_left li").click(function(){
    $(this).addClass("current").siblings().removeClass("current");;
  })
  $(".menu_btn,.menu_con>li span").click(function(){
    $('.TraderClock').toggleClass('f-left');
  });
$('.menu_con>li>a').click(function(e) {
    $(this).parent('.menu_con>li').find('ol').show().parent('.menu_con>li').siblings().find('ol').hide();
  });
 //菜单点击
$('.menu_con>li>a').click(function(e) {
    $(this).siblings("ol").toggle();
    $(this).parent('.menu_con>li').find('ol').show().parent('.menu_con>li').siblings().find('ol').hide();
 // $(this).parent().siblings().children("ol").css({"display":"none"});
  });

    // 首页main 左边轮播
;(function(){   
        //自动播放
        var timer = null;
        var num =0;
        function go(){    
            timer=setInterval(function(){   
                num++;                
                if(num>2){  
                    num=0;
                }
                $('.main_banner>ul').animate({left:-num*100+'%'})
                $('.main_banner .main_dot_con li').eq(num).addClass('main_cur').siblings().removeClass('main_cur');
            },3000)
        };
        go();
    //鼠标移上大的范围 all 停止自动播放
    //      鼠标移开继续播放
        $('.main_banner').hover(function(e) {
            clearInterval(timer);
        },function(){   
            clearInterval(timer);
            go()
        });
        //点击角标相应图片进行切换
        $('.main_dot_con li').click(function(e) {
          // console.log($(this).index());        
          $(this).addClass('main_cur').siblings().removeClass('main_cur');
            $('.main_banner>ul').stop().animate({left:-$(this).index()*100+'%'});
            num = $(this).index();
        });

    })();


// 下单提醒页面

 // 表格的开关按钮 checkbox
    $('.checkbox').click(function(){
      $(this).toggleClass('checkbox_on');
    })
 // 表格的开关按钮 radios
    $('.radios >input').click(function(){
      if ($(this).attr("checked")) {
          $(this).parent().addClass('radiosclick');
          $(this).parent().parent().siblings().children().removeClass('radiosclick');
      }
      
    })

//下单关怀配置》“编辑”》里面的弹窗
    $('.save_template').click(function(){
      $('.save_as_pop').show();
      $('.save_as_pop>.save_as_btn>input').click(function(){
        $('.save_as_pop').hide();
      })
    })
    
    $('.begin_testing').click(function(){
      $('.begin_testing_pop').show();
      $('.save_as_btn>input.know').click(function(){
        $('.begin_testing_pop').hide();
      });

    });


  // 新建提醒任务
    $('.btn_task>div').click(function(e) {
      $(this).addClass('cur').siblings().removeClass('cur');
    });

    $('.all_inform .hide').click(function(){
      $('.info_con').toggle();
      $('.all_inform').toggleClass('cur');
    })

// 下单关怀配置
    $('.remind_tip').click(function(){
      $(this).toggleClass("cur");
    })

//点击”新建提醒任务“弹出“下单关怀配置”
    $('.btn1').click(function (e) {
        $('.trader_r>div.order_care_config').stop().animate({"left":"200px"});
        $('.reveal-modal-bg').css({"display":"block"});
        $('html').css({"overflow-y":"hidden"});
        $('.page_navigation').hide();
        $('html,body').animate({scrollTop:0});
      // 点击保存或取消按钮，关闭下单关怀配置
        $('.save_all>input').click(function(){
          $('.order_care_config').stop().animate({"left":"1920px"});
          $('.reveal-modal-bg').css({"display":"none"})
          $('html').css({"overflow-y":"auto"});
          $('.page_navigation').show();
        });
      // 点击关闭下单关怀配置
        $('.config_close').click(function (e){
          $('.order_care_config').stop().animate({"left":"1920px"});
          $('.reveal-modal-bg').css({"display":"none"});
          $('html').css({"overflow-y":"auto"});
          $('.config_pop1').hide();
          $('.page_navigation').show();

        });

        // 点击删除产品
        $('.product .del').click(function(){
          $(this).parent('.product').css({"display":"none"});
        })

        // 点击 “继续添加” 之后
        $('.sms_template .add').click(function(){
          $('.add_pop').show();
          $('.config_pop1').show();  //8.11

          $(".add_goods").click(function(){
            $('<li><span class="thumbnail">'+$(this).children('a').html()+'</span><span class="goods_about"><p class="goods_name">苹果6S</p><p>http://tb.easyconcvbtdact.cn/...</p></span></li>').appendTo('.goods_lst');
          });

          $('.add_pop>.save_as_btn>input').click(function(){
            $('.add_pop').hide();
          })

        })
        // $(".add_goods").click(function(){
        //   $('<li><span class="thumbnail">'+$(this).children('a').html()+'</span><span class="goods_about"><p class="goods_name">苹果6S</p><p>http://tb.easyconcvbtdact.cn/...</p></span></li>').appendTo('.goods_lst');
        // });

        // 点击下单关怀配置 “编辑” 之后的弹出框
        $('.care_config_con1 .edit').click(function(){
          $('.care_config_con1').hide();
          $('.care_config_sms').show();
          $('.care_config_sms .sms_save>input').click(function(){
            $('.care_config_sms').hide();
            $('.care_config_con1').show();
          })
         
          // 下单关怀》短信内容编辑》模板选择
          $('#TemplateSelect').click(function(){
              $('.SmsTemplate').hide();
              $('.TemplateSelect_in').css({"display":"block"}).stop().animate({"left":"200px"});
              $('.order_care_config .order_care1').css({"display":"none"});
              $('.return').click(function(){
                  $('.TemplateSelect_in').css({"display":"none"}).stop().animate({"left":"1920px"});
                  $('.order_care_config .order_care1').css({"display":"block","left":"200px"});
              })
          });
        });

        $('.care_config_con2 .edit1').click(function(){
          $('.care_config_con2').hide();
          $('.care_config_basic').show();
          $('.care_config_basic .sms_save>input').click(function(){
            $('.care_config_basic').hide();
            $('.care_config_con2').show();
          });
        });
       
       $('.care_config_con3 .edit2').click(function(){
          $('.care_config_con3').hide();
          $('.care_config_high').show();
          $('.care_config_high .sms_save>input').click(function(){
            $('.care_config_high').hide();
            $('.care_config_con3').show();
          });
           //下单关怀配置》“编辑”》里面的弹窗
           // $('.custom').click(function(){
           //    $('.custom_pop').show();
           //  })
           //  $('.custom_pop>.save_as_btn>input').click(function(){
           //    $('.custom_pop').hide();
           //  })
            // $('.sms_template .add').click(function(){
            //   $('.add_pop').show();
            //   $('.config_pop').show();
            // })
            // $('.add_pop>.save_as_btn>input').click(function(){
            //   $('.add_pop').hide();
            // })
        });


       
        




    });
 
// 发货提醒 

     $('.template_select').click(function(){
        $('.TemplateSelect_in').css({"display":"block"}).stop().animate({"left":"200px"});
        $('.TemplateSelect_in_bg').show();
        $('.reveal-modal-bg').css({"display":"none"});
        $('.TemplateSelect_in .return').click(function(){
            $('.TemplateSelect_in').css({"display":"none"}).stop().animate({"left":"1920px"});
            $('.TemplateSelect_in_bg,.reveal-modal-bg').css({"display":"none"});
        })
    });


    $('.save_sms_template').click(function(){
      $('.save_as_pop,.reveal-modal-bg').show();
      $('.save_as_pop>.save_as_btn>input').click(function(){
        $('.save_as_pop,.reveal-modal-bg').hide();
      })
    })
    
    $('.begin_sms_testing').click(function(){
      $('.begin_testing_pop,.reveal-modal-bg').show();
      $('.save_as_btn>input.know').click(function(){
        $('.begin_testing_pop,.reveal-modal-bg').hide();
      });

    });

    $('.sms_template .add1').click(function(){
      $('.add_pop1').show();
      $('.save_as_pop').hide();
      $('.config_pop_bg').show();
      // 点击 “继续添加” 之后
      $(".add_pop1 .add_goods").click(function(){
        $('<li><span class="thumbnail">'+$(this).children('a').html()+'</span><span class="goods_about"><p class="goods_name">苹果6S</p><p>http://tb.easyconcvbtdact.cn/...</p></span></li>').appendTo('.goods_lst');
      });
      $('.add_pop>.save_as_btn>input').click(function(){
        $('.add_pop1').hide();
      })
      $('.save_as_btn1 >input').click(function(){
        $('.add_pop,.reveal-modal-bg').hide();
        $('.product1').show();
        $('.add1').hide();
      })
    })
    $('.product1 .del').click(function(){
      $(this).parent('.product1').css({"display":"none"});
      $('.add1').show();
    })



    $('.edit_goods').click(function(){
        $('.edit_goods_pop,.reveal-modal-bg').show();
        $('.template_select').click(function(){
          $('.return').hide();
          $('.return1').show();
          $('.reveal-modal-bg').show();
          $('.edit_goods_pop').hide();
          $('.TemplateSelect_in').css({"display":"block"}).stop().animate({"left":"200px"});
          $('.TemplateSelect_in .return1').click(function(){
              $('.TemplateSelect_in').css({"display":"none"}).stop().animate({"left":"1920px"});
              $('.edit_goods_pop').show();
          });
        });
        $('.edit_con_select').click(function(){
          $('.return').hide();
          $('.return1').show();
          $('.reveal-modal-bg').show();
          $('.edit_goods_pop').hide();
          $('.TemplateSelect_in').css({"display":"block"}).stop().animate({"left":"200px"});
          $('.TemplateSelect_in .return1').click(function(){
              $('.TemplateSelect_in').css({"display":"none"}).stop().animate({"left":"1920px"});
              $('.edit_goods_pop').show();
          });
        });
        $('.edit_goods_pop .sms_save >input').click(function(){
        $('.edit_goods_pop,.reveal-modal-bg').hide();

        })
    })

    $('.care_config_con1 .sms_edit1').click(function(){
      $('.send_good_config').hide();
      $('.care_config_sms').show();
      $('.care_config_sms .sms_save>input').click(function(){
        $('.care_config_sms').hide();
        $('.send_good_config').show();
      })
    })

    $('.basic_edit').click(function(){
      $('.config_basic').hide();
      $('.basic_send_time').show();
      $('.basic_send_time .sms_save>input').click(function(){
        $('.basic_send_time').hide();
        $('.config_basic').show();
      })
    })
   
    
     
    

   $('.custom').click(function(){
      $('.custom_pop').show();
    })
    $('.custom_pop>.save_as_btn>input').click(function(){
      $('.custom_pop').hide();
    })

// 点击删除产品
    $('.product .del').click(function(){
      $(this).parent('.product').css({"display":"none"});
    })

    


  // 短信模板管理》新建短信模板
  $('.create_template').click(function(){
    $('.SmsTemplate_config').stop().show().animate({"left":"200px"});
    $('.reveal-modal-bg').stop().show();
    $('.config_close,.SmsTemplate_config .sms_save>input').click(function(){
      $('.SmsTemplate_config').stop().animate({"left":"1920px"}).hide("normal");
      $('.reveal-modal-bg').stop().hide();
    })
  })
    
// 营销管理页面
// 短信营销
$('.sms-setting-a').click(function(){
  $('.through-b-con').hide();
  $('.through-b-set').show();
  $('.through-b-set a.lijiup').click(function(){
    $('.through-b-con').show();
    $('.through-b-set').hide();
  })
})

$('.specified_a').click(function(){
  $('.specified').hide();
  $('.through-b-edit').show();
  $('.through-b-edit .sms_save>input').click(function(){
    $('.specified').show();
    $('.through-b-edit').hide();
  })
})

$('.group-setting-a').click(function(){
  $('.group-setting-con').hide();
  $('.through-b-group').show();
  $('.through-b-group .sms_save>input').click(function(){
    $('.group-setting-con').show();
    $('.through-b-group').hide();
  })
})

$('.control_group').click(function(){
  $('.begin_testing_pop,.reveal-modal-bg').show();
  $('.begin_testing_pop .sms_save>input').click(function(){
    $('.begin_testing_pop,.reveal-modal-bg').hide();
  })
})

// 邮件高级营销
// 邮件编辑点击切换背景图
$('.email_template_ul>li>div').click(function(){

  var src = $(this).find('img').prop("src");
  console.log($(this).children('img'));
  $('#img_bg').prop("src",src);
})


// 手动订单提醒》弹窗
 $('.custom1').click(function(){
    $('.custom_pop1').show();
    $('.reveal-modal-bg').css({"display":"block"})
  })

  $('.custom_pop1 .save_as_btn>input,.custom_pop1 .close_this').click(function(){
    $('.custom_pop1').hide();
    $('.reveal-modal-bg').css({"display":"none"})

  })

   $('.tmplate_a1').click(function(){
      $('#myModal5').show();
      $('.save_as_pop .save_as_btn>input,.save_as_pop .close_this').click(function(){
        $('#myModal5').hide();
        $('.reveal-modal-bg').css({"display":"none"})

      })
    })

   $('.tmplate_a2').click(function(){
      $('#myModal6').show();
      $('.save_as_pop .save_as_btn>input,.save_as_pop .close_this').click(function(){
        $('#myModal6').hide();
        $('.reveal-modal-bg').css({"display":"none"})

      })
    })

   $('.tmplate_a3').click(function(){
      $('#myModal7').show();
      $('.save_as_pop .save_as_btn>input,.save_as_pop .close_this').click(function(){
        $('#myModal7').hide();
        $('.reveal-modal-bg').css({"display":"none"});

      })
    })

})

    $('.orgin>ul>li').click(function(){
      $(this).toggleClass("cur");
    })
    $('.state ul>li').click(function(){
      $(this).toggleClass("cur");
    })

    // 会员管理》常用分组
     $('.Common_group_pop').click(function(){
        $('.Common_group_province').css({"display":"block"});
        $(this).siblings('p').click(function(){
          $('.Common_group_province').css({"display":"none"});
        })
      })
     $('.decide_show').click(function(){
        $(this).siblings('.show_hide').css({"display":"block"});
        $(this).siblings('p').click(function(){
          $(this).siblings('.show_hide').css({"display":"none"});
        })
      })


;(function(){
  //tab栏切换
  $(function(){
    $('.tab_menu1').click(function(){
      $(this).addClass('cur').siblings().removeClass('cur');
      $('.tab_a').show();
      $('.tab_b').hide();
      $('.tab_c').hide();
    })
    $('.tab_menu2').click(function(){
      $(this).addClass('cur').siblings().removeClass('cur');
      $('.tab_a').hide();
      $('.tab_b').show();
      $('.tab_c').hide();
    })
    $('.tab_menu3').click(function(){
      $(this).addClass('cur').siblings().removeClass('cur');
      $('.tab_a').hide();
      $('.tab_b').hide();
      $('.tab_c').show();
    })
  })
})();


// 首页左侧的进度条
$(function(){
  var i =0; 
  var j =0; 
  var ms = 1000; //变量MS: 从0%到100%需要的毫秒数
  var time = setInterval(function(){
    $(".dial .dial_con").css("width",i+"%");i=i+(1000/ms); 
    $(".dial .dial_num").text(Math.round(i)+"%")
    if(i>75){
    clearInterval(time);
    $(".dial .dial_num").text("75%") 
  }},10); 

  var time1 = setInterval(function(){
    $(".dial2 .dial_con").css("width",j+"%");j=j+(1000/ms); 
    $(".dial2 .dial_num").text(Math.round(j)+"%")
    if(j>50){
    clearInterval(time1);
    $(".dial2 .dial_num").text("50%") 
  }},10); 
});

/*插件代码*/
$(function(){
// tab插件
(function ($) {
  $.fn.setTab = function () {
    var getTab=$(this),//this指向调用函数的ID
      panels = getTab.children(".tab_ul").children("li"),
      tabs = getTab.find(".h2_span");
 
    return this.each(function(){
      $(tabs).click(function(e) {
        var index = $.inArray(this, $(this).parent().find(".h2_span"));//this指向span
        if (panels.eq(index)[0]) {
          $(tabs).removeClass("cur");
          $(this).addClass("cur");
          panels.css("display", "none").eq(index).css("display", "block");
        }
      });
       
    });
 }
})(jQuery);


      // tab栏点击切换事件
      $("#tab1").setTab();//下单关怀页面的tab栏
      $("#tab2").setTab();//模版选择页面的tab栏
      $("#tab3").setTab();//短信模板管理页面的tab栏
      $("#tab4").setTab();//发货提醒页面的tab栏
      $("#tab5").setTab();//发货提醒页面的tab栏
      $("#tab6").setTab();//会员列表弹窗页面的tab栏
})




// textarea输入相应显示到右边的手机
function SwapTxt()
  {
      var txt = document.getElementById("mysms").value;
      document.getElementById("mysmsTo").innerHTML=txt;
  }



