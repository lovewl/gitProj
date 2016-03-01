<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="wxtest.Web.Evaluation.index" %>

<!DOCTYPE html>
<html lang="zh-CN">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->
    <title>客户评价</title>

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
    <asp:Repeater runat="server" ID="rptMessageList">
        <ItemTemplate>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-1">
                        <div class="thumbnail">
                            <img style="width: 64px; height: 64px;" src="/images/web/1.jpg" alt="...">
                            <div class="caption">
                                <h4>昵称<%# Eval("Id") %></h4>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-10">
                        <ul class="list-group">
                            <li class="list-group-item"><%# Eval("CreateTime") %></li>
                            <li class="list-group-item">
                                Dapibus ac facilisis in<br />
                                <%# Eval("Id") %><br />
                                <%# Eval("TargetObj") %><br />
                                <%# Eval("SourceObj") %><br />
                                <%# Eval("Tel") %><br />
                                <%# Eval("ImgPath") %><br />
                                <%# Eval("CreateTime") %><br />
                                <%# Eval("ContentMSG") %><br />
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="//cdn.bootcss.com/jquery/1.11.3/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="//cdn.bootcss.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</body>
</html>
