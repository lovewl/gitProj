<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="wxtest.UILayer.MetalPlate.index" %>

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
            <h1>钣喷快修首页</h1>
        </div>
        <div role="main" class="ui-content">
            <div id="metalplateindex01" style="width: 100%; margin-bottom: 0">
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/metalplate/lunbo01.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/metalplate/lunbo02.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/metalplate/lunbo03.jpg" />
                </div>
            </div>
            <script type="text/javascript">
                $(document).ready(function () {
                    $('#metalplateindex01').slick({
                        autoplay: true,
                        autoplaySpeed: 2000,
                        arrows: false,
                        speed: 500,
                        fade: true,
                        cssEase: 'linear'
                    });
                });
            </script>
            <div class="ui-grid-a" style="margin-top: 0">
                <div class="ui-block-a">
                    <a href="http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=401577783&idx=1&sn=59a41acb0a1fae9653477d75e850292d#rd\" rel="external" class="ui-shadow ui-btn ui-corner-all iconlist" data-transition="flip">
                        <img class="width100" src="/assets/images/web/metalplate/introl01.png" />
                    </a>
                </div>
                <div class="ui-block-b">
                    <a href="#" rel="external" class="ui-shadow ui-btn ui-corner-all iconlist" data-transition="flip">
                        <img class="width100" src="/assets/images/web/metalplate/introl02.png" />
                    </a>
                </div>
            </div>
            <ul data-role="listview" data-inset="true">
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="sebrand.aspx" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/metalplate/icon05.png">
                        <h2>自费钣金喷漆</h2>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="#" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/metalplate/icon06.png">
                        <h2>走保险钣金喷漆</h2>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="#" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/metalplate/icon01.png">
                        <h2>车辆快速保养</h2>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="#" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/metalplate/icon03.png">
                        <h2>在线估价</h2>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="#" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/metalplate/icon04.png">
                        <h2>汽车美容</h2>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="#" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/metalplate/icon02.png">
                        <h2>车险特惠直销</h2>
                    </a>
                </li>
            </ul>
            <hr />
            <footer style="text-align: center">
                <p>
                    &copy; <%=DateTime.Now.Year %> - 永久钣喷快修<%--<a href="WebForm1.aspx" rel="external">--%>服务<%--</a>--%>连锁<br /><%--<small>您是第</small>  <%= ReadTimes %> <small>位访客</small>--%>
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
