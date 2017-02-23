<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="MGM.Web.message" %>

<!DOCTYPE html>
<html>

	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
		<title>万达网络信贷</title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
	</head>

	<body class="message">

        
        <div class="messagelogo">
              <img src="img/message/logoimg.png" />
        </div>
      



		<form id="myForm" method="post" action="/Tools/AddOrder.ashx" enctype="multipart/form-data">
			<div class="messagebody">
				<img src="img/message/messagetopimg.png" />

                <a onclick="ClickDetail()" class="btndetail"><img src="img/message/btndetailbg.png" /></a>

				<p class="title">请填写您的信息</p>

				<ul class="input-group">
					<li class="name">
						<p><span><img src="img/message/nameico.png"/></span><span>姓名</span></p>
					</li>
					<li class="inputtext"><input type="text" id="txtname" name="txtname" datatype="*" value="" /></li>
				</ul>
				<ul class="input-group">
					<li class="name">
						<p><span><img src="img/message/telico1.png"/></span><span>手机</span></p>
					</li>
					<li class="inputtext"><input type="text" id="txtPhone" name="txtPhone" datatype="phone" value="" /></li>
				</ul>
				<ul class="input-group">
					<li class="name">
						<p><span><img src="img/message/cardIdico.png"/></span><span>身份证号</span></p>
					</li>
					<li class="inputtext"><input type="text" id="txtCardNum" datatype="num18" name="txtCardNum" value="" /></li>
				</ul>
				<ul class="input-group">
					<li class="name">
						<p><span><img src="img/message/zhizhaoico.png"/></span><span>营业执照号码</span></p>
					</li>
                    <li class="inputtext"><input type="text" id="txtZhizhao" datatype="*" name="txtZhizhao" value="" placeholder="仅用于客户身份核实" /></li>
					<li class="img"><p>填写营业执照号码，这些信息您可以在营业执照右上角找到。新版执照为<span>统一社会信用代码</span>，旧版执照为<span>注册号。</span></p></li>
					
				</ul>
				<ul class="input-group">
					<li class="name">
						<p><span><img src="img/message/recnameico.png"/></span><span>推荐人姓名</span></p>
					</li>
					<li class="inputtext"><input type="text" id="txtRecName" datatype="*" name="txtRecName" value="" /></li>
				</ul>
				<ul class="input-group">
					<li class="name">
						<p><span><img src="img/message/telico1.png"/></span><span>手机</span></p>
					</li>
					<li class="inputtext"><input type="text" id="txtRecPhone" datatype="phone" name="txtRecPhone" value="" /></li>
				</ul>

				<input type="submit" name="btnOk" id="btnOk" class="btnOk" value="" />

			</div>

		</form>
		
		
		
		<div class="showbox">
			
			<div class="showsuccess">
				<p>提交成功</p>
				<p>您的信息已经提交成功</p>
				<img src="img/reward/appewmimg.jpg"/>
				<p>下载APP贷款</p>
				<p>贷款审批需要一定时间，如安装注册APP后暂无法申请贷款，请您耐心等待。</p>
				<p>您也可以推荐您的好友申请</p>
				<a href="index.aspx"><img src="img/reward/recommend1.png"/></a>
			</div>
						
			<div class="showerror">
				<p>提交失败</p>
				<p>您已经申请过该产品，请勿重复提交信息！</p>
				<a href="javascript:void(0)" onclick="CloseShowbox()"><img src="img/reward/quding.png"/></a>
			</div>
			
			
		</div>
		
		
		
		
		<script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>
		<script src="js/Validform_v5.3.2.js" type="text/javascript" charset="utf-8"></script>
		<script type="text/javascript">
			$(function() {

				$("#myForm").Validform({
					tiptype: function(msg, o, cssctl) {
						if(!o.obj.is("form")) { 
							var objtip = o.obj.parents(".input-group");
							if(o.type == 2) {
								objtip.removeClass("input-group-error").addClass("input-group-success");
							} else if(o.type == 3) {
								objtip.removeClass("input-group-success").addClass("input-group-error");
							} 
						} else {
							var objtip = o.obj.parents(".input_group").find(".input_message");
							objtip.text(msg);
						}
					},
					datatype: {
					    "num18": /^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$/,
					    "phone": /^1\d{10}$/
					}, postonce: true,
					ajaxPost: true,
					callback: function (data) {

					    if (data.status == "y") {

					        $(".showbox").show().animate({ "opacity": "1" }, 300, function () {
					            $(".showbox .showsuccess").show().animate({ "opacity": "1" }, 300);

					        })
					    }
					    else if (data.status == "n") {
					        $(".showbox .showerror p").eq(1).text(data.info);

					        $(".showbox").show().animate({ "opacity": "1" }, 300, function () {
					            $(".showbox .showerror").show().animate({ "opacity": "1" }, 300);

					        })
					    }
					}

				});
				
				
				
				$(".showbox").height($(window).height());
				
				

			})

			function CloseShowbox() {
			    $(".showbox .showerror").stop().animate({ "opacity": "0" }, 300, function () {
			        $(".showbox .showerror").hide();
			        $(".showbox").stop().animate({ "opacity": "0" }, 300, function () {
			            $(".showbox").hide();
			        });

			    })
			}
			function ClickDetail() {

			    $.post("/Tools/Lookdetail.ashx", {}, function (data) { location.href = "http://wandayingui.lewebsite.cn/" }, "text");
			}
		</script>

	</body>

</html>