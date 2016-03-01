<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="refrigerant.aspx.cs" Inherits="wxtest.UILayer.AirConditioningPages.refrigerant" %>

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
            <h1>制冷剂</h1>
        </div>
        <div role="main" class="ui-content">
            <img style="width: 100%" src="/assets/images/web/air104.jpg" alt="" height="200" />
            <hr />
            <p>
                <strong><span style="font-size: 18px; color: #FF9900;">制冷剂</span><br />
                    <span id="jnkc" style="color: #666666;"></span>
                    <script>setInterval("jnkc.innerHTML=new Date().toLocaleString() + ' 星期' + '天一二三四五六'.charAt(new Date().getDay());", 1000);</script>
                </strong>
            </p>
            <p>
                <a href="http://v.qq.com/boke/page/l/f/k/l01506o15fk.html" target="_blank">
                    <img style="width: 100%;" src="/assets/images/web/airIntro01.jpg" />
                </a>
            </p>
            <strong><span style="color: #999999; font-size: 14px;"><span style="color: #E53333; background-color: #FFE500;"><a style="color: #E53333; background-color: #FFE500; font-size: 18px" href="http://v.qq.com/boke/page/l/f/k/l01506o15fk.html" target="_blank">点击播放上述视频</a></span><span style="color: #009900; background-color: #00D5FF; font-size: 18px">（建议在WIFI的情况下看哦，土豪请随意）</span></span></strong><br />
            <strong><span style="color: #999999; font-size: 14px;">假冒制冷剂的危害</span></strong><br />
            <strong><span style="color: #999999; font-size: 14px;">1、假冒制冷剂和冷冻油（压缩机润滑油），发生反应形成胶状乳化物，乳化物随着制冷剂的流动在膨胀阀节流管集聚堵塞管路，导致管路压力生高，在最薄弱的地方爆裂。润滑效果大大下降，严重的造成压缩机拉缸。</span></strong><br />
            <strong><span style="color: #999999; font-size: 14px;">2、腐蚀空调系统密封材料，造成空调管路接口和空调压缩机等泄露</span></strong><br />
            <strong><span style="color: #999999; font-size: 14px;">3、以前R12用的是铜管路，腐蚀134A空调的铝合金管路造成泄露。</span></strong><br />
            <strong><span style="color: #999999; font-size: 14px;">4、可假的冷媒长期使用轻则导致空调系统泄漏，重则导致压缩机损坏、腐蚀，使空调系统部件和管道损坏，更换配件使客户的消费成本增加，同时冷媒排放还会影响大气污染破坏环境！</span></strong><br />
            <strong><span style="color: #999999; font-size: 14px;">&nbsp; &nbsp; &nbsp; 陕西永久空调服务站引进专业制冷剂真假检别仪，可为新老客户的汽车空调系统进行全面的免费检测，<br />预约电话：<br /><a href="tel:18192933995" style="text-decoration:none"><span style="font-size: 18px; color: #337FE5;">18192933995</span></a><br /><a href="tel:18629430492" style="text-decoration:none"><span style="font-size: 18px; color: #337FE5;">18629430492</span></a></span></strong><br />
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
