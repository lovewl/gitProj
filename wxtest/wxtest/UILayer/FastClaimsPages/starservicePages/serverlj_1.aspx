<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serverlj_1.aspx.cs" Inherits="wxtest.UILayer.FastClaimsPages.starservicePages.serverlj_1" %>

<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <link href="/assets/lib/raty/css/jquery.raty.css" rel="stylesheet" type="text/css" />
    <style>
        .controlgroup-textinput {
            padding-top: .22em;
            padding-bottom: .22em;
        }

        .btn-disabled {
            pointer-events: none;
        }

        .error-text {
            font-weight: 700;
            color: red;
        }
    </style>
    <script src="/assets/lib/jquery-2.1.4/jquery-2.1.4.min.js"></script>
    <script src="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.js"></script>
    <script type="text/javascript" src="/assets/lib/raty/js/jquery.raty.js"></script>
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
            <h1>服务专员</h1>
        </div>
        <div role="main" class="ui-content">
            <img style="width: 100%" src="/assets/images/web/serverliujun.jpg" alt="" height="200" />
            <hr />
            <p>
                <strong><span style="font-size: 18px; color: #FF9900;">刘俊<br />
                    <span style="font-size: 12px; color: #FF9900;">服务专员等级：<span data-score="<%=DisplayStarts %>" data-number="5" id="raty"></span>(<%=DisplayStarts %> 分,满分5分)</span></span><br />
                    <span id="jnkc" style="color: #666666;"></span>
                    <script>setInterval("jnkc.innerHTML=new Date().toLocaleString() + ' 星期' + '天一二三四五六'.charAt(new Date().getDay());", 1000);</script>
                </strong>
                <script type="text/javascript">
                    $('#raty').raty({
                        //half: true,
                        readOnly: true,
                        score: function () {
                            return $(this).attr('data-score');
                        },
                        number: function () {
                            return $(this).attr('data-number');
                        },
                        path: '/assets/lib/raty/images',
                        hints: ['非常差', '差', '一般', '满意', '非常满意'],
                        // click: function(score, evt) {
                        //   alert('ID: ' + this.id + "\nscore: " + score + "\nevent: " + evt);
                        //   return false;
                        // }
                    });
                </script>
            </p>
            <p>
                <strong><span style="font-size: 14px; color: #999999;">您如果在行驶途中发生轻微交通事故，不知如何处理时，请拨打我的电话：<br />
                    <a style="text-decoration:none" href="tel:15291570239"><span style="font-size: 18px;">15291570239</span></a><br />
                    我是快赔专员，刘俊。很高兴为行驶在路上的您，提供满意的服务！</span></strong><br />
            </p>
            <form action="serverlj_1.aspx" method="post">
                <section>
                    <h2>评价信息</h2>
                    <div data-role="controlgroup" data-type="horizontal">
                        <button class="btn-disabled">姓名</button>
                        <input type="text" name="name" data-wrapper-class="controlgroup-textinput ui-btn" placeholder="请输入姓名" /><span class="error-text"><%=InputName %></span>
                    </div>
                    <div data-role="controlgroup" data-type="horizontal">
                        <button class="btn-disabled">电话</button>
                        <input type="text" name="tel" data-wrapper-class="controlgroup-textinput ui-btn" placeholder="请输入电话" /><span class="error-text"><%=InputTel %></span>
                    </div>
                    <div data-role="controlgroup" data-type="horizontal" data-mini="true">
                        <input type="radio" name="pjstar" id="pjstara" value="1">
                        <label for="pjstara">非常差</label>
                        <input type="radio" name="pjstar" id="pjstarb" value="2">
                        <label for="pjstarb">差</label>
                        <input type="radio" name="pjstar" id="pjstarc" value="3" checked="checked">
                        <label for="pjstarc">一般</label>
                        <input type="radio" name="pjstar" id="pjstard" value="4">
                        <label for="pjstard">满意</label>
                        <input type="radio" name="pjstar" id="pjstare" value="5">
                        <label for="pjstare">非常满意</label>
                    </div>
                    <%=InputSatis %>
                    <div style="width: 100%; border: 0px solid red;">
                        <h4><strong>评价内容</strong></h4>
                        <textarea rows="4" cols="25" style="border: 1px solid #CCC;" name="memo" placeholder="请输入评价内容"></textarea>
                    </div>
                </section>
                <input type="submit" value="提交评价" />
            </form>
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
