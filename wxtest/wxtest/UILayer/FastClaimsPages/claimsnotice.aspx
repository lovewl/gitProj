<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="claimsnotice.aspx.cs" Inherits="wxtest.UILayer.FastClaimsPages.claimsnotice" %>

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
            <h1>理赔须知</h1>
        </div>
        <div role="main" class="ui-content">
            <a href="/UILayer/FastClaimsPages/claimsnotice.aspx">
                <img style="width: 100%" src="/images/web/fast101.jpg" alt="" height="200" /></a>
            <hr />
            <p>
                <strong><span style="font-size: 18px; color: #FF9900;">理赔须知</span><br />
                    <span id="jnkc" style="color: #666666;"></span>
                    <script>setInterval("jnkc.innerHTML=new Date().toLocaleString() + ' 星期' + '天一二三四五六'.charAt(new Date().getDay());", 1000);</script>
                    <br />
                </strong>
            </p>
            <p>
                <span style="color: #999999; font-size: 14px;"><strong>永久快速理赔服务中心工作时间为8：30-17：30，节假日正常提供服务。超过对外服务时间（包括夜间）发生的事故，当事人在向保险公司报案，可拨打服务中心统一电话：</strong></span>
                <span style="color: #999999;"><a href="tel:02982208122"><strong><span style="font-size: 16px;">029-82208122</span></strong></a></span>
                <span style="color: #999999; font-size: 14px;"><strong>约定第二天（24小时内）再到该点办理理赔手续。</strong></span><br />
                <br />
                <span style="color: #999999; font-size: 14px;"><strong>办理快赔所需手续及注意事项如下：</strong></span><br />
                <br />
                <span style="color: #999999; font-size: 14px;"><strong>1、 驾驶证原件及复印件、行驶证原件及复印件。</strong></span><br />
                <br />
                <span style="color: #999999; font-size: 14px;"><strong>2、 有效期内的交强险、商业险保单及复印件。</strong></span><br />
                <br />
                <span style="color: #999999; font-size: 14px;"><strong>3、 双方当事人必须到场</strong></span><br />
                <br />
                <span style="color: #999999; font-size: 14px;"><strong>4、 快赔处理时效，24 小时内。</strong></span><br />
                <br />
                <hr />
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
