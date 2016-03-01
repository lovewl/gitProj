<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manager.aspx.cs" Inherits="wxtest.UILayer.Shop.mana.manager" %>

<!DOCTYPE html>
<html lang="zh-CN">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->
    <title>商城管理</title>

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
    <div class="list-group">
        <a class="btn btn-primary list-group-item" role="button" data-toggle="collapse" href="#collapseOne1" aria-expanded="false" aria-controls="collapseOne1" id="headingOne">全部订单
        </a>
        <div id="collapseOne1" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingOne">
            <div class="panel-body">
                <table class="table table-bordered">
                    <tr>
                        <th>名称</th>
                        <th>数量</th>
                        <th>联系人</th>
                        <th>电话</th>
                    </tr>
                    <asp:Repeater runat="server" ID="reItems">
                        <ItemTemplate>
                            <tr onclick="detail(<%#Eval("Id") %>)">
                                <td><%#GetProductName(Eval("ProductId").ToString()) %></td>
                                <td><%#Eval("ProductNumbers") %></td>
                                <td><%#Eval("Name") %></td>
                                <td><%#Eval("Tel") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
        <a class="btn btn-primary list-group-item collapsed" role="button" data-toggle="collapse" href="#collapseOne2" aria-expanded="false" aria-controls="collapseOne2" id="headingTwo">全部商品</a>
        <div id="collapseOne2" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
            <div class="panel-body">
                <table class="table table-bordered">
                    <tr>
                        <th>商品编号</th>
                        <th>名称</th>
                        <th>价格</th>
                        <th>库存</th>
                    </tr>
                    <asp:Repeater runat="server" ID="Repeater1">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("ProductId") %></td>
                                <td><%#Eval("Name") %></td>
                                <td><%#Eval("Price") %></td>
                                <td><%#Eval("Stock") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
        <a class="btn btn-primary list-group-item collapsed" role="button" data-toggle="collapse" href="#collapseOne3" aria-expanded="false" aria-controls="collapseOne3" id="headingThree">添加商品
        </a>
        <div id="collapseOne3" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
            <div class="panel-body">
                <a class="btn btn-default" href="AddItem.aspx">添加商品</a>
            </div>
        </div>
        <a class="btn btn-primary list-group-item collapsed" role="button" data-toggle="collapse" href="#collapseOne4" aria-expanded="false" aria-controls="collapseOne4" id="headingFour">删除商品
        </a>
        <div id="collapseOne4" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFour">
            <div class="panel-body">
                <form runat="server" method="post">
                    <input class="form-control" type="text" id="txtDelete" name="txtDelete" placeholder="请输入商品编号" />
                    <button class="form-control" type="submit">删除</button>
                </form>
            </div>
        </div>
    </div>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="//cdn.bootcss.com/jquery/1.11.3/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="//cdn.bootcss.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <script>
        function detail(id) {
            location.href = "/UILayer/Shop/mana/Detail.aspx?itemId=" + id;
        }
    </script>
</body>
</html>
