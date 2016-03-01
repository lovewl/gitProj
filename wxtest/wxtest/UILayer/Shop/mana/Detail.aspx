<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="wxtest.UILayer.Shop.mana.Detail" %>

<!DOCTYPE html>
<html runat="server" lang="zh-CN">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->
    <title>商品详细</title>

    <!-- Bootstrap -->
    <link rel="stylesheet" href="//cdn.bootcss.com/bootstrap/3.3.5/css/bootstrap.min.css">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="//cdn.bootcss.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="//cdn.bootcss.com/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body runat="server">
    商品名称：<%=ItemName %><br />
    数量：<%=Counts %><br />
    联系人：<%=UserName %><br />
    联系电话：<%=UserTel %><br />
    车型：<%=Models %><br />
    车牌号：<%=License %><br />
    下单时间：<%=CreateDate %><br />
    编号型号：<%=ProductModels %><br />
    产品名称：<%=ProductName %><br />
    适用车型：<%=ApplicableModels %><br />
    单位：<%=Unit %><br />
    下单时间：<%=Original %><br />
    <form runat="server" method="post">
        <input class="sr-only" type="text" name="itemId1" value="<%=ItemId1 %>"/>
        <button class="btn btn-default btn-lg" type="submit">删除</button>
        <button class="btn btn-default btn-lg" onclick="history.back()">返回</button>
    </form>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="//cdn.bootcss.com/jquery/1.11.3/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="//cdn.bootcss.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</body>
</html>
