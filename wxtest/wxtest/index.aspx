<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="wxtest.index" %>

<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/lib/slick/slick.css" rel="stylesheet" />
    <link href="/assets/lib/slick/slick-theme.css" rel="stylesheet" />
    <link href="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <script src="/assets/lib/jquery-2.1.4/jquery-2.1.4.min.js"></script>
    <script src="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.js"></script>
    <script src="/assets/lib/slick/slick.min.js"></script>
    <style>
        .iconlist {
            padding: 0;
        }

        .width100 {
            width: 100%;
            padding: 0;
            margin: 0;
        }
    </style>
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
            <li><a rel="external" href="/UILayer/MetalPlate/index.aspx">钣喷快修</a></li>
            <%--<li><a rel="external" href="/UILayer/WeiXinManager.aspx">微信管理测试页</a></li>--%>
            <li><a rel="external" href="/HVTPanel/Login.aspx">留言管理</a></li>
            <li><a rel="external" href="/account/login.aspx">登陆</a></li>
            <li><a rel="external" href="/UILayer/MetalPlate/orderList.aspx">查看钣喷订单(需管理员权限)</a></li>
        </ul>
    </div>
    <div data-role="page" class="ui-page-theme-a">
        <div data-role="header" data-position="fixed">
            <h1>首页</h1>
        </div>
        <div role="main" class="ui-content">
            <div id="index01" style="width: 100%">
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/index01.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/index02.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/index03.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/index04.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/index05.jpg" />
                </div>
            </div>
            <script type="text/javascript">
                $(document).ready(function () {
                    $('#index01').slick({
                        autoplay: true,
                        autoplaySpeed: 2000,
                        arrows: false,
                        speed: 500,
                        fade: true,
                        cssEase: 'linear'
                    });
                });
            </script>
            <div class="ui-grid-a">
                <div class="ui-block-a">
                    <a href="/UILayer/FastClaims.aspx" rel="external" class="ui-shadow ui-btn ui-corner-all iconlist" data-transition="flip">
                        <img class="width100" src="/assets/images/icons/indexIcon01.jpg" /><br />
                        快速理赔
                    </a>
                </div>
                <div class="ui-block-b">
                    <a href="/UILayer/shanxiyongjiu.aspx" rel="external" class="ui-shadow ui-btn ui-corner-all iconlist" data-transition="flip">
                        <img class="width100" src="/assets/images/icons/indexIcon02.jpg" /><br />
                        陕西永久
                    </a>
                </div>
            </div>
            <div class="ui-grid-a">
                <div class="ui-block-a">
                    <a href="/UILayer/AirConditioning.aspx" rel="external" class="ui-shadow ui-btn ui-corner-all iconlist" data-transition="flip">
                        <img class="width100" src="/assets/images/icons/indexIcon03.jpg" /><br />
                        空调专修
                    </a>
                </div>
                <div class="ui-block-b">
                    <a href="/default.aspx" rel="external" class="ui-shadow ui-btn ui-corner-all iconlist" data-transition="flip">
                        <img class="width100" src="/assets/images/icons/indexIcon04.jpg" /><br />
                        留言板
                    </a>
                </div>
            </div>
            <div class="ui-grid-a">
                <div class="ui-block-a">
                    <a href="/UILayer/Shop/index.aspx" rel="external" class="ui-shadow ui-btn ui-corner-all iconlist" data-transition="flip">
                        <img class="width100" src="/assets/images/icons/indexIcon05.jpg" /><br />
                        在线商城
                    </a>
                </div>
            </div>
            <hr />
            <footer style="text-align: center">
                <p>
                    &copy; <%=DateTime.Now.Year %> - 陕西永久汽车服务<br />
                    <small>您是第</small>  <%= ReadTimes %> <small>位访客</small>
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
