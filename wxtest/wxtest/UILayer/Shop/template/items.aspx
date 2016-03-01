<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="items.aspx.cs" Inherits="wxtest.UILayer.Shop.template.items" %>

<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/lib/jquery-mobile-1.4.5/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
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
            <h1>在线商城</h1>
        </div>
        <div role="main" class="ui-content">
            <form class="form-inline" id="form1" runat="server">
                <div class="thumbnail">
                    <div class="page-header">
                        <h1 style="text-overflow: ellipsis; overflow: hidden; white-space: nowrap"><%= commodity.Name %></h1>
                        <h1 style="text-overflow: ellipsis; overflow: hidden; white-space: nowrap"><small><%= commodity.Introduce %></small></h1>
                    </div>
                    <div style="text-align:center"><img src="<%= commodity.ImgPath %>" alt="..." /></div>
                    <div class="caption">
                        <h5><small style="text-decoration: line-through">原价：<%= (double.Parse(commodity.Price) + 50).ToString("C") %></small></h5>
                        <h2 style="color: red;">优惠价：&yen;<strong id="price"><%=commodity.Price %></strong></h2>
                        <hr />
                        <h5><small>编号型号：<%=commodity.Models %></small></h5>
                        <h5><small>名称：<%=commodity.ProductName %></small></h5>
                        <h5><small>适用车型：<%=commodity.ApplicableModels %></small></h5>
                        <h5><small>单位：<%=commodity.Unit %></small></h5>
                        <hr />
                        <p><%= commodity.Introduce %></p>
                        <div data-role="controlgroup" data-type="horizontal">
                            <button class="btn-disabled">个&nbsp;数</button>
                            <input type="text" name="ItemCount" id="ItemCount" value="1" onchange="countChange(<%=commodity.Price %>)" data-wrapper-class="controlgroup-textinput ui-btn" /><span class="error-text"><%=InputCount %></span>
                        </div>
                        <div data-role="controlgroup" data-type="horizontal">
                            <button class="btn-disabled">姓&nbsp;名</button>
                            <input type="text" name="UserName" id="UserName" data-wrapper-class="controlgroup-textinput ui-btn" placeholder="请输入姓名" /><span class="error-text"><%=InputName %></span>
                        </div>
                        <div data-role="controlgroup" data-type="horizontal">
                            <button class="btn-disabled">电&nbsp;话</button>
                            <input type="text" name="UserTel" id="UserTel" data-wrapper-class="controlgroup-textinput ui-btn" placeholder="请输入电话" /><span class="error-text"><%=InputTel %></span>
                        </div>
                        <div data-role="controlgroup" data-type="horizontal">
                            <button class="btn-disabled">车&nbsp;型</button>
                            <input type="text" name="Models" id="Models" data-wrapper-class="controlgroup-textinput ui-btn" placeholder="请输入车型" />
                        </div>
                        <div data-role="controlgroup" data-type="horizontal">
                            <button class="btn-disabled">车牌号</button>
                            <input type="text" name="License" id="License" data-wrapper-class="controlgroup-textinput ui-btn" placeholder="请输入车牌号" />
                        </div>
                        <div style="text-align:center" data-role="controlgroup" data-type="horizontal">
                            <input type="submit" value="购买" />
                            <input type="reset" value="取消" />
                        </div>
                    </div>
                </div>
            </form>
            <script>
                function countChange(a1) {
                    $('#price').text(Number($('#ItemCount').val()) * a1);
                }
            </script>
        </div>
        <hr />
        <footer style="text-align: center">
            <p>
                &copy; <%=DateTime.Now.Year %> - 陕西永久汽车服务
            </p>
        </footer>
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
