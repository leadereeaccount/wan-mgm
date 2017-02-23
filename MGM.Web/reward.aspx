<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reward.aspx.cs" Inherits="MGM.Web.reward" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>万达商户银柜 推荐好友送话费</title>
<link rel="stylesheet" type="text/css" href="css/style.css"/>
</head>
<body>
   
	<div class="reward">
		<img src="img/reward/rewardbg.jpg"/>
		
		
		<ul class="rewardul">
			<li><p><%= num %></p></li>
			<li><p><%= money %></p></li>
			<li><p><%= successnum %></p></li>
			<li><p><%=successmoney %></p></li>
		</ul>
		
		<p class="num"><%=recnum %></p>
		<p class="money"><%= recmoney %><span>元</span></p>
		
		
		<a href="index.aspx"><img src="img/reward/recommend.png"/></a>
		
		
		</div>
		
		
		
	
    <script src="js/jquery-1.11.1.min.js"></script>
     <script src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>
	
    <script>

         wx.config(<%= configstr%>);

        wx.ready(function () {

            wx.onMenuShareTimeline({
                title: '万达商户银柜推荐好友送话费', // 分享标题
                link: 'http://wanda-mgm.lewebsite.cn/index.aspx', // 分享链接
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
                title: '万达商户银柜推荐好友送话费', // 分享标题
                desc: '万达商户银柜推荐好友送话费', // 分享描述
                link: 'http://wanda-mgm.lewebsite.cn/index.aspx', // 分享链接
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
                title: '万达商户银柜推荐好友送话费', // 分享标题
                desc: '万达商户银柜推荐好友送话费', // 分享描述
                link: 'http://wanda-mgm.lewebsite.cn/index.aspx', // 分享链接
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
                title: '万达商户银柜推荐好友送话费', // 分享标题
                desc: '万达商户银柜推荐好友送话费', // 分享描述
                link: 'http://wanda-mgm.lewebsite.cn/index.aspx', // 分享链接
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