<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="autoinsurance.aspx.cs" Inherits="wxtest.UILayer.FastClaimsPages.autoinsurance" %>

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
            <h1>车险办理</h1>
        </div>
        <div role="main" class="ui-content">
            <img style="width: 100%" src="/assets/images/web/fast103.jpg" alt="" height="200" />
            <hr />
            <p>
                <strong><span style="font-size: 18px; color: #FF9900;">车险办理</span><br />
                    <span id="jnkc" style="color: #666666;"></span>
                    <script>setInterval("jnkc.innerHTML=new Date().toLocaleString() + ' 星期' + '天一二三四五六'.charAt(new Date().getDay());", 1000);</script>
                </strong>
            </p>
            <p>
                <span style="color: #999999; font-size: 14px">我公司与人保车险携手合作，最低4折起优惠。</span><br>
                <span style="color: #999999; font-size: 14px">【国家汽车强制保险费与车船税 】</span><br>
                <span style="color: #999999; font-size: 14px">私家车强制险： </span>
                <br>
                <span style="color: #999999; font-size: 14px">第一年：5座 &nbsp; 950元，6-8座 1100元 </span>
                <br>
                <span style="color: #999999; font-size: 14px">第二年： &nbsp; &nbsp; 855元 ， &nbsp; &nbsp;990元 </span>
                <br>
                <span style="color: #999999; font-size: 14px">第三年： &nbsp; &nbsp; 760元 ， &nbsp; &nbsp;880元 </span>
                <br>
                <span style="color: #999999; font-size: 14px">第四年： &nbsp; &nbsp; 665元 ， &nbsp; &nbsp;770元 </span>
                <br>
                <span style="color: #999999; font-size: 14px">第五年： &nbsp; &nbsp; 665元 ， &nbsp; &nbsp;770元 </span>
                <br>
                <span style="color: #999999; font-size: 14px">以上保费，跟出险，脱保，过户有关系，其中任意一项变化了，那样保费会重新计算</span><br>
                <span style="color: #999999; font-size: 14px">【车船税】 </span>
                <br>
                <span style="color: #999999; font-size: 14px">1.0升 以下 &nbsp; &nbsp;：180元/年 </span>
                <br>
                <span style="color: #999999; font-size: 14px">1.0~1.6升 （含）：300元/年 </span>
                <br>
                <span style="color: #999999; font-size: 14px">1.6~2.0升 （含）：480元/年 </span>
                <br>
                <span style="color: #999999; font-size: 14px">2.0~2 .5升（含）：720元/年 </span>
                <br>
                <span style="color: #999999; font-size: 14px">2.5~3.0升 （含）：1800元/年 </span>
                <br>
                <span style="color: #999999; font-size: 14px">3.0~4.0升 （含）：3000元/年 </span>
                <br>
                <span style="color: #999999; font-size: 14px">4.0升以上 &nbsp; &nbsp; ：4500元/年 </span>
                <br>
                <span style="color: #999999; font-size: 14px">★个人车：</span><br>
                <span style="color: #999999; font-size: 14px">1.车主身份证正、反两面复印件 </span>
                <br>
                <span style="color: #999999; font-size: 14px">2.行驶证正、副本复印件；</span><br>
                <span style="color: #999999; font-size: 14px">★单位车：</span><br>
                <span style="color: #999999; font-size: 14px">1.组织机构代码证复印件 </span>
                <br>
                <span style="color: #999999; font-size: 14px">2.行驶证复印件 </span>
                <br>
                <p style="white-space: normal; color: rgb(62, 62, 62);">
                    <span style="font-size: 24px">咨询办理电话：</span><br>
                    <span style="font-size: 24px;"><a href="tel:18192933995" style="text-decoration:none">18192933995</a><strong>&nbsp;赵先生</strong></span><br>
                </p>
            </p>
            <hr />
            <p>
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
