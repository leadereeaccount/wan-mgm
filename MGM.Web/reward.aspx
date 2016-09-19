<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reward.aspx.cs" Inherits="MGM.Web.reward" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>万达网络信贷</title>
<link rel="stylesheet" type="text/css" href="css/style.css"/>
</head>
<body>
    <div class="ceshi">
            <p>内部测试，请勿外发</p>
        </div>
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
		
		
		
	



	
</body>
</html>