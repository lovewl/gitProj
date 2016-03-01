<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="plateSelf.aspx.cs" Inherits="wxtest.UILayer.MetalPlate.plateSelf" %>

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
    <%--<script type="text/javascript" charset="utf-8" async="" data-requiremodule="jquery" src="/Public/wap/scripts/lib/vonder/jquery.js"></script>--%>
    <%--<script type="text/javascript" charset="utf-8" src="/Public/wap/scripts/lib/common.js"></script>--%>
    <script type="text/javascript" charset="utf-8" src="/Public/js/jweixin-1.0.0.js?v=1000"></script>
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
            <div id="pagecontent">
                <div class="paint-switch-body">
                    <div class="paint-switch-main cart-part" id="cart-part">
                        <div class="main_image">
                            <ul class="paint-switch-list" style="transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transform: translate3d(0px, 0px, 0px); transform: translate3d(0px, 0px, 0px);">

                                <li class="show" style="margin-left: 0px; transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transform: translate3d(0px, 0px, 0px); transform: translate3d(0px, 0px, 0px);">
                                    <p class="cart-img">
                                        <img src="/assets/images/web/metalplate/cart_part_01.png" alt="汽车部位">

                                        <a class="link zqcm" href="javascript:onse(1685);" data-reshowmark="left_body@1" data-part="1685"><i class="r"></i>E1-左前车门</a>
                                        <a class="link zhcm" href="javascript:onse(1688);" data-reshowmark="left_body@2" data-part="1688"><i class="l"></i>F1-左后车门</a>
                                        <a class="link zqyzb" href="javascript:onse(1681);" data-reshowmark="left_body@4" data-part="1681"><i class="l"></i>C1-左前翼子板</a>
                                        <a class="link zqb" href="javascript:onse(1708);" data-reshowmark="left_body@7" data-part="1708"><i class="r"></i>J1-左裙边</a>
                                        <a class="link zhyzb" href="javascript:onse(1683);" data-reshowmark="left_body@5" data-part="1683"><i class="r"></i>D1-左后翼子板</a>
                                    </p>
                                </li>
                                <li style="margin-left: 0px; display: list-item; transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transform: translate3d(757px, 0px, 0px); transform: translate3d(757px, 0px, 0px);">
                                    <p class="cart-img">
                                        <img src="/assets/images/web/metalplate/cart_part_02.png" alt="汽车部位">

                                        <a class="link yhcm" href="javascript:onse(1700);" data-reshowmark="right_body@1" data-part="1700"><i class="r"></i>F2-右后车门</a>
                                        <a class="link yqcm" href="javascript:onse(1687);" data-reshowmark="right_body@2" data-part="1687"><i class="l"></i>E2-右前车门</a>
                                        <a class="link yhyzb" href="javascript:onse(1684);" data-reshowmark="right_body@4" data-part="1684"><i class="l"></i>D2-右后翼子板</a>
                                        <a class="link yqyzb" href="javascript:onse(1699);" data-reshowmark="right_body@5" data-part="1699"><i class="r"></i>C2-右前翼子板</a>
                                        <a class="link yqb" href="javascript:onse(1694);" data-reshowmark="right_body@7" data-part="1694"><i class="r"></i>J2-右裙边</a>
                                    </p>
                                </li>
                                <li style="margin-left: 0px; display: list-item; transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transform: translate3d(1514px, 0px, 0px); transform: translate3d(1514px, 0px, 0px);">
                                    <p class="cart-img">
                                        <img src="/assets/images/web/metalplate/cart_part_03.png" alt="汽车部位">

                                        <a class="link zqbxg bxg_pq" href="javascript:onse(1676);" data-reshowmark="car_head@0" data-part="1676"><i class="r"></i>A2-左前保险杠</a>
                                        <a class="link yqbxg bxg_pq" href="javascript:onse(1675);" data-reshowmark="car_head@1" data-part="1675"><i class="l"></i>A1-右前保险杠</a>
                                        <a class="link qbxgqp bxg_pq" href="javascript:onse(1677);" data-reshowmark="car_head@2" data-part="1677"><i class="l"></i>A-前保险杠全喷</a>
                                    </p>
                                </li>
                                <li style="margin-left: 0px; display: list-item; transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transform: translate3d(2271px, 0px, 0px); transform: translate3d(2271px, 0px, 0px);">
                                    <p class="cart-img">
                                        <img src="/assets/images/web/metalplate/cart_part_04.png" alt="汽车部位">

                                        <a class="link zhbxg bxg_pq" href="javascript:onse(1679);" data-reshowmark="car_tail@0" data-part="1679"><i class="l"></i>B2-左后保险杠</a>
                                        <a class="link yhbxg bxg_pq" href="javascript:onse(1678);" data-reshowmark="car_tail@1" data-part="1678"><i class="r"></i>B1-右后保险杠</a>
                                        <a class="link hbxgqp bxg_pq" href="javascript:onse(1680);" data-reshowmark="car_tail@2" data-part="1680"><i class="l"></i>B-后保险杠全喷</a>
                                    </p>
                                </li>
                                <li style="margin-left: 0px; display: list-item; transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transform: translate3d(3028px, 0px, 0px); transform: translate3d(3028px, 0px, 0px);">
                                    <p class="cart-img">
                                        <img src="/assets/images/web/metalplate/cart_part_05.png" alt="汽车部位5">

                                        <a class="link hcg" href="javascript:onse(1707);" data-reshowmark="car_top@1" data-part="1707"><i class="l"></i>H-后车盖</a>
                                        <a class="link qcg" href="javascript:onse(1706);" data-reshowmark="car_top@0" data-part="1706"><i class="r"></i>G-前车盖</a>
                                        <a class="link cdg" href="javascript:onse(1692);" data-reshowmark="car_top@2" data-part="1692"><i class="r"></i>I-车顶</a>
                                    </p>
                                </li>
                                <li style="margin-left: 0px; display: list-item; transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transition: all 0s cubic-bezier(0.22, 0.69, 0.72, 0.88); -webkit-transform: translate3d(3785px, 0px, 0px); transform: translate3d(3785px, 0px, 0px);">
                                    <div class="other-part clear">
                                        <a class="cart-part-btn" href="javascript:onse(1740);" data-reshowmark="car_part@0" data-part="1740">K2-右后视镜<br>
                                            <span class="part-num" max="1">0</span>
                                        </a>
                                        <a class="cart-part-btn" href="javascript:onse(1695);" data-reshowmark="car_part@1" data-part="1695">K1-左后视镜<br>
                                            <span class="part-num" max="1">0</span>
                                        </a>
                                        <a class="cart-part-btn" href="javascript:onse(1705);" data-reshowmark="car_part@2" data-part="1705">Q-门把手<br>
                                            <span class="part-num" max="4">0</span>
                                        </a>
                                    </div>
                                </li>
                            </ul>
                        </div>
                        <div class="cart-part-dot">
                            <span class="on"></span>
                            <span></span>
                            <span></span>
                            <span></span>
                            <span></span>
                            <span></span>
                        </div>
                    </div>
                </div>
                <div class="c">
                    <div class="amount-warp l">
                        <span class="shop-cart l mr10" id="shop_cart_num"></span>
                        <span class="amount l money" id="amount" prefix="￥" subfix="">0</span>
                    </div>
                    <div class="r">
                        <input id="addtocart" type="button" value="预约" />
                    </div>
                </div>
            </div>
            <%--<script src="/Public/wap/scripts/lib/jquery/jquery-1.11.0.min.js"></script>--%>
            <script src="/Public/wap/scripts/lib/money.js"></script>
            <script>
                var amount = new Money($('#amount').html());
                var priceList = ({ "1677": { "id": "1677", "name": "A-\u524d\u4fdd\u9669\u6760\u5168\u55b7", "price": <%=Pricelist["1677"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1677"]%>", "p2": "<%=Pricelist["1677"]%>", "p3": "<%=Pricelist["1677"]%>", "p4": "<%=Pricelist["1677"]%>", "p5": "<%=Pricelist["1677"]%>", "p6": "<%=Pricelist["1677"]%>", "p7": "<%=Pricelist["1677"]%>", "p8": "<%=Pricelist["1677"]%>" },
                    "1675": { "id": "1675", "name": "A1-\u53f3\u524d\u4fdd\u9669\u6760", "price": <%=Pricelist["1675"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1675"]%>", "p2": "<%=Pricelist["1675"]%>", "p3": "<%=Pricelist["1675"]%>", "p4": "<%=Pricelist["1675"]%>", "p5": "<%=Pricelist["1675"]%>", "p6": "<%=Pricelist["1675"]%>", "p7": "<%=Pricelist["1675"]%>", "p8": "<%=Pricelist["1675"]%>" },
                    "1676": { "id": "1676", "name": "A2-\u5de6\u524d\u4fdd\u9669\u6760", "price": <%=Pricelist["1676"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1676"]%>", "p2": "<%=Pricelist["1676"]%>", "p3": "<%=Pricelist["1676"]%>", "p4": "<%=Pricelist["1676"]%>", "p5": "<%=Pricelist["1676"]%>", "p6": "<%=Pricelist["1676"]%>", "p7": "<%=Pricelist["1676"]%>", "p8": "<%=Pricelist["1676"]%>" },
                    "1680": { "id": "1680", "name": "B-\u540e\u4fdd\u9669\u6760\u5168\u55b7", "price": <%=Pricelist["1680"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1680"]%>", "p2": "<%=Pricelist["1680"]%>", "p3": "<%=Pricelist["1680"]%>", "p4": "<%=Pricelist["1680"]%>", "p5": "<%=Pricelist["1680"]%>", "p6": "<%=Pricelist["1680"]%>", "p7": "<%=Pricelist["1680"]%>", "p8": "<%=Pricelist["1680"]%>" },
                    "1678": { "id": "1678", "name": "B1-\u53f3\u540e\u4fdd\u9669\u6760", "price": <%=Pricelist["1678"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1678"]%>", "p2": "<%=Pricelist["1678"]%>", "p3": "<%=Pricelist["1678"]%>", "p4": "<%=Pricelist["1678"]%>", "p5": "<%=Pricelist["1678"]%>", "p6": "<%=Pricelist["1678"]%>", "p7": "<%=Pricelist["1678"]%>", "p8": "<%=Pricelist["1678"]%>" },
                    "1679": { "id": "1679", "name": "B2-\u5de6\u540e\u4fdd\u9669\u6760", "price": <%=Pricelist["1679"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1679"]%>", "p2": "<%=Pricelist["1679"]%>", "p3": "<%=Pricelist["1679"]%>", "p4": "<%=Pricelist["1679"]%>", "p5": "<%=Pricelist["1679"]%>", "p6": "<%=Pricelist["1679"]%>", "p7": "<%=Pricelist["1679"]%>", "p8": "<%=Pricelist["1679"]%>" },
                    "1681": { "id": "1681", "name": "C1-\u5de6\u524d\u7ffc\u5b50\u677f", "price": <%=Pricelist["1681"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1681"]%>", "p2": "<%=Pricelist["1681"]%>", "p3": "<%=Pricelist["1681"]%>", "p4": "<%=Pricelist["1681"]%>", "p5": "<%=Pricelist["1681"]%>", "p6": "<%=Pricelist["1681"]%>", "p7": "<%=Pricelist["1681"]%>", "p8": "<%=Pricelist["1681"]%>" },
                    "1699": { "id": "1699", "name": "C2-\u53f3\u524d\u7ffc\u5b50\u677f", "price": <%=Pricelist["1699"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1699"]%>", "p2": "<%=Pricelist["1699"]%>", "p3": "<%=Pricelist["1699"]%>", "p4": "<%=Pricelist["1699"]%>", "p5": "<%=Pricelist["1699"]%>", "p6": "<%=Pricelist["1699"]%>", "p7": "<%=Pricelist["1699"]%>", "p8": "<%=Pricelist["1699"]%>" },
                    "1683": { "id": "1683", "name": "D1-\u5de6\u540e\u7ffc\u5b50\u677f", "price": <%=Pricelist["1683"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1683"]%>", "p2": "<%=Pricelist["1683"]%>", "p3": "<%=Pricelist["1683"]%>", "p4": "<%=Pricelist["1683"]%>", "p5": "<%=Pricelist["1683"]%>", "p6": "<%=Pricelist["1683"]%>", "p7": "<%=Pricelist["1683"]%>", "p8": "<%=Pricelist["1683"]%>" },
                    "1684": { "id": "1684", "name": "D2-\u53f3\u540e\u7ffc\u5b50\u677f", "price": <%=Pricelist["1684"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1684"]%>", "p2": "<%=Pricelist["1684"]%>", "p3": "<%=Pricelist["1684"]%>", "p4": "<%=Pricelist["1684"]%>", "p5": "<%=Pricelist["1684"]%>", "p6": "<%=Pricelist["1684"]%>", "p7": "<%=Pricelist["1684"]%>", "p8": "<%=Pricelist["1684"]%>" },
                    "1685": { "id": "1685", "name": "E1-\u5de6\u524d\u8f66\u95e8", "price": <%=Pricelist["1685"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1685"]%>", "p2": "<%=Pricelist["1685"]%>", "p3": "<%=Pricelist["1685"]%>", "p4": "<%=Pricelist["1685"]%>", "p5": "<%=Pricelist["1685"]%>", "p6": "<%=Pricelist["1685"]%>", "p7": "<%=Pricelist["1685"]%>", "p8": "<%=Pricelist["1685"]%>" },
                    "1687": { "id": "1687", "name": "E2-\u53f3\u524d\u8f66\u95e8", "price": <%=Pricelist["1687"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1687"]%>", "p2": "<%=Pricelist["1687"]%>", "p3": "<%=Pricelist["1687"]%>", "p4": "<%=Pricelist["1687"]%>", "p5": "<%=Pricelist["1687"]%>", "p6": "<%=Pricelist["1687"]%>", "p7": "<%=Pricelist["1687"]%>", "p8": "<%=Pricelist["1687"]%>" },
                    "1688": { "id": "1688", "name": "F1-\u5de6\u540e\u8f66\u95e8", "price": <%=Pricelist["1688"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1688"]%>", "p2": "<%=Pricelist["1688"]%>", "p3": "<%=Pricelist["1688"]%>", "p4": "<%=Pricelist["1688"]%>", "p5": "<%=Pricelist["1688"]%>", "p6": "<%=Pricelist["1688"]%>", "p7": "<%=Pricelist["1688"]%>", "p8": "<%=Pricelist["1688"]%>" },
                    "1700": { "id": "1700", "name": "F2-\u53f3\u540e\u8f66\u95e8", "price": <%=Pricelist["1700"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1700"]%>", "p2": "<%=Pricelist["1700"]%>", "p3": "<%=Pricelist["1700"]%>", "p4": "<%=Pricelist["1700"]%>", "p5": "<%=Pricelist["1700"]%>", "p6": "<%=Pricelist["1700"]%>", "p7": "<%=Pricelist["1700"]%>", "p8": "<%=Pricelist["1700"]%>" },
                    "1706": { "id": "1706", "name": "G-\u524d\u8f66\u76d6", "price": <%=Pricelist["1706"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1706"]%>", "p2": "<%=Pricelist["1706"]%>", "p3": "<%=Pricelist["1706"]%>", "p4": "<%=Pricelist["1706"]%>", "p5": "<%=Pricelist["1706"]%>", "p6": "<%=Pricelist["1706"]%>", "p7": "<%=Pricelist["1706"]%>", "p8": "<%=Pricelist["1706"]%>" },
                    "1707": { "id": "1707", "name": "H-\u540e\u8f66\u76d6", "price": <%=Pricelist["1707"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1707"]%>", "p2": "<%=Pricelist["1707"]%>", "p3": "<%=Pricelist["1707"]%>", "p4": "<%=Pricelist["1707"]%>", "p5": "<%=Pricelist["1707"]%>", "p6": "<%=Pricelist["1707"]%>", "p7": "<%=Pricelist["1707"]%>", "p8": "<%=Pricelist["1707"]%>" },
                    "1692": { "id": "1692", "name": "I-\u8f66\u9876", "price": <%=Pricelist["1692"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1692"]%>", "p2": "<%=Pricelist["1692"]%>", "p3": "<%=Pricelist["1692"]%>", "p4": "<%=Pricelist["1692"]%>", "p5": "<%=Pricelist["1692"]%>", "p6": "<%=Pricelist["1692"]%>", "p7": "<%=Pricelist["1692"]%>", "p8": "<%=Pricelist["1692"]%>" },
                    "1708": { "id": "1708", "name": "J1-\u5de6\u88d9\u8fb9", "price": <%=Pricelist["1708"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1708"]%>", "p2": "<%=Pricelist["1708"]%>", "p3": "<%=Pricelist["1708"]%>", "p4": "<%=Pricelist["1708"]%>", "p5": "<%=Pricelist["1708"]%>", "p6": "<%=Pricelist["1708"]%>", "p7": "<%=Pricelist["1708"]%>", "p8": "<%=Pricelist["1708"]%>" },
                    "1694": { "id": "1694", "name": "J2-\u53f3\u88d9\u8fb9", "price": <%=Pricelist["1694"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1694"]%>", "p2": "<%=Pricelist["1694"]%>", "p3": "<%=Pricelist["1694"]%>", "p4": "<%=Pricelist["1694"]%>", "p5": "<%=Pricelist["1694"]%>", "p6": "<%=Pricelist["1694"]%>", "p7": "<%=Pricelist["1694"]%>", "p8": "<%=Pricelist["1694"]%>" },
                    "1695": { "id": "1695", "name": "K1-\u5de6\u540e\u89c6\u955c", "price": <%=Pricelist["1695"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1695"]%>", "p2": "<%=Pricelist["1695"]%>", "p3": "<%=Pricelist["1695"]%>", "p4": "<%=Pricelist["1695"]%>", "p5": "<%=Pricelist["1695"]%>", "p6": "<%=Pricelist["1695"]%>", "p7": "<%=Pricelist["1695"]%>", "p8": "<%=Pricelist["1695"]%>" },
                    "1740": { "id": "1740", "name": "K2-\u53f3\u540e\u89c6\u955c", "price": <%=Pricelist["1740"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1740"]%>", "p2": "<%=Pricelist["1740"]%>", "p3": "<%=Pricelist["1740"]%>", "p4": "<%=Pricelist["1740"]%>", "p5": "<%=Pricelist["1740"]%>", "p6": "<%=Pricelist["1740"]%>", "p7": "<%=Pricelist["1740"]%>", "p8": "<%=Pricelist["1740"]%>" },
                    "1705": { "id": "1705", "name": "Q-\u95e8\u628a\u624b", "price": <%=Pricelist["1705"]%>, "desc": "", "psz1": "0.00", "psz2": "0.00", "psz3": "0.00", "p1": "<%=Pricelist["1705"]%>", "p2": "<%=Pricelist["1705"]%>", "p3": "<%=Pricelist["1705"]%>", "p4": "<%=Pricelist["1705"]%>", "p5": "<%=Pricelist["1705"]%>", "p6": "<%=Pricelist["1705"]%>", "p7": "<%=Pricelist["1705"]%>", "p8": "<%=Pricelist["1705"]%>" }});

                function renew_price() {
                    var sumprice = new Money(0);
                    var carstyle = parseInt(1);
                    //var carsize = parseInt(0);
                    $('.paint-switch-list li:not(:first-child,:last-child) a[data-part].active').each(function () {
                        var price_id = $(this).data('part');
                        var num = 1;
                        if ($(this).find('.part-num').size()) {
                            num = parseInt($(this).find('.part-num').text());
                        }
                        var price = new Money(priceList[price_id]['p' + carstyle]);
                        //price.add(carsize > 0 ? priceList[price_id]['psz' + carsize] : 0);
                        price.mul(num);
                        sumprice.add(price);
                    });
                    //购物车数字
                    var shopNum = $('.paint-switch-list li:not(:first-child,:last-child) .active').length;
                    if (shopNum > 0) {
                        $('#shop_cart_num').addClass('no-img').html(shopNum);
                    }
                    if (shopNum == 0) {
                        $('#shop_cart_num').removeClass('no-img').html('');
                    }
                    $('#amount').html(sumprice.toDecimal());
                }
                renew_price();
                $(function () {
                    //保险杠喷漆
                    $('.bxg_pq').click(function () {
                        if (!$(this).hasClass('.active')) {
                            $(this).siblings('.bxg_pq').removeClass('active').removeClass('on');
                        }
                        renew_price();
                    });
                    //
                    $('.cart-part-btn').click(function () {
                        $(this).addClass('active');
                    });

                    //顶部切换项
                    $('.paint-switch-items .paint-tab').on('click', function () {
                        $(this).addClass('active').siblings().removeClass('active');
                        var i = $(this).index();
                        $('.paint-switch-main').eq(i).show().siblings().hide();
                        if (i == 1) {
                            $('.posit-foot').hide();
                            $('body').removeClass('pb51');
                        } if (i == 0) {
                            $('.posit-foot').show();
                            $('body').addClass('pb51');
                        }
                    });

                    //选择部位
                    $('#cart-part a[data-part]').click(function () {
                        var opr;
                        var num = 1;
                        if ($(this).find('.part-num').size()) { // 有维修数量的项目
                            var maxnum = parseInt($(this).find('.part-num').attr('max'));
                            var curnum = parseInt($(this).find('.part-num').html());
                            if (curnum < maxnum) {
                                opr = 'add';
                                if (!$(this).hasClass('active')) {
                                    $(this).addClass('active');
                                }
                                $(this).find('.part-num').html(curnum + 1);
                            } else {
                                num = maxnum;
                                opr = 'sub';
                                if ($(this).hasClass('active')) {
                                    $(this).removeClass('active');
                                }
                                $(this).find('.part-num').html('0');
                            }

                        } else {
                            if ($(this).hasClass('active')) {
                                opr = 'sub';
                                $(this).removeClass('active');
                            } else {
                                opr = 'add';
                                $(this).addClass('active');
                            }
                        }
                        renew_price();
                    });
                });
                var selecteddata = { "1740":0, "1695":0, "1705":0, "1685":0, "1688":0, "1681":0, "1708":0, "1683":0, "1700":0, "1687":0, "1684":0, "1699":0, "1694":0, "1676":0, "1675":0, "1677":0, "1679":0, "1678":0, "1680":0, "1707":0, "1706":0, "1692":0};
                function onse(partnumid){
                    partnumid = String(partnumid);
                    if (selecteddata[partnumid] == 1){
                        selecteddata[partnumid] = 0;
                    }else{
                        selecteddata[partnumid] = 1;
                    }
                }
            </script>
            <script src="/Public/wap/scripts/lib/vonder/require.min.js"></script>
            <script>
                var JQ = {
                    Think: {
                        tpl_public: '/Public/wap'
                    }
                };
                requirejs.config({
                    baseUrl: '/Public/wap/scripts/lib/',
                    paths: {
                        jquery: "vonder/jquery",
                    }
                });
                requirejs.onError = function (err) {
                    console.log(err.requireType);
                    if (err.requireType === 'timeout') {
                        console.log('modules: ' + err.requireModules);
                    }
                    throw err;
                };
                require(['jquery'], function ($) {
                    //添加到购物车
                    $('#addtocart').click(function () {
                        $.post("plateSelf.aspx?modeli=<%=Modelid%>", selecteddata, function (rs1, rs2, rs3) {
                            if (rs3.readyState == 4 && rs3.status == 200) {
                                window.location = rs1;
                            } else {
                                window.location = "index.aspx";
                            }
                        });
                    });
                });
            </script>
            <script src="/Public/wap/scripts/lib/jquery/swipeSlide.min.js"></script>
            <script type="text/javascript">
                $(function () {
                    $(".main_image li").each(function () {
                        var ww = $(".main_image").width();
                        var w = $(this).width();
                        var ml = Math.round((parseInt(ww) - parseInt(w)) / 2);
                        $(this).css({ marginLeft: ml + "px" })
                    });
                    $('.paint-switch-list li').show();
                    $('.main_image').swipeSlide({
                        continuousScroll: true,
                        speed: 2500000,
                        transitionType: 'cubic-bezier(0.22, 0.69, 0.72, 0.88)',
                        callback: function (i) {
                            $('.cart-part-dot').children().eq(i).addClass('on').siblings().removeClass('on');
                        }
                    });
                })
            </script>
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
