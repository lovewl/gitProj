<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="introduction.aspx.cs" Inherits="wxtest.UILayer.AirConditioningPages.introduction" %>

<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/css/mian.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body {
            background: #E0E0E0;
        }

        .divall {
            border: 0px solid green;
            padding: 10px 6px 10px 8px;
        }

        .divimg {
            border: 0px solid #ccc;
        }

        .divtitle {
            margin-top: 2px;
            border: 0px solid red;
        }

        .divtime {
            margin-top: 2px;
            border: 0px solid red;
        }

        .titlespan {
            color: #ff9900;
            font-size: 18px;
        }

        .titlestarspan {
            color: #ff9900;
            font-size: 18px;
            text-align: right;
        }

        .timespan {
            color: #666;
        }

        .divcontent {
            margin-top: 5px;
            border: 0px solid red;
        }

        .divbtn {
            margin-top: 10px;
            border: 0px solid red;
        }

        .btnspan {
            color: #666;
        }

        div.RoundedCorner {
            background: #FFFFFF;
            margin-left: 8px;
            margin-right: 8px;
            margin-top: 8px;
            margin-bottom: 8px;
        }

        b.rtop, b.rbottom {
            display: block;
            background: #E0E0E0;
        }

        b.rtop b, b.rbottom b {
            display: block;
            height: 1px;
            overflow: hidden;
            background: #FFFFFF;
        }

        b.r1 {
            margin: 0 5px;
        }

        b.r2 {
            margin: 0 3px;
        }

        b.r3 {
            margin: 0 2px;
        }

        b.rtop b.r4, b.rbottom b.r4 {
            margin: 0 1px;
            height: 2px;
        }

        a {
            blr: expression_r(this.onFocus=this.blur());
        }

        area {
            blr: expression_r(this.onFocus=this.blur());
        }

        a:link {
            color: #337FE5;
            text-decoration: none; /*连接默认的颜色变化*/
        }

        a:visited {
            color: #337FE5;
            text-decoration: none; /*连接访问的颜色变化*/
        }

        a:hover {
            color: #999999;
            text-decoration: underline; /*鼠标经过的颜色变化*/
        }

        a:active {
            color: #337FE5;
            text-decoration: none; /*鼠标按下的颜色变化*/
        }
    </style>
</head>
<body style="padding-top:0">
    <div class="RoundedCorner">
        <b class="rtop"><b class="r1"></b><b class="r2"></b><b class="r3"></b><b class="r4"></b></b>
        <div class="zhezhao"></div>
        <div class="nav">
            <h1>网站导航</h1>
            <ul>
                <li><a href="/UILayer/FastClaims.aspx">快速理赔</a></li>
                <li><a href="/UILayer/shanxiyongjiu.aspx">陕西永久</a></li>
                <li><a href="/UILayer/AirConditioning.aspx">空调专修</a></li>
            </ul>
        </div>
        <p style="text-align: center;">
            <a href="/UILayer/AirConditioningPages/introduction.aspx">
                <img style="width: 100%" src="/images/web/air101.jpg" alt="" height="200" /></a>
        </p>
        <hr />
        <div class="divtitle" style="border: 0px solid red; font-family: Simsun; font-size: medium; background-color: #FFFFFF;">
            <span class="titlespan" style="color: #FF9900; font-size: 18px;">空调专修服务介绍</span><span class="titlestarspan" style="color: #FF9900; font-size: 18px;"></span>
        </div>
        <div class="divtime" style="border: 0px solid red; font-family: Simsun; font-size: medium; background-color: #FFFFFF;">
            <span runat="server" class="timespan" style="color: #666666;"><%= DateStr %></span>
        </div>
        <div>
            <div class="rich_media_content" id="js_content">
                <p>
                    <span style="font-size: 20px;">陕西永久汽车空调专业服务站是被安莱（北京）汽车技术研究院，授予西北地区第一家专业的空调4S服务站，我服务站引进安莱<span style="font-size: 20px;">（北京）汽车技术研究院</span>先进的空调检测技术，研究院院长<span style="background-color: rgb(0, 176, 240);">阚有波</span>亲自指导，以全新的工艺及进口的设备，全程数据化检测，使广大车主了解汽车空调真相。</span><span style="font-size: 20px;">   </span>
                    <img src="/images/web/airIntro01.jpg" data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqukKEfib8tSPoQ3pQehYv9VGLpIgUPykzwmPTLtMMLwicf44uiap2NhWm18unWhT5ByCkN5MkYRia7Whw/0" style="font-size: 20px;" data-ratio="0.7371541501976284" data-w="" />
                </p>
                <p><span style="font-size: 16px;">安莱（北京）汽车技术研究院长</span></p>
                <p><span style="font-size: 20px;">汽车空调从4大类（制冷、风量、异味、其他维护）、7个分项（外部散热、制冷剂、风量、车内空间、车内空调管路、线路、噪音）38个检测点对汽车空调进行系统全面的检测。从美国引进先进的汽车空调系统清洗机、制冷剂纯度鉴别仪、风速检测仪、温度检测仪、冰点测试仪、抽打一体式真空泵等设备。经国家质量技术监督总局认证，制冷剂真假检测专用设备，海关质量检测专用设备</span><span style="font-size: 20px;">。</span></p>
                <p>
                    <span style="font-size: 20px;">
                        <img src="/images/web/airIntro02.jpg" data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqukKEfib8tSPoQ3pQehYv9VGWF9zcdNWCIjciay5IahRUaFU77aQCiczjic8bzzibNLKRzsqNQVfrfZ62Q/0" data-ratio="2.102766798418972" data-w="" /><br />
                        汽车空调系统专用清洗机</span>
                </p>
                <p>
                    <span style="font-size: 20px;">
                        <img src="/images/web/airIntro03.jpg" data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqukKEfib8tSPoQ3pQehYv9VGATmukHS5QfDkuuf7zSACGD9bf4CgXNNOgGWCBAutyvKpV5h563gFUA/0" data-ratio="0.6640316205533597" data-w="" /><br />
                        制冷剂（冷媒）纯度鉴别仪</span>
                </p>
                <p>
                    <span style="font-size: 20px;">
                        <img src="/images/web/airIntro04.jpg" data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqukKEfib8tSPoQ3pQehYv9VGk0k8saGvhXLnGZkf1AuB2fsib2nx8tJvHmv5LGCwWg9mYLMPjMog8Ww/0" data-ratio="1.3339920948616601" data-w="" /><br />
                        制冷剂（冷媒）回收机</span>
                </p>
                <p>
                    <span style="font-size: 20px;">
                        <img src="/images/web/airIntro05.jpg" data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqukKEfib8tSPoQ3pQehYv9VGqjSiciboA5cT3ib38epyyiaRzSGp9Z3aVroHOibEFEupqY58Xdk9h1LTmEQ/0" data-ratio="1.7450592885375493" data-w="" /><br />
                        防冻液冰点测试仪、冰点测试仪画面</span>
                </p>
                <p>
                    <span style="font-size: 20px;">
                        <img src="/images/web/airIntro06.jpg" data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqukKEfib8tSPoQ3pQehYv9VGlpd5taVIbskbpJAZdXI6DrrHwIJae004WOwrIXoLMC5Dcm4o8rt7ZA/0" data-ratio="1.3339920948616601" data-w="" /><br />
                        汽车空调出风口风量检测仪</span>
                </p>
                <p>
                    <span style="font-size: 20px;">
                        <img src="/images/web/airIntro07.jpg" data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqukKEfib8tSPoQ3pQehYv9VGqbjV20qdtbvEO1aFO4jzlRTiaibPs0iamgbJXHfq4wf01pREycJvkcICQ/0" data-ratio="0.7509881422924901" data-w="" /><br />
                        汽车空调出风口温度检测仪</span>
                </p>
                <p>
                    <span style="font-size: 20px;">
                        <img src="/images/web/airIntro08.jpg" data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqukKEfib8tSPoQ3pQehYv9VGXic0fPB57qunQHFHnN6NStF30rwM4iaHnvvzibiaicefxmqED4KYSlEOgzA/0" data-ratio="0.6640316205533597" data-w="" /><br />
                        汽车空调压缩机专用拆卸工具</span>
                </p>
                <p><span style="font-size: 20px;"></span></p>
                <p style=""><strong style="margin: 0px; padding: 0px; max-width: 100%; font-size: 20px; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;"></span></strong></p>
                <hr />
                <p style=""><strong style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: 宋体; box-sizing: border-box !important; word-wrap: break-word !important;">陕西永久汽车服务有限公司</span></strong></p>
                <p style=""><strong style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: 宋体; box-sizing: border-box !important; word-wrap: break-word !important;">中国一汽特约维修服务中心</span></strong></p>
                <p style="">
                    <strong>陕西永久汽车空调专业服务站</strong><br />
                </p>
                <p style=""><strong style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">地址</span></strong><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">：</span><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(51, 102, 255); box-sizing: border-box !important; word-wrap: break-word !important;">西安市未央区明光路南段</span><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: Verdana, sans-serif; color: rgb(51, 102, 255); box-sizing: border-box !important; word-wrap: break-word !important;">3</span><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(51, 102, 255); box-sizing: border-box !important; word-wrap: break-word !important;">号《交通事故快速理赔中心（北郊永久点）》</span></p>
                <p style=""><strong style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: 宋体; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">电话</span></strong><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: 宋体; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">：</span><strong style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: Arial, sans-serif; color: rgb(51, 102, 255); box-sizing: border-box !important; word-wrap: break-word !important;"><a href="tel:02986220693">029-86220693</a></span></strong><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: Arial, sans-serif; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;"> </span><strong style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: Arial, sans-serif; color: rgb(51, 102, 255); box-sizing: border-box !important; word-wrap: break-word !important;"></span><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(51, 102, 255); box-sizing: border-box !important; word-wrap: break-word !important;"><a href="tel:18192933995">18192933995</a></span></strong></p>
                <p style=""><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: Arial, sans-serif; box-sizing: border-box !important; word-wrap: break-word !important;"></span></p>
                <p style=""><strong style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">官方微信</span></strong><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">：</span><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: Arial, sans-serif; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">yj86220693</span></p>
                <p style=""><strong style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;"><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">网址</span></strong><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;">：</span><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: Arial, sans-serif; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;"><a href="http://www.yongjiu.co">www.yongjiu.co</a></span></p>
                <p style=""><span style="margin: 0px; padding: 0px; max-width: 100%; font-family: Arial, sans-serif; color: rgb(0, 112, 192); box-sizing: border-box !important; word-wrap: break-word !important;"></span></p>
                <p style="">
                    <br />
                </p>
                <p>
                    <span style="font-size: 20px;">
                        <br />
                    </span>
                    <br />
                </p>
            </div>
            <!--pj-->
            <div class="divbtn"><span class="btnspan"><a href="###"></a></span></div>
        </div>
        <b class="rbottom"><b class="r4"></b><b class="r3"></b><b class="r2"></b><b class="r1"></b></b>
    </div>
    <footer><a href="javascript:history.back()" id="fanhui"></a><a href="/index.aspx" id="home"></a><a href="javascript:void(null)" id="list"></a><a href="tel:02986220693" id="tel"></a><a href="http://map.baidu.com/mobile/webapp/index/index/foo=bar/vt=map" id="map"></a></footer>
    <script type="text/javascript" src="/assets/js/zepto.min.js"></script>
    <script type="text/javascript" src="/assets/js/banner.js"></script>
    <script type="text/javascript" src="/assets/js/touchslider.dev.js"></script>
    <script type="text/javascript" src="/assets/js/fastclick.js"></script>
</body>
</html>
