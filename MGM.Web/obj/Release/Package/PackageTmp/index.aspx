<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MGM.Web.index" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>万达商户银柜 推荐好友送话费</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body>
    <div class="indexbody">
        <img src="img/index/indexbg.jpg" />

        <a href="remark.aspx" class="btnindex">
            <img src="img/index/indexbtn1.png" /></a>
        <a href="telfind.aspx" class="btnindex">
            <img src="img/index/indexbtn2.png" /></a>
        <a onclick="ClickDetail()" class="detail">
            <p>点击了解商户银柜产品详情</p>
        </a>
    </div>



    <script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>
    <script src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>

    <script type="text/javascript">




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



        function ClickDetail() {

            $.post("/Tools/Lookdetail.ashx", {}, function (data) {
                location.href = "http://wandayingui.lewebsite.cn/";
            }, "text");
        }

    </script>

</body>
</html>
