<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeiXinManager.aspx.cs" Inherits="wxtest.UILayer.WeiXinManager" %>

<!DOCTYPE html>
<html lang="zh-CN">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->
    <title>微信管理</title>

    <!-- Bootstrap -->
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="http://cdn.bootcss.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="http://cdn.bootcss.com/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <h1 class="text-center"><span class="glyphicon glyphicon-edit"></span>微信管理</h1>
    <div class="container">
        <div class="row">
            <div class="col-sm-3">
                <p>获取微信开发者权限</p>
            </div>
            <div class="col-sm-3">
                <p>获取关注的微信用户列表</p>
            </div>
            <div>
                <textarea id="texta1"></textarea>
                <asp:Literal Text="<p><img src=&quot;/images/web/index01.jpg&quot; /><strong>I love ASP. NET!</strong></p>" Mode="Encode" ID="Literal1" runat="server"></asp:Literal>
                <asp:Label ID="Label1" runat="server" Text="<p><img src=&quot;/images/web/index01.jpg&quot; /><strong>I love ASP. NET!</strong></p>"></asp:Label>
            </div>
            <div class="col-sm-6">
                <div class="btn-group">
                    <button class="btn btn-default btn-sm" onclick="test1()">默认样式</button>
                    <button class="btn btn-primary btn-sm">首选样式</button>
                    <button class="btn btn-info btn-sm">提示样式</button>
                    <button class="btn btn-warning btn-sm">警告样式</button>
                    <button class="btn btn-danger btn-sm">危险样式</button>
                    <form runat="server" method="post">
                        <input type="submit" />
                    </form>
                </div>
            </div>
        </div>
    </div>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="/assets/js/jquery-1.11.2.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="/assets/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        function test1() {
            //var text = document.getElementById("texta1");
            //var msg = text.value;
            //alert(msg);
            //var text1 = document.getElementById("Label1");
            //var msg1 = text1.textContent;
            //alert("msg1" + msg1);
            var test = document.getElementsByTagName('div')[0].outerHTML;
            alert(test);
            //var text2 = document.getElementById("Literal1");
            //alert("Literal1" + text2);
            //var text21 = document.getElementById("Label1");
            //alert("Label21" + text21);
            //var mo = text2.getAttribute(["Mode"]).valueOf();
            //alert(mo);
        }
    </script>
</body>
</html>
