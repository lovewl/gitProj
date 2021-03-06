﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AirConditioning.aspx.cs" Inherits="wxtest.UILayer.AirConditioning" %>

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
            <h1>空调专修</h1>
        </div>
        <div role="main" class="ui-content">
            <div id="aircondition" style="width: 100%">
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/air101.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/air102.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/air103.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/air104.jpg" />
                </div>
            </div>
            <script type="text/javascript">
                $(document).ready(function () {
                    $('#aircondition').slick({
                        autoplay: true,
                        autoplaySpeed: 2000,
                        arrows: false,
                        speed: 500,
                        fade: true,
                        cssEase: 'linear'
                    });
                });
            </script>
            <hr />
            <ul data-role="listview" data-inset="true">
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=206109366&idx=1&sn=1b4c8061e5a93f0bc3e5f67608e43b3a#rd" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/air101.jpg">
                        <h2>【汽车空调专业服务站】简介</h2>
                        <p>简介</p>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="http://eqxiu.com/s/QV2YHcJA?eqrcode=1" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/air102.jpg">
                        <h2>【空调节】空调专修</h2>
                        <p>空调专修</p>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=206250533&idx=1&sn=17d5bfba3172f10b3d8dbb6921f8018d#rd" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/air103.jpg">
                        <h2>【汽车空调】38项检测流程</h2>
                        <p>38项检测流程</p>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="/UILayer/AirConditioningPages/refrigerant.aspx" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/air104.jpg">
                        <h2>【制冷剂】真假揭秘</h2>
                        <p>真假揭秘</p>
                    </a>
                </li>
            </ul>
        </div>
        <hr />
        <footer style="text-align: center">
            <p>
                &copy; <%=DateTime.Now.Year %> - 陕西永久汽车服务
            </p>
        </footer>
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
