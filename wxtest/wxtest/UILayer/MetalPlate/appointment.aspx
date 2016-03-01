<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="appointment.aspx.cs" Inherits="wxtest.UILayer.MetalPlate.appointment" %>

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
            <h1>钣喷快修首页</h1>
        </div>
        <div role="main" class="ui-content">
            <div class="container">
                <div class="wrap">
                    <p class="bxpq-info">
                        亲，<br>
                        灰常高兴为您提供“零耗时零费用”车险定损直赔一条龙修车服务，为节约您的宝贵时间，修车之前请准备好以下资料 ：<br>
                        一，单方事故：<br>
                        1，主车行驶本 2，主责方驾驶本 3，身份证原件 4，被保险人身份证原件 5，商业险保单6，交强险保单。<br>
                        二，双方事故：<br>
                        1，对方行驶本 2， 驾驶本 3，交强险保单 （最好有交警责任事故认定书）<br>
                        <span style="padding-top: 10px; display: block;">拍照注意事项：事故现场全景照片（包含车辆和周围环境）前后左右四个角度各一张，事故细节照片至少一张。</span>
                        <span class="tel">理赔专员电话：4000719711</span>
                    </p>
                    <form action="appointment.aspx?m=service&a=appointment" method="post" runat="server" enctype="multipart/form-data" name="upfile" id="upfile">
                        <div class="upload-box">
                            <h2 class="title">请上传车辆受损照片</h2>
                            <input type="file" name="files01" id="files01" multiple runat="server" />
                            <%--<div class="pag mauto">
                                <div class="form clearfix" id="upmain1">
                                    <div id="uphidden1"></div>
                                    <div class="img_up_wrap">
                                        <div id="uploaded_wrap1" class="uploaded_wrap">
                                            <a href="javascript:;" class="up-ico-wrap">
                                                <img src="/Public/wap/images/upload_img.png" style="margin-top: 25px; height: 30px;">
                                                <input type="file" accept="image/*" id="captureFile1" capture="camera" class="up-ico-input" runat="server">
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>--%>
                        </div>
                        <div class="upload-box">
                            <h2 class="title">撞车现场照片（能提供最好）</h2>
                            <div class="pag mauto">
                                <div class="form clearfix" id="upmain2">
                                    <div id="uphidden2"></div>
                                    <div class="img_up_wrap">
                                        <div id="uploaded_wrap2" class="uploaded_wrap">
                                            <a href="javascript:;" class="up-ico-wrap">
                                                <img src="/Public/wap/images/upload_img.png" style="margin-top: 25px; height: 30px;">
                                                <input type="file" accept="image/*" id="captureFile2" capture="camera" class="up-ico-input" runat="server">
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div style="margin: 20px 10px 15px 10px">
                            <input class="upload-submit" type="submit" value="预约">
                        </div>
                    </form>
                </div>
            </div>

            <hr />
            <footer style="text-align: center">
                <p>
                    &copy; <%=DateTime.Now.Year %> - 永久钣喷快修服务连锁<br />
                    <%--<small>您是第</small>  <%= ReadTimes %> <small>位访客</small>--%>
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
