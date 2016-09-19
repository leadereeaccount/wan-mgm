/// <reference path="jquery-1.11.1.min.js" />




$(function () {
					pagesize();
					window.onresize = pagesize;
					leftMenuListLiClick();
					leftMenuListTopClick();
				})
				var pagesize = function() {
					$("#main").height($(window).height() - $("#header").height());
					$("#pagemain").width($(window).width() - 220);
				}

				function leftMenuListLiClick() {
					$(".leftMenuListLi li").click(function() {
						$(".leftMenuListLi li").removeClass("leftMenuSelect");
						$(this).addClass("leftMenuSelect");
					})
				}

				function leftMenuListTopClick() {
					$(".leftMenuListTop").click(function() {
						var leftMenuListLiHeight = $(this).siblings(".leftMenuListLi").height();
						if ($(this).parent().hasClass("leftMenuListSelect")) {
							$(this).parent().animate({
								height: "35px"
							});
							$(this).parent().removeClass("leftMenuListSelect");
						} else {
							$(this).parent().animate({
								height: (leftMenuListLiHeight + 35) + "px"
							}).siblings().animate({
								height: "35px"
							});
							$(this).parent().siblings(".leftMenuList").removeClass("leftMenuListSelect");
							$(this).parent().addClass("leftMenuListSelect");
						}
					})
				}











				function SetLeftMenu(listselect,selectleft) {



				    $(".leftMenuList").each(function () {

				        if ($(this).find(".leftMenuListTop ul li").eq(1).text() == listselect)
				        {
				            var leftMenuListLiHeight = $(this).find(".leftMenuListTop").siblings(".leftMenuListLi").height();

				            $(this).height(leftMenuListLiHeight + 35 + "px");
				            
				            $(this).addClass("leftMenuListSelect");



				            $(this).find(".leftMenuListLi ul li").each(function () {

				                if ($(this).find("a span").text() == selectleft)
				                {
				                    $(this).addClass("leftMenuSelect");
				                }

				            })
                            



				        }


				    })




				}


