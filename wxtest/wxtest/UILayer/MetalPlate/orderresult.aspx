<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderresult.aspx.cs" Inherits="wxtest.UILayer.MetalPlate.orderresult" %>

<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="/Public/wap/css/base.css">
    <link rel="stylesheet" href="/Public/wap/css/common_1.css">
    <script src="/assets/lib/jquery-2.1.4/jquery-2.1.4.min.js"></script>
    <script src="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.js"></script>
    <%--<script type="text/javascript" charset="utf-8" async="" data-requiremodule="jquery" src="/Public/wap/scripts/lib/vonder/jquery.js"></script>--%>
    <%--<script type="text/javascript" charset="utf-8" src="/Public/wap/scripts/lib/common.js"></script>--%>
    <script type="text/javascript" charset="utf-8" src="/Public/js/jweixin-1.0.0.js?v=1000"></script>
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
        window.onload = function () {
            setTimeout(function () {
                window.location = "index.aspx";
            }, 3000);
        }
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
            <li><a rel="external" href="/UILayer/MetalPlate/orderList.aspx">查看钣喷订单(需管理员权限)</a></li>
        </ul>
    </div>
    <div data-role="page" class="ui-page-theme-a">
        <div data-role="header" data-position="fixed">
            <h1>钣喷快修首页</h1>
        </div>
        <div role="main" class="ui-content">
            <h4 style="font-size:x-large"><%= Message %></h4>
            <hr />
            <footer style="text-align: center">
                <p>
                    &copy; <%=DateTime.Now.Year %> - 永久钣喷快修服务连锁<br />
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
