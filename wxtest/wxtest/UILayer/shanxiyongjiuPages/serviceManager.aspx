<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviceManager.aspx.cs" Inherits="wxtest.UILayer.shanxiyongjiuPages.serviceManager" %>

<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
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
            <h1>服务经理</h1>
        </div>
        <div role="main" class="ui-content">
            <img style="width: 100%" src="/assets/images/web/emploee/WangCaiPing01.jpg" alt="" height="200" />
            <hr />
            <p>
                <strong><span style="font-size: 18px; color: #FF9900;">服务经理</span><br />
                    <span id="jnkc" style="color: #666666;"></span>
                    <script>
                        window.setInterval(dt, 1000);
                        function dt() {
                            var date = new Date();
                            var year = date.getFullYear();
                            var month = (date.getMonth() + 1) < 10 ? ("0" + (date.getMonth() + 1)) : (date.getMonth() + 1);
                            var day = date.getDate() < 10 ? ("0" + date.getDate()) : date.getDate();
                            var week = date.getDay();
                            var hour = date.getHours() < 10 ? ("0" + date.getHours()) : date.getHours();
                            var minute = date.getMinutes() < 10 ? ("0" + date.getMinutes()) : date.getMinutes();
                            var second = date.getSeconds() < 10 ? ("0" + date.getSeconds()) : date.getSeconds();
                            document.getElementById("jnkc").innerHTML = year + "-" + month + "-" + day + " " + hour + ":" + minute + ":" + second + " 星期" + "天一二三四五六七".charAt(week);
                        };
                    </script>
                </strong>
            </p>
            <p>
                <strong><span style="font-size: 14px; color: #999999;">从事汽车服务行业三十年。工作严谨，责任心强，为人和善，很有亲和力。</span></strong><br />
                <strong><span style="font-size: 14px; color: #999999;">经理留言：您如果对我们的服务有什么意见或者建议，请在线留言，我们会在三个工作日内给您回复。或者您也可以电话： <a style="text-decoration:none" href="tel:02963621300" target="_blank"><span style="font-size: 18px; color: #337FE5;">029-63621300</span></a></span></strong><strong><span style="font-size: 14px; color: #999999;"></span></strong><br />
            </p>
            <hr />
            <p style="color: rgb(62, 62, 62);">
                <img style="width: 100%" src="/assets/images/qrcode-50-1.jpg" />
            </p>
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
