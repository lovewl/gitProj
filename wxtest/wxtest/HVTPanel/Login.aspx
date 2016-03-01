<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.Login" %>

<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <style>
        td {
            color: white;
        }
    </style>
    <script src="/assets/lib/jquery-2.1.4/jquery-2.1.4.min.js"></script>
    <script src="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.js"></script>
    <script>
        $(document).ready(function () {
            $("body > [data-role='panel']").panel();
            $("body > [data-role='panel'] [data-role='listview']").listview();
        });
    </script>
</head>
<body>
    <div data-role="panel" id="outside" class="ui-page-theme-a">
        <h1>网站导航</h1>
        <ul data-role="listview">
            <li><a rel="external" href="/UILayer/FastClaims.aspx">快速理赔</a></li>
            <li><a rel="external" href="/UILayer/shanxiyongjiu.aspx">陕西永久</a></li>
            <li><a rel="external" href="/UILayer/AirConditioning.aspx">空调专修</a></li>
            <%--<li><a rel="external" href="/UILayer/WeiXinManager.aspx">微信管理测试页</a></li>--%>
            <li><a rel="external" href="/HVTPanel/Login.aspx">留言管理</a></li>
            <li><a rel="external" href="/account/login.aspx">登陆</a></li>
            <%--<li><a rel="external" href="/handlers/award-activity.ashx">答题活动</a></li>--%>
        </ul>
    </div>
    <div data-role="page" class="ui-page-theme-a">
        <div data-role="header" data-position="fixed">
            <h1>管理员登录</h1>
        </div>
        <div role="main" class="ui-content">
            <form id="form1" runat="server">
                <table style="width: 100%; background-color: darkgrey; border: 1px solid silver; border-radius: .4em">
                    <tr style="text-align: center">
                        <td colspan="2">
                            <div style="text-align: center; color: white">
                                <h1 style="text-shadow: .3em .3em .4em black">管理员登录</h1>
                            </div>
                        </td>
                    </tr>
                    <tr style="text-align: center">
                        <td><strong style="text-shadow: .3em .3em .4em black">用户名：</strong></td>
                        <td>
                            <asp:TextBox runat="server" ID="tbUsername" /></td>
                    </tr>
                    <tr style="text-align: center">
                        <td><strong style="text-shadow: .3em .3em .4em black">密 码：</strong></td>
                        <td>
                            <asp:TextBox runat="server" ID="tbPassword" TextMode="Password" /></td>
                    </tr>
                    <tr style="text-align: center">
                        <td colspan="2">
                            <asp:Button runat="server" data-inline="true" ID="btnLogin" Text="登 录" OnClick="btnLogin_Click" />
                            <input data-inline="true" type="reset" value="重 置" />
                        </td>
                    </tr>
                    <tr style="text-align: center">
                        <td colspan="2">
                            <asp:Literal runat="server" ID="ltlTips" /></td>
                    </tr>
                </table>
            </form>
            <hr />
            <footer style="text-align: center">
                <p>
                    &copy; <%=DateTime.Now.Year %> - 陕西永久汽车服务
                </p>
            </footer>
        </div>
        <div data-role="footer" data-position="fixed">
            <div data-role="navbar">
                <ul>
                    <li><a rel="external" href="/index.aspx" data-transition="flip" data-icon="home">首页</a></li>
                    <li><a rel="external" href="tel:02986220693" data-icon="phone">电话</a></li>
                    <li><a rel="external" href="#outside" data-icon="grid">菜单</a></li>
                    <li><a rel="external" href="http://map.baidu.com/mobile/webapp/index/index/foo=bar/vt=map" data-icon="location">导航</a></li>
                    <li><a rel="external" href="JavaScript:history.back()" data-transition="slide" data-icon="back">返回</a></li>
                </ul>
            </div>
        </div>
    </div>
</body>
</html>
