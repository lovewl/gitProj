<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="companyprofile.aspx.cs" Inherits="wxtest.UILayer.shanxiyongjiuPages.companyprofile" %>

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
            <h1>公司简介</h1>
        </div>
        <div role="main" class="ui-content">
            <img style="width: 100%" src="/assets/images/web/yongjiu01.jpg" alt="" height="200" />
            <hr />
            <p>
                <strong><span style="font-size: 18px; color: #FF9900;">公司简介</span><br />
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
                <strong><span style="font-size: 14px; color: #999999;">陕西永久汽车服务有限公司 是被中国一汽授予“一汽汽车（轿车）特约 维修中心”的企业，现公司座落在西安市未央区明光路南段3号，占地面积8850平方米。维修室内厂地面积近3000平方米，二十多年来，一直从事汽车维修服务，已发展成为一类品牌综合性的汽车维修企业，具有承接修理各种品牌高级轿车的能力。我公司以诚实守信、稳健发展，合规经营、依法纳税，坚持贯彻“服务第一、质量第一、信誉第一、安全第一”的经营理念，本着以“团结、务实、创新、奉献”的企业精神，从小到大、从单到全，逐步培养造就了一支拥有百余名专业化的汽车服务队伍。技术力量雄厚；购置了先进的现代化汽车维修和检测全套设备，现有各类维修设备65台，各类检测设备10台，维修技术实力雄厚。公司实行了全计算机管理操作模式，并具备一流的办公设施。</span></strong><br />
                <strong><span style="font-size: 14px; color: #999999;">2008年由陕西省保险行业协会组织、协调，由各财产保险公司指派查勘定损人员，在西安市北郊交通便利的地方，建立西安市快速理赔服务中心-永久服务点，快速理赔方式范围内的事故当事人，可以就近选择服务点办理保险理赔手。快速理赔服务中心工作时间为9：00-17：00，节假日正常提供服务。超过对外服务时间（包括夜间）发生的事故，当事人在向保险公司报案并填写协议书后，可拨打服务中心统一电话：<a style="text-decoration:none" href="tel:02982208122" target="_blank"><span style="font-size: 18px; color: #337FE5;">029-82208122</span></a>，共同将车辆放在“快速理赔服务中心”北郊服务点，约定第二天（24小时内）再到该点办理理赔手续。</span></strong><br />
                <strong><span style="font-size: 14px; color: #999999;">2012年于中国长春一汽合作，被正式授权为“一汽汽车（轿车）特约维修服务中心”，通过一汽轿车搭建的运营平台、管理平台、服务平台、技术平台，形成统一形象标准、统一服务标准、统一备品供应的一汽汽车特约维修服务站，主修：一汽大众、一汽澳迪、一汽丰田、一汽马自达、一汽轿车等车种。凭借先进的检测、诊断、维修设备，从初级保养、一、二级维护到专项修理、整车大修或车辆日常疑难故障的诊断、检测。</span></strong><br />
                <strong><span style="font-size: 14px; color: #999999;">2014年被安莱（北京）汽车科技研究院授权为“汽车空调专业服务站”，专业保养维修汽车空调，解决空调系统各种疑难杂症。</span></strong><br />
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
