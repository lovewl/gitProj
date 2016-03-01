<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="wxtest.account.register" %>

<!DOCTYPE html>
<html lang="en" class="no-js">
<head>
    <meta charset="utf-8">
    <title>陕西永久注册页面</title>
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
        <h1>注册</h1>
        <form action="register.aspx" method="post" runat="server">
            <%--<input type="text" name="username" placeholder="用户名" onchange="inputing()" required autofocus>--%>
            <input type="text" name="username" placeholder="手机号码" onchange="inputing()" required autofocus>
            <input type="text" name="name" placeholder="真实姓名" hidden value="">
            <input type="text" name="mobile" placeholder="手机号码" hidden value="">
            <input type="password" name="password" class="password" placeholder="密码" required>
            <input type="password" name="confirm" class="password" placeholder="确认密码" required>
            <div class="input-group">
                <input type="text" name="vcode" placeholder="验证码" required>
                <span style="padding: 0 2px; cursor: pointer">
                    <img id="vcode_img" src="/handlers/vcode.ashx" data-src="/handlers/vcode.ashx" width="100" height="32" alt="验证码" title="点击切换验证码">
                </span>
                <p>
                    <h1 id="msg" style="color: forestgreen;"><%=Message %></h1>
                </p>
            </div>
            <input type="hidden" name="redirect" value="<%=Request.QueryString["redirect"] %>" />
            <button type="submit">提交</button>
            <div class="error"><span>+</span></div>
        </form>
    </div>

    <!-- Javascript -->
    <script src="/assets/js/jquery-1.11.2.min.js"></script>
    <script src="/assets/js/supersized.3.2.7.min.js"></script>
    <script src="/assets/js/supersized-init.js"></script>
    <script src="/assets/js/scripts.js"></script>
    <script>
        $('#vcode_img').on('click', function () {
            var $this = $(this);
            $this.attr('src', $this.data('src') + '?' + Math.random());
        });
        function inputing() {
            $('#msg').text('');
        };
    </script>
</body>

</html>
