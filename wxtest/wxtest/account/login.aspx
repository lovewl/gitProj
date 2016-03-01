<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="wxtest.account.login" %>

<!DOCTYPE html>
<html lang="en" class="no-js">
    <head>
        <meta charset="utf-8">
        <title>陕西永久登录页面</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <!-- CSS -->
        <link rel="stylesheet" href="/assets/css/reset.css">
        <link rel="stylesheet" href="/assets/css/supersized.css">
        <link rel="stylesheet" href="/assets/css/style.css">

        <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
        <!--[if lt IE 9]>
            <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
        <![endif]-->

    </head>

    <body>
        <div class="page-container">
            <h1>登录</h1>
            <form action="login.aspx" method="post" runat="server">
                <input type="text" name="username" class="username" placeholder="用户名" autofocus>
                <input type="password" name="password" class="password" placeholder="密码">
                <p style="color: forestgreen; font-size:large">
                    <%=Message %>
                </p>
                <button type="submit">登陆</button>
                <div class="error"><span>+</span></div>
            </form>
            <% if (HasReg != "0") { %>
            <button onclick="Reg()">注册</button>
            <%} %>
        </div>
		
        <!-- Javascript -->
        <script src="/assets/js/jquery-1.11.2.min.js"></script>
        <script src="/assets/js/supersized.3.2.7.min.js"></script>
        <script src="/assets/js/supersized-init.js"></script>
        <script src="/assets/js/scripts.js"></script>
        <script>
            function Reg() {
                location.href = "register.aspx";
            }
        </script>
    </body>

</html>