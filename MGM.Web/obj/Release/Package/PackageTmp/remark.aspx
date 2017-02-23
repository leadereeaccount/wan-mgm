<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="remark.aspx.cs" Inherits="MGM.Web.remark" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>万达商户银柜 推荐新户送话费</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body>
   
    <div class="remarkbody1">
        <img src="img/remark/remarkbg1.jpg" />
        <a onclick="OpenShare()">
            <img src="img/remark/remarkbtn1.png" /></a>
        <div class="remarkdetail">
            <p>活动细则<span><img src="img/remark/detailico.png" /></span></p>
        </div>
    </div>


    <div class="remarkbody2">
        <img src="img/remark/remarkbg2.jpg" />
        <a onclick="OpenShare()">
            <img src="img/remark/remarkbtn1.png" /></a>
    </div>


    <div class="showbox">
        <div class="showshare">
            <img src="img/remark/shareimg.png" />
            <a onclick="CloseShare()">
                <img src="img/reward/quding.png" /></a>
        </div>

        <img src="img/remark/shareico.png" />

    </div>



    <script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>
    <script src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>
    <script type="text/javascript">
        $(function () {
            $(".showbox").height($(window).height());
            $(".remarkdetail").click(function () {
                if ($(".remarkbody2").height() > 0) {
                    $(".remarkbody2").stop().animate({ "height": "0px" }, 500)
                }
                else {
                    var scrollTop1 = parseInt($(window).scrollTop()) + 300;
                    $("html,body").animate({ "scrollTop": scrollTop1 + "px" }, 300)
                    $(".remarkbody2").stop().animate({ "height": $(".remarkbody2 img").height() + "px" }, 500, function () {

                    })
                }
            })

        })
        function OpenShare() {

            $(".showbox").show().stop().animate({ "opacity": "1" }, 500);
        }
        function CloseShare() {

            $(".showbox").stop().animate({ "opacity": "0" }, 500, function () {

                $(".showbox").hide();

            });
        }

        wx.config(<%= configstr%>);

		wx.ready(function () {

		    wx.onMenuShareTimeline({
		        title: '立即申请商户银柜贷款', // 分享标题
		        link: 'http://wanda-mgm.lewebsite.cn/message.aspx', // 分享链接
		        imgUrl: 'http://wanda-mgm.lewebsite.cn/img/remark/shareimgico.jpg', // 分享图标
		        success: function () {
		            // 用户确认分享后执行的回调函数
		            ShareClick();
		        },
		        cancel: function () {
		            // 用户取消分享后执行的回调函数
		        }
		    });

		    wx.onMenuShareAppMessage({
		        title: '立即申请商户银柜贷款', // 分享标题
		        desc: '立即申请商户银柜贷款', // 分享描述
		        link: 'http://wanda-mgm.lewebsite.cn/message.aspx', // 分享链接
		        imgUrl: 'http://wanda-mgm.lewebsite.cn/img/remark/shareimgico.jpg', // 分享图标
		        type: '', // 分享类型,music、video或link，不填默认为link
		        dataUrl: '', // 如果type是music或video，则要提供数据链接，默认为空
		        success: function () {
		            // 用户确认分享后执行的回调函数
		            ShareClick();
		        },
		        cancel: function () {
		            // 用户取消分享后执行的回调函数
		        }
		    });

		    wx.onMenuShareQQ({
		        title: '立即申请商户银柜贷款', // 分享标题
		        desc: '立即申请商户银柜贷款', // 分享描述
		        link: 'http://wanda-mgm.lewebsite.cn/message.aspx', // 分享链接
		        imgUrl: 'http://wanda-mgm.lewebsite.cn/img/remark/shareimgico.jpg', // 分享图标
		        success: function () {
		            // 用户确认分享后执行的回调函数
		            ShareClick();
		        },
		        cancel: function () {
		            // 用户取消分享后执行的回调函数
		        }
		    });
		    wx.onMenuShareWeibo({
		        title: '立即申请商户银柜贷款', // 分享标题
		        desc: '立即申请商户银柜贷款', // 分享描述
		        link: 'http://wanda-mgm.lewebsite.cn/message.aspx', // 分享链接
		        imgUrl: 'http://wanda-mgm.lewebsite.cn/img/remark/shareimgico.jpg', // 分享图标
		        success: function () {
		            // 用户确认分享后执行的回调函数
		            ShareClick();
		        },
		        cancel: function () {
		            // 用户取消分享后执行的回调函数
		        }
		    });
		})



		function ShareClick() {

		    $.post("/Tools/ShareNum.ashx", {}, function (data) {
		    }, "text")
		}



    </script>

</body>
</html>
