<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MGM.Web.mgmadmin.LInkOrder.List" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>领意文化管理系统平台</title>
    <link rel="stylesheet" type="text/css" href="/mgmadmin/css/style.css" />
    <link rel="stylesheet" type="text/css" href="/mgmadmin/css/index.css" />
    <link rel="stylesheet" type="text/css" href="/mgmadmin/css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="/mgmadmin/css/List.css" />
    <link href="/mgmadmin/css/pagination.css" rel="stylesheet" />
    <link href="/mgmadmin/css/message.css" rel="stylesheet" />
    <script src="/mgmadmin/js/jquery-1.11.1.min.js" charset="utf-8"></script>
    <script src="/mgmadmin/js/jquery.message.js"></script>
</head>

<body>
    <form id="myform" runat="server">
        <!-- 头部 Begin -->
        <div id="header">
            <div class="topBox">
                <div class="topLogo">
                    <img src="/mgmadmin/img/logo.png" />
                </div>


            </div>
        </div>
        <!-- 头部 End -->

        <!--正文 Begin-->
        <div id="main">

            <!--左侧导航 Begin-->
            <div id="leftmenu">
                <div class="leftBox">
                    <div class="leftBoxTitle">
                        <p>管理台</p>
                    </div>

                    <div class="leftMenu">


                        <div class="leftMenuList">
                            <div class="leftMenuListTop">
                                <ul>
                                    <li>
                                        <img src="/mgmadmin/img/leftico04.png" />
                                    </li>
                                    <li>推荐申请管理</li>
                                </ul>
                            </div>
                            <div class="leftMenuListLi">
                                <ul>
                                    <li><a href="/mgmadmin/LInkOrder/List.aspx" draggable="false"><span>推荐申请列表</span></a>
                                    </li>
                                </ul>
                            </div>

                        </div>

                    </div>

                </div>
            </div>
            <!--左侧导航 End-->

            <!--页面内容 Begin-->
            <div id="pagemain">

                <div class="mapMenu">
                    <ul>
                        <li>位置：</li>
                        <li><a href="/mgmadmin/index.aspx">首页</a></li>
                        <li>></li>
                        <li><a href="../LInkOrder/List.aspx">文章管理</a></li>
                        <li>></li>
                        <li>文章列表</li>
                    </ul>
                </div>

                <div class="contentBox">

                    <ul class="search row">
                        <li class="small">搜索条件：</li>
                        <li>
                            <asp:DropDownList runat="server" ID="ddlState">
                                <asp:ListItem Value="0">状态</asp:ListItem>
                                <asp:ListItem Value="1">申请成功</asp:ListItem>
                                <asp:ListItem Value="2">借贷成功</asp:ListItem>
                                <asp:ListItem Value="3">待审核</asp:ListItem>
                            </asp:DropDownList>
                        </li>
                        <li>
                            <asp:TextBox runat="server" ID="txtKey" placeholder="请输入搜索关键字"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnSearch" Text="搜索" OnClick="btnSearch_Click" />
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnAllList" Text="查看全部" OnClick="btnAllList_Click" />
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnDaochu" Text="导出" OnClick="btnDaochu_Click" />
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnSend" Text="标记为借贷成功" OnClick="btnSend_Click" />
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnShenqing" Text="标记为申请成功" OnClick="btnShenqing_Click" />
                        </li>
                    </ul>
                    
                    <ul class="operation">
                        <li class="operdel">
                            <asp:LinkButton runat="server" ID="lbtndel" OnClientClick="return confirm('删除后不可恢复，确认删除吗？')" OnClick="lbtndel_Click"><i class="icon-remove"></i>删除</asp:LinkButton>
                        </li>
                        <li><asp:FileUpload runat="server" ID="fileExecl" /></li>
                        <li> <asp:Button runat="server" ID="btnDaoru" Text="导入" OnClick="btnDaoru_Click" /></li>


                    </ul>

                    <div class="listtable">
                        <ul class="tbtitle">
                            <li class="allselect">
                                <input type="checkbox" name="ckAll" id="ckAll" value="" /></li>
                            <li style="width: 100px;">姓名</li>
                            <li style="width: 100px;">电话</li>
                            <li style="width: 200px;">身份证号码</li>
                            <li style="width: 200px;">营业执照号码</li>
                            <li style="width: 100px;">推荐人姓名</li>
                            <li style="width: 100px;">推荐人电话</li>
                            <li style="width: 100px;">申请状态</li>
                            <li style="width: 150px;">申请时间</li>
                        </ul>

                        <asp:Repeater runat="server" ID="repList">
                            <ItemTemplate>
                                <ul class="listli">
                                    <li class="allselect"><asp:CheckBox runat="server" ID="ckSelect" /></li>
                                    <li style="width: 100px;"><asp:HiddenField runat="server" ID="hidid" Value='<%# Eval("Id") %>' /><%# Eval("NameInfo") %></li>
                                    <li style="width: 100px;"><%# Eval("Phone") %></li>
                                    <li style="width: 200px;"><%# Eval("CardNum") %></li>
                                    <li style="width: 200px;"><%# Eval("LicenseNum") %></li>
                                    <li style="width: 100px;"><%# Eval("RefereeName") %></li>
                                    <li style="width: 100px;"><%# Eval("RefereePhone") %></li>
                                    <li style="width: 100px;"><%#GetStateName(Eval("StateInfo").ToString()) %></li>
                                    <li style="width: 150px;"><%#string.IsNullOrWhiteSpace(Eval("AddTime").ToString())?"-":Convert.ToDateTime(Eval("AddTime")).ToString("yyyy-MM-dd") %> </li>
                                </ul>

                            </ItemTemplate>
                        </asp:Repeater>
                    </div>


                    <div class="pageBox">
                        <div class="pageBoxNum">
                            <span>共</span>
                            <span><%= pcount %></span>
                            <span>条数据，</span>
                            <span>共</span>
                            <span><%= Math.Ceiling(decimal.Parse(pcount.ToString())/pagesize) %></span>
                            <span>页，</span>
                            <span>当前显示第</span>
                            <span><%= string.IsNullOrWhiteSpace(Request.Params["page"])?1:int.Parse(Request.Params["page"])+1 %></span>
                            <span>页</span>
                        </div>
                        <div class="pageControls">
                            <div class="page flickr">
                            </div>
                        </div>
                    </div>


                   <ul class="share">
                       <li><p>首页查看次数：<span><%= indexnum  %></span>次</p></li>
                       <li><p>活动按钮点击次数：<span><%= huodongbtnnum  %></span>次</p></li>
                       <li><p>产品详情点击次数：<span><%= detailnum  %></span>次</p></li>
                       <li><p>活动分享次数：<span><%= fenxiangnum  %></span>次</p></li>
                       <li><p>信息填写页面浏览次数：<span><%= messagenum  %></span>次</p></li>
                       <li><p>推荐查询次数：<span><%= chaxunnum  %></span>次</p></li>
                   </ul>




                </div>

                <!--页面内容 End-->

            </div>
            <!--正文 End-->
        </div>
    </form>
    <script src="/mgmadmin/js/jquery.admin.js" charset="utf-8"></script>
    <script src="/mgmadmin/js/jquery.pagination.js"></script>
    <script>
        $(function () {

            $(".page").pagination(<%= pcount %>, {
                callback: pageselectCallback,
                prev_text: "上一页",
                next_text: "下一页",
                items_per_page:<%= pagesize%>,
                num_display_entries:3,
                current_page:<%= page%>,
                num_edge_entries:3,
                link_to:"?page=__id__<%= strUrl.ToString()%>"
            });
            $("#ckAll").click(function(){               
                var check= $(this).prop("checked");
                $("input[type=checkbox]").each(function(){
                    $(this).prop("checked",check);
                })              
            })


            SetLeftMenu("推荐申请管理","推荐申请列表");


          
        })

        function pageselectCallback(page_id, jq) {
            //alert(page_id); 回调函数，进一步使用请参阅说明文档
        }




    </script>

</body>

</html>
