<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="wxtest.UILayer.Shop.index" %>

<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>在线商城</title>
    <link href="/assets/lib/slick/slick.css" rel="stylesheet" />
    <link href="/assets/lib/slick/slick-theme.css" rel="stylesheet" />
    <link href="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <script src="/assets/lib/jquery-2.1.4/jquery-2.1.4.min.js"></script>
    <script src="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.js"></script>
    <script src="/assets/lib/slick/slick.min.js"></script>
    <script>
        $(document).ready(function () {
            $("body > [data-role='panel']").panel();
            $("body > [data-role='panel'] [data-role='listview']").listview();
        });
    </script>
    <style>
        figure, figcaption, h4, img, text, div, a {
            margin: 0;
            padding: 0;
        }

        .width50 {
            float: left;
            padding: 0;
            margin: 0;
            width: 50%;
            text-align: center;
        }

        a {
            text-decoration: none;
            color: black;
        }
    </style>
</head>
<body>
    <div data-role="panel" id="outside" class="ui-page-theme-a">
        <h1>网站导航</h1>
        <ul data-role="listview">
            <li><a rel="external" href="/UILayer/FastClaims.aspx">快速理赔</a></li>
            <li><a rel="external" href="/UILayer/shanxiyongjiu.aspx">陕西永久</a></li>
            <li><a rel="external" href="/UILayer/AirConditioning.aspx">空调专修</a></li>
            <li><a rel="external" href="/UILayer/MetalPlate/index.aspx">钣喷快修</a></li>
            <%--<li><a rel="external" href="/UILayer/WeiXinManager.aspx">微信管理测试页</a></li>--%>
            <li><a rel="external" href="/HVTPanel/Login.aspx">留言管理</a></li>
            <li><a rel="external" href="/account/login.aspx">登陆</a></li>
            <li><a rel="external" href="/UILayer/MetalPlate/orderList.aspx">查看钣喷订单(需管理员权限)</a></li>
            <li><a rel="external" href="/UILayer/Shop/mana/manager.aspx">商城管理</a></li>
        </ul>
    </div>
    <div data-role="page" class="ui-page-theme-a">
        <div data-role="header" data-position="fixed">
            <h1>在线商城</h1>
        </div>
        <div role="main" class="ui-content">
            <div id="shop01" style="width: 100%">
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 200px" src="/assets/images/web/3.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 200px" src="/assets/images/web/4.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 200px" src="/assets/images/web/1.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 200px" src="/assets/images/web/2.jpg" />
                </div>
            </div>
            <script type="text/javascript">
                $(document).ready(function () {
                    $('#shop01').slick({
                        autoplay: true,
                        autoplaySpeed: 2000,
                        arrows: false,
                        speed: 500,
                        fade: true,
                        cssEase: 'linear'
                    });
                });
            </script>
            <div style="background-color: darkgray; border-radius: .4em; overflow: hidden">
                <asp:Repeater runat="server" ID="reItems">
                    <ItemTemplate>
                        <a style="display: block; width: 50%; float: left" rel="external" href="/UILayer/Shop/template/items.aspx?itemName=<%#Eval("Name") %>&itemID=<%#Eval("Id") %>">
                            <figure style="background-color: rgb(255,255,204); margin: .2rem .2rem 0 .2rem; border-radius: .4rem; text-align: center">
                                <figcaption>
                                    <h4 style="color: black; white-space: nowrap; overflow: hidden; text-overflow: ellipsis"><%#Eval("Name") %></h4>
                                </figcaption>
                                <img style="width: 100%; height: 100%; max-width: 100px; max-height: 100px; border-radius: 10px" src="<%#Eval("ImgPath") %>" alt="...">
                                <figcaption><small style="text-decoration: line-through; color: lightslategrey">原价：&yen;<%#Eval("OriginalPrice") %></small></figcaption>
                                <figcaption>
                                    <text style="color: red; font-size: 18px; font-weight: 700">优惠价：&yen;<%#Eval("Price") %></text>
                                </figcaption>
                                <div style="color: black; white-space: nowrap; overflow: hidden; text-overflow: ellipsis"><%#Eval("Introduce") %></div>
                            </figure>
                            <br />
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
                <div style="clear: both"></div>
            </div>
            <hr />
            <footer style="text-align: center">
                <p>
                    &copy; <%=DateTime.Now.Year %> - 陕西永久汽车服务<br />
                    <%if (ReadTimes == "err")
                        {%>
                    <small>正在统计访问次数，请稍后再试！</small>
                    <%}
                    else
                    {%>
                    <small>您是第</small>  <%= ReadTimes %> <small>位访客</small>
                    <%} %>
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
