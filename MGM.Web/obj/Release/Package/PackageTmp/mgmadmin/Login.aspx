<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MGM.Web.mgmadmin.Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>领意文化管理系统平台</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body id="loginBody">
    <form runat="server" id="myForm">
        <div id="loginHeader">
            <div class="loginHeaderLeft">
                <ul>
                    <li>
                        <img src="img/temp/login_small.png" /></li>
                    <li>欢迎登录领意文化管理系统平台</li>
                </ul>
            </div>
            <div class="loginHeaderRight">
                <ul>
                    <li><a href="#">回首页</a></li>
                    <li><a href="#">帮助</a></li>
                    <li><a href="#">关于</a></li>
                </ul>
            </div>
        </div>
        <div id="loginContent">
            <div class="loginContentLogo">
                <img src="/mgmadmin/img/temp/loginlogo.png" />
            </div>
            <div class="loginContentForm">
                <div class="loginContentFormLeft">
                    <img src="/mgmadmin/img/temp/Logo1.jpg" />
                </div>
                <div class="loginContentFormRight">
                    <div class="loginContentForm_Title">
                        <p><span>用户登录</span><span>UserLogin</span></p>
                    </div>
                    <div class="loginContentForm_Input">
                        <div class="loginContentForm_InputImg">
                            <img src="/mgmadmin/img/user_ico.png" />
                        </div>
                        <div class="loginContentForm_InputText">
                            <asp:TextBox runat="server" ID="txtName" CssClass="loginText" placeholder="请输入用户名"></asp:TextBox>
                        </div>
                    </div>
                    <div class="loginContentForm_Input">
                        <div class="loginContentForm_InputImg">
                            <img src="/mgmadmin/img/user_pass.png" />
                        </div>
                        <div class="loginContentForm_InputText">
                            <asp:TextBox runat="server" ID="txtPass" CssClass="loginText" TextMode="Password" placeholder="请输入密码"></asp:TextBox>
                        </div>
                    </div>
                    <div class="loginContentForm_Btn">
                        <ul>
                            <li>
                                <asp:Button runat="server" ID="btnLogin" Text="登录" CssClass="btnLogin" OnClick="btnLogin_Click" />
                            </li>
                            <li>
                                <asp:Label runat="server" ID="lbMessage"></asp:Label>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div id="loginFooter">
            <p>版权所有 2015 上海领意文化传播有限公司</p>
        </div>
    </form>
</body>
</html>

