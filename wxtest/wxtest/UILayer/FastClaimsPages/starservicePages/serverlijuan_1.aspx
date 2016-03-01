<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serverlijuan_1.aspx.cs" Inherits="wxtest.UILayer.FastClaimsPages.starservicePages.serverlijuan_1" %>

<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/css/mian.css" rel="stylesheet" type="text/css" />
    <link href="/assets/lib/raty/css/jquery.raty.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        a:link {
            font-size: 24px;
            color: #337FE5;
            text-decoration: none;
        }

        a:visited {
            font-size: 24px;
            color: #337FE5;
            text-decoration: none;
        }

        a:hover {
            font-size: 24px;
            color: #999999;
            text-decoration: underline;
        }

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
    </style>
</head>
<body style="padding-top: 0; padding-bottom: 50px">
    <div class="zhezhao"></div>
    <div class="nav">
        <h1>网站导航</h1>
        <ul>
            <li><a href="/UILayer/FastClaims.aspx">快速理赔</a></li>
            <li><a href="/UILayer/shanxiyongjiu.aspx">陕西永久</a></li>
            <li><a href="/UILayer/AirConditioning.aspx">空调专修</a></li>
        </ul>
    </div>
    <div class="RoundedCorner">
        <b class="rtop"><b class="r1"></b><b class="r2"></b><b class="r3"></b><b class="r4"></b></b>
        <div class="divall">
            <div class="divimg">
                <a href="/UILayer/FastClaimsPages/starservicePages/serverlijuan_1.aspx">
                    <img src="/images/web/serverlijuan.jpg" alt="" height="200" /></a>
            </div>
            <hr style="color: red;">
            <div class="divtitle">
                <span class="titlespan">李娟<br />
                    服务专员等级：<span data-score="<%=DisplayStarts %>" data-number="5" id="raty"></span>(<%=DisplayStarts %> 分,满分5分)</span><span class="titlestarspan">
                    </span>
            </div>
            <div class="divtime">
                <span class="timespan"><%= DateStr %></span>
                <!--
 			<span class="timespan">点右侧关注</span>
 			<a href="javascript:addWxContact('gh_7a12dbcb812b');" id="post-user" class="activity-meta">
 				<span class="text-ellipsis"></span><i class="icon_link_arrow"></i>
 			</a>
 			-->
            </div>
            <div class="divcontent">
                <p style="font-family: sans-serif; font-size: 16px;">
                    <strong><span style="font-family: 宋体;"></span></strong>
                </p>
                <p style="font-family: sans-serif; font-size: 16px;">
                    <strong><strong><span style="font-family: 宋体;"><strong></strong></span></strong></strong>
                </p>
                <p style="font-family: sans-serif; font-size: 16px;">
                    <strong><strong><strong><strong><span style="color: #000000; font-size: 24px;">您如果在行驶途中发生轻微交通事故，不知如何处理时，请拨打我的</span></strong><strong><span style="color: #000000; font-size: 24px;">电话：</span></strong> </strong></strong></strong>
                </p>
                <span style="color: #0070C0; background-color: #FFFFFF;"><strong><span style="font-family: 宋体;"></span></strong><strong><span style="font-family: Tahoma, sans-serif; text-decoration: underline;"></span></strong><span style="font-size: 18px;"><strong><span style="text-decoration: underline;"><span style="color: #000000; font-size: 24px;"><a href="tel:18220856508">18220856508</a></span><img alt="" src="/images/web/6.gif" border="0" /><br>
                </span></strong></span></span><strong><span style="color: #0070C0; font-family: 宋体; text-decoration: underline;"></span></strong>
                <p>
                    <strong><strong><span style="color: #7030A0; font-family: 宋体; font-size: 18px;"><span style="color: #000000; font-size: 24px;">我是快赔专员，李娟。</span></span></strong></strong>
                </p>
                <p style="font-family: sans-serif; font-size: 16px;">
                    <strong><strong><span style="color: #7030A0; font-family: 宋体; font-size: 18px;"><span style="color: #000000; font-size: 24px;">进入快赔半年之久，开朗的性格，热情的服务以及快赔的所有流程处理，都足以让我快速的为您服务！熟悉车险理赔各个保险公司的最新政策.</span></span></strong></strong>
                </p>
                <p>
                    <br>
                </p>
                <p style="text-align: justify; font-family: sans-serif; font-size: 16px;">
                    <strong><span style="color: red; font-family: Arial, sans-serif; background-color: yellow;"></span></strong><strong><span style="color: red; font-family: 宋体; background-color: yellow;"></span></strong>
                </p>
                <p style="text-align: justify; margin-left: 0cm;">
                    <strong></strong><strong><span style="background-color: #FFE500;"></span></strong>
                </p>
            </div>
            <form action="servercz_1.aspx" method="post">
                <div class="divcontent" style="border: 0px solid red;">
                    <hr />
                    <div class="titlespan">评价信息</div>
                    <div>
                        姓名<input type="text" name="name" style="border: 1px solid #CCC;" /><%=InputName %>
                        <br />
                        电话<input type="text" name="tel" style="border: 1px solid #CCC;" /><%=InputTel %>
                    </div>
                    <div>
                        非常差<input type="radio" name="pjstar" value="1" />
                        差<input type="radio" name="pjstar" value="2" />
                        一般<input type="radio" name="pjstar" value="3" checked />
                        满意<input type="radio" name="pjstar" value="4" />
                        非常满意<input type="radio" name="pjstar" value="5" />
                    </div>
                    <%=InputSatis %>
                    <div style="width: 100%; border: 0px solid red;">
                        <textarea rows="4" cols="25" style="border: 1px solid #CCC" name="memo"></textarea>
                    </div>
                </div>
                <input type="submit" value="提交评价" />
            </form>
        </div>
        <b class="rbottom"><b class="r4"></b><b class="r3"></b><b class="r2"></b><b class="r1"></b></b>
    </div>
    <div style="text-align: center">
        <a style="color: rgb(94, 94, 94); font-size: 12px;" href="#">陕西永久汽车服务<br />
            <small>您是第</small>  <%= ReadTimes %> <small>位访客</small></a>
    </div>
    <footer><a href="javascript:history.back()" id="fanhui"></a><a href="/index.aspx" id="home"></a><a href="javascript:void(null)" id="list"></a><a href="tel:02986220693" id="tel"></a><a href="http://map.baidu.com/mobile/webapp/index/index/foo=bar/vt=map" id="map"></a></footer>
    <script type="text/javascript" src="/assets/js/jquery-1.11.2.min.js"></script>
    <script type="text/javascript" src="/assets/js/zepto.min.js"></script>
    <script type="text/javascript" src="/assets/js/banner.js"></script>
    <script type="text/javascript" src="/assets/js/touchslider.dev.js"></script>
    <script type="text/javascript" src="/assets/js/fastclick.js"></script>
    <script type="text/javascript" src="/assets/lib/raty/js/jquery.raty.js"></script>

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
</body>
</html>
