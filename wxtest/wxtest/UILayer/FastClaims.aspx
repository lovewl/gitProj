<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FastClaims.aspx.cs" Inherits="wxtest.UILayer.FastClaims" %>

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
            <h1>快速理赔</h1>
        </div>
        <div role="main" class="ui-content">
            <div id="index02" style="width: 100%">
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/fast101.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/fast102.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/fast103.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/fast104.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/fast105.jpg" />
                </div>
                <div>
                    <img class="ui-corner-all" style="width: 100%; height: 100%" src="/assets/images/web/fast106.jpg" />
                </div>
            </div>
            <script type="text/javascript">
                $(document).ready(function () {
                    $('#index02').slick({
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
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="/UILayer/FastClaimsPages/claimsnotice.aspx" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/fast101.jpg">
                        <h2>【理赔须知】理赔须知</h2>
                        <p>理赔须知</p>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="/UILayer/FastClaimsPages/starservice.aspx" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/fast102.jpg">
                        <h2>【理赔专员】理赔专员</h2>
                        <p>理赔专员</p>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="/UILayer/FastClaimsPages/claimsappointment.aspx" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/fast103.jpg">
                        <h2>【理赔预约】理赔预约</h2>
                        <p>理赔预约</p>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="/UILayer/FastClaimsPages/claimsprocess.aspx" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/fast104.jpg">
                        <h2>【理赔流程】理赔流程</h2>
                        <p>理赔流程</p>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="/UILayer/FastClaimsPages/divisionofresponsibilities.aspx" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/fast105.jpg">
                        <h2>【责任划分】责任划分</h2>
                        <p>责任划分</p>
                    </a>
                </li>
                <li>
                    <a style="margin: 5px 0 5px 0; border-radius: 10px" href="/UILayer/FastClaimsPages/autoinsurance.aspx" rel="external" data-transition="flip">
                        <img style="width: 100%; height: 100%" src="/assets/images/web/fast106.jpg">
                        <h2>【车险办理】车险办理</h2>
                        <p>车险办理</p>
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
