<%@ Page ValidateRequest="false" Language="C#" AutoEventWireup="true" CodeBehind="addmenupage.aspx.cs" Inherits="wxtest.Manager.EnterpriseMarketing.addmenupage" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->
    <title>微信后台管理</title>
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet">
    <link href="/assets/css/bootstrap-theme.min.css" rel="stylesheet">
    <link href="/assets/lib/font-awesome/css/font-awesome.css" rel="stylesheet">
    <link href="/assets/lib/summernote/css/summernote.css" rel="stylesheet">
    <%--<link href="/assets/lib/swfupload/css/default.css" rel="stylesheet" type="text/css" />--%>
</head>
<body style="padding: 4px">
    <ol class="breadcrumb">
        <li><a href="#">企业营销管理</a></li>
        <li><a href="/Manager/EnterpriseMarketing/wxmenumana.aspx">微信菜单管理</a></li>
        <li class="active">新建</li>
    </ol>
    <form class="form-inline" style="background-color: #eee; border-radius: 5px; min-height: 736px; padding: 15px 30px" id="form1" runat="server" method="post">
        <label for="menuName">菜单名称：</label>
        <input id="menuName" name="menuName" type="text" required /><span style="color: red"><strong>必须</strong></span>
        <br />
        <label for="menulevel">
            分级设置：
            <select onchange="levelclick()" name="menulevel" id="menulevel" class="form-control">
                <option>一级</option>
                <option>二级</option>
                <option>三级</option>
            </select>
        </label>
        <select style="visibility: hidden; margin-left: 20px" name="upmenu1" id="upmenu1" class="form-control">
            <%= menu1Str %>
        </select>
        <select style="visibility: hidden; margin-left: -153px" name="upmenu2" id="upmenu2" class="form-control">
            <%= menu2Str %>
        </select>
        <br />
        <label for="status">
            状态：                        
            <select style="margin-left: 28px" name="status" id="status" class="form-control">
                <option>正常</option>
                <option>禁用</option>
            </select>
        </label>
        <br />
        <div id="swfu_container" style="margin: 0px 10px;">
            <div>
                <span id="spanButtonPlaceholder"></span>
            </div>
            <div id="divFileProgressContainer" style="height: 75px;"></div>
            <div id="thumbnails"></div>
        </div>
        <br />
        <label for="ur">链接：</label>
        <input style="margin-left: 28px" id="ur" name="ur" type="text" /><span style="color: green"><strong>可选</strong></span>
        <br />
        <label for="menusort">菜单顺序：</label>
        <input id="menusort" name="menusort" type="text" required /><span style="color: red"><strong>必须</strong></span>
        <br />
        <label for="menutitle">标题：</label>
        <input style="margin-left: 28px" id="menutitle" name="menutitle" type="text" />
        <br />
        <div style="background-color: #FFF">
            <input name="summernote" id="summernote" />
        </div>
        <%-- <div style="margin: 50px 150px 50px 0; background-color: #FFF">
                <div id="summernote">Hello Summernote</div>
            </div>--%>
        <br />
        <input class="btn btn-primary" type="submit" onmousedown="sub()" /><input style="margin-left: 50px" class="btn btn-danger" type="reset" />
    </form>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="/assets/js/jquery-1.11.2.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="/assets/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="/assets/lib/swfupload/swfupload/swfupload.js"></script>
    <script type="text/javascript" src="/assets/lib/swfupload/js/handlers.js"></script>
    <script type="text/javascript" src="/assets/lib/summernote/js/summernote.js"></script>
    <script type="text/javascript" src="/assets/lib/summernote/lang/summernote-zh-CN.js"></script>
    <script type="text/javascript" src="/assets/lib/summernote/plugin/summernote-ext-video.js"></script>
    <script type="text/javascript" src="/assets/js/summernote-yongjiu.js"></script>
    <script type="text/javascript">
        function levelclick() {
            switch ($('#menulevel').val()) {
                case "一级":
                    $('#upmenu1').css('visibility', 'hidden');
                    $('#upmenu2').css('visibility', 'hidden');
                    break;
                case "二级":
                    $('#upmenu1').css('visibility', 'visible');
                    $('#upmenu2').css('visibility', 'hidden');
                    break;
                case "三级":
                    $('#upmenu1').css('visibility', 'hidden');
                    $('#upmenu2').css('visibility', 'visible');
                    break;
            }
        }
    </script>
</body>
</html>
