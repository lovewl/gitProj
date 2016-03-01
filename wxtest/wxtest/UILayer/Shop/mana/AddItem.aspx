<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="wxtest.UILayer.Shop.mana.AddItem" %>

<!DOCTYPE html>
<html runat="server" lang="zh-CN">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->
    <title>添加商品</title>

    <!-- Bootstrap -->
    <link rel="stylesheet" href="//cdn.bootcss.com/bootstrap/3.3.5/css/bootstrap.min.css">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="//cdn.bootcss.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="//cdn.bootcss.com/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form class="form-inline" runat="server" method="post">
        <div class="form-group">
            <label for="InputItemId">Id</label>
            <input type="text" class="form-control" id="InputItemProductId" name="InputItemProductId" placeholder="商品编号">
        </div>
        <div class="form-group">
            <label for="InputItemName">名称</label>
            <input type="text" class="form-control" id="InputItemName" name="InputItemName" placeholder="商品名称">
        </div>
        <div class="form-group">
            <label for="InputItemIntroduce">介绍</label>
            <input type="text" class="form-control" id="InputItemIntroduce" name="InputItemIntroduce" placeholder="商品描述">
        </div>
        <div class="form-group">
            <label for="InputFile">商品图片</label>
            <input type="file" id="InputFile" name="InputFile" runat="server">
            <p class="help-block">请选择jpg图片</p>
        </div>
        <div class="form-group">
            <label for="InputItemIntroduce">价格</label>
            <input type="text" class="form-control" id="InputItemPrice" name="InputItemPrice" placeholder="商品价格">
        </div>
        <div class="form-group">
            <label for="InputItemIntroduce">编号型号</label>
            <input type="text" class="form-control" id="InputItemModels" name="InputItemModels" placeholder="编号型号">
        </div>
        <div class="form-group">
            <label for="InputItemIntroduce">产品名称</label>
            <input type="text" class="form-control" id="InputItemProductName" name="InputItemProductName" placeholder="产品名称">
        </div>
        <div class="form-group">
            <label for="InputItemIntroduce">适用车型</label>
            <input type="text" class="form-control" id="InputItemApplicableModels" name="InputItemApplicableModels" placeholder="适用车型">
        </div>
        <div class="form-group">
            <label for="InputItemIntroduce">数量单位</label>
            <input type="text" class="form-control" id="InputItemUnit" name="InputItemUnit" placeholder="数量单位">
        </div>
        <div class="form-group">
            <label for="InputItemIntroduce">原价</label>
            <input type="text" class="form-control" id="InputItemOriginal" name="InputItemOriginal" placeholder="原价">
        </div>
        <div class="form-group">
            <label for="InputItemIntroduce">库存数量</label>
            <input type="text" class="form-control" id="InputItemStock" name="InputItemStock" placeholder="库存数量">
        </div>
        <button type="submit" class="btn btn-default">添加</button>
    </form>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="//cdn.bootcss.com/jquery/1.11.3/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="//cdn.bootcss.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</body>
</html>
