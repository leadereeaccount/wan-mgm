<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Yingui.index" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>商户银柜-万达广场商户个人专享</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body>
    <div class="indextop">
        <img src="img/img1.jpg" />

        <a class="detail"><p>查看详情</p></a>


    </div>

    <div class="indexbottom">
        <img src="img/img2.jpg" />
    </div>



    <script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script><script src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>
    <script type="text/javascript">
        $(function () {

            $(".detail").click(function () {


                if ($(".indexbottom").height() > 0) {
                    $(".indexbottom").stop().animate({ "height": "0px" }, 500)
                }
                else {
                    var scrollTop1 = parseInt($(window).scrollTop()) + 300;
                    $("html,body").animate({ "scrollTop": scrollTop1 + "px" }, 300)
                    $(".indexbottom").stop().animate({ "height": $(".indexbottom img").height() + "px" }, 500, function () {

                    })
                }
            })

        })

          wx.config(<%= configstr%>);

        wx.ready(function () {

            wx.onMenuShareTimeline({
                title: '商户银柜-万达广场商户个人专享', // 分享标题
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
                title: '商户银柜-万达广场商户个人专享', // 分享标题
                desc: '商户银柜-万达广场商户个人专享', // 分享描述
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
                title: '商户银柜-万达广场商户个人专享', // 分享标题
                desc: '商户银柜-万达广场商户个人专享', // 分享描述
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
                title: '商户银柜-万达广场商户个人专享', // 分享标题
                desc: '商户银柜-万达广场商户个人专享', // 分享描述
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