<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="claimsprocess.aspx.cs" Inherits="wxtest.UILayer.FastClaimsPages.claimsprocess" %>

<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no" />
    <title>������ͨ�¹ʿ촦�����������</title>
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
        <h1>��վ����</h1>
        <ul data-role="listview">
            <li><a rel="external" href="/UILayer/FastClaims.aspx">��������</a></li>
            <li><a rel="external" href="/UILayer/shanxiyongjiu.aspx">��������</a></li>
            <li><a rel="external" href="/UILayer/AirConditioning.aspx">�յ�ר��</a></li>
            <%--<li><a rel="external" href="/UILayer/WeiXinManager.aspx">΢�Ź������ҳ</a></li>--%>
            <li><a rel="external" href="/HVTPanel/Login.aspx">���Թ���</a></li>
            <li><a rel="external" href="/account/login.aspx">��½</a></li>
            <%--<li><a rel="external" href="/handlers/award-activity.ashx">����</a></li>--%>
        </ul>
    </div>
    <div data-role="page" class="ui-page-theme-a">
        <div data-role="header" data-position="fixed">
            <h1>��������</h1>
        </div>
        <div role="main" class="ui-content">
            <img style="width: 100%" src="/assets/images/web/fast104.jpg" alt="" height="200" />
            <hr />
            <p>
                <strong><span style="font-size: 18px; color: #FF9900;">��������</span><br />
                    <span id="jnkc" style="color: #666666;"></span>
                    <script>setInterval("jnkc.innerHTML=new Date().toLocaleString() + ' ����' + '��һ����������'.charAt(new Date().getDay());", 1000);</script>
                </strong>
            </p>
            <p>
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/1.jpg" />
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/2.jpg" />
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/3.jpg" />
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/4.jpg" />
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/5.jpg" />
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/6.jpg" />
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/7.jpg" />
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/8.jpg" />
                <img style="width: 100%" src="/images/web/claimsProcess/thumb/9.jpg" />
            </p>
            <hr />
            <p>
                <img style="width: 100%" src="/assets/images/qrcode-50-1.jpg" />
            </p>
            <hr />
            <footer style="text-align: center">
                <p>
                    &copy; <%=DateTime.Now.Year %> - ����������������<br />
                    <small>���ǵ�</small>  <%= ReadTimes %> <small>λ�ÿ�</small>
                </p>
            </footer>
        </div>
        <div data-role="footer" data-position="fixed">
            <div data-role="navbar">
                <ul>
                    <li><a rel="external" href="/index.aspx" data-transition="flip" data-icon="home">��ҳ</a></li>
                    <li><a rel="external" href="tel:02986220693" data-icon="phone">�绰</a></li>
                    <li><a rel="external" href="#outside" data-icon="grid">�˵�</a></li>
                    <li><a rel="external" href="http://map.baidu.com/mobile/webapp/index/index/foo=bar/vt=map" data-icon="location">����</a></li>
                    <li><a rel="external" href="JavaScript:history.back()" data-transition="slide" data-icon="back">����</a></li>
                </ul>
            </div>
        </div>
    </div>
</body>
</html>
