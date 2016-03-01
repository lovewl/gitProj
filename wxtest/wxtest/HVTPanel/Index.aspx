<%@ Page Title="留言板后台管理" Language="C#" AutoEventWireup="true" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" CodeBehind="Index.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            margin: 0px;
            font-size: 16px;
            /*font-family: 'Verdana','宋体';*/
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <div style="width: 100%; margin: 5px auto; text-align: center">
        <asp:Literal runat="server" ID="ltlTips" />
        <asp:LinkButton ID="lbLogout" Text="退出" runat="server" OnClick="lbLogout_Click" />
    </div>
</asp:Content>




<%--<%@ Page Title="留言板后台管理" Language="C#" AutoEventWireup="true" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" CodeBehind="Index.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.Index" %>--%>
<%--<%@ Page Title="HoverTree后台管理" Language="C#" AutoEventWireup="true" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" CodeBehind="Index.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.Index" %>--%>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>body{margin:0px; font-size:16px;font-family:'Verdana','宋体';}</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <div style="width:500px;margin:50px auto;text-align:center">
        <br /><br />--%>
<%--<asp:Button runat="server" ID="btnGenerateGuestbookIndex" Text="生成留言板静态首页" OnClick="btnGenerateGuestbookIndex_Click" />
        <br />
        <asp:Button runat="server" ID="btnGenerateHomePage" Text="生成首页" OnClick="btnGenerateHomePage_Click" />
        <br />--%>
<%--        <asp:Literal runat="server" ID="ltlTips" />
        <br /><br />
    欢迎光临！<asp:Literal runat="server" ID="ltlUsername" />  
        <asp:LinkButton ID="lbLogout" Text="退出" runat="server" 
            onclick="lbLogout_Click" />
   <br /><br />
    &copy; <a href="http://www.yongjiu.co">www.yongjiu.co</a> 2015
    </div>
</asp:Content>--%>
