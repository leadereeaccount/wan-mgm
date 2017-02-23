<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Caifu.index" %>

<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no" />
		<title></title>
		<link rel="stylesheet" type="text/css" href="css/style.css"/>
	</head>
	<body>
		<img src="img/indexbg.jpg"/>
		
		<a href="https://wandapromotion.lewebsite.cn/register.aspx?num=697B7324422573F7AC3FCEB77FEF2DC0FE4BD642673155EC"><img src="img/btnimg.png"/></a>
		  <script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script><script src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>
    <script type="text/javascript">


          wx.config(<%= configstr%>);

        wx.ready(function () {

            wx.onMenuShareTimeline({
                title: '万达财富', // 分享标题
                link: 'http://caifu.lewebsite.cn/index.aspx', // 分享链接
                imgUrl: 'http://caifu.lewebsite.cn/img/shareimgico.jpg', // 分享图标
                success: function () {
                    // 用户确认分享后执行的回调函数
                
                },
                cancel: function () {
                    // 用户取消分享后执行的回调函数
                }
            });

            wx.onMenuShareAppMessage({
                title: '万达财富', // 分享标题
                desc: '为个人和企业提供全方位的金融服务', // 分享描述
                link: 'http://caifu.lewebsite.cn/index.aspx', // 分享链接
                imgUrl: 'http://caifu.lewebsite.cn/img/shareimgico.jpg', // 分享图标
                type: '', // 分享类型,music、video或link，不填默认为link
                dataUrl: '', // 如果type是music或video，则要提供数据链接，默认为空
                success: function () {
                    // 用户确认分享后执行的回调函数
                
                },
                cancel: function () {
                    // 用户取消分享后执行的回调函数
                }
            });

            wx.onMenuShareQQ({
                title: '万达财富', // 分享标题
                desc: '为个人和企业提供全方位的金融服务', // 分享描述
                link: 'http://caifu.lewebsite.cn/index.aspx', // 分享链接
                imgUrl: 'http://caifu.lewebsite.cn/img/shareimgico.jpg', // 分享图标
                success: function () {
                    // 用户确认分享后执行的回调函数
                 
                },
                cancel: function () {
                    // 用户取消分享后执行的回调函数
                }
            });
            wx.onMenuShareWeibo({
                title: '万达财富', // 分享标题
                desc: '为个人和企业提供全方位的金融服务', // 分享描述
                link: 'http://caifu.lewebsite.cn/index.aspx', // 分享链接
                imgUrl: 'http://caifu.lewebsite.cn/img/shareimgico.jpg', // 分享图标
                success: function () {
                    // 用户确认分享后执行的回调函数
                   
                },
                cancel: function () {
                    // 用户取消分享后执行的回调函数
                }
            });
        })



    </script>
	</body>
</html>
