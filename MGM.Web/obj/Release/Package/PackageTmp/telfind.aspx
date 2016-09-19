<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="telfind.aspx.cs" Inherits="MGM.Web.telfind" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>万达网络信贷</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body class="telfind">
    <div class="ceshi">
            <p>内部测试，请勿外发</p>
        </div>
    <div class="telfindbody">
        <p>请输入您的手机号码</p>
        <input type="tel" name="txttel" id="txttel" value="" />
        <a onclick="BtnClick()">
            <img src="img/telfind/btnOkbg.png" /></a>

          <p class="tfremark">1、您可以填写您的手机号码，查询成功推荐人数及成功放款人数，了解当前所获奖励情况。</p>
          <p class="tfremark">2、审批信息可能会有延迟，如奖励数据还未更新请您耐心等待。</p>
         <p class="tfremark">3、成功放款后，您和被推荐人都将收到提示短信，请注意查收。</p>
        
    </div>


    <div class="showbox">

        <div class="showerror">
            <p>查询失败</p>
            <p>您还未成功推荐好友或者您的推荐信息还在路上请稍后查询</p>
            <a href="javascript:void(0)" onclick="CloseShowbox()">
            <img src="img/reward/quding.png" /></a>
          

        </div>


    </div>



    <script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>

    <script type="text/javascript">

        $(function () {

            $("body.telfind .telfindbody").height($(window).height() * 0.8);
            $(".showbox").height($(window).height());
        })

        function BtnClick() {

            var phone = $("#txttel").val();
            $.post("/Tools/CheckPhone.ashx", { phone: phone }, function (data) {

                if (data.status == "y") {
                    location.href = "reward.aspx?phone=" + phone;
                }
                else {
                    $(".showbox .showerror p").eq(1).text(data.info);

                    $(".showbox").show().animate({ "opacity": "1" }, 300, function () {
                        $(".showbox .showerror").show().animate({ "opacity": "1" }, 300);

                    })
                }

            }, "json");
            



        }
        
        
        


        function CloseShowbox() {
            $(".showbox .showerror").stop().animate({ "opacity": "0" }, 300, function () {
                $(".showbox .showerror").hide();
                $(".showbox").stop().animate({ "opacity": "0" }, 300, function () {
                    $(".showbox").hide();
                });

            })
        }

    </script>


</body>
</html>
