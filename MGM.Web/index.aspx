<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MGM.Web.index" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>万达网络信贷</title>
<link rel="stylesheet" type="text/css" href="css/style.css"/>
</head>
<body>
	<div class="indexbody">
		<img src="img/index/indexbg.jpg"/>
		
		<a href="remark.aspx" class="btnindex"><img src="img/index/indexbtn1.png"/></a>
		<a href="telfind.aspx" class="btnindex"><img src="img/index/indexbtn2.png"/></a>
        <a onclick="ClickDetail()" class="detail"><p>点击了解商户银柜产品详情</p></a>
	</div>

     <div class="ceshi">
            <p>内部测试，请勿外发</p>
        </div>


    <script src="js/jquery-1.11.1.min.js"></script>
    <script>
        function ClickDetail() {

            $.post("/Tools/Lookdetail.ashx", {}, function (data) {
                location.href = "http://wandayingui.lewebsite.cn/";
            }, "text");
        }

    </script>

</body>
</html>