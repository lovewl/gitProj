<%@ Page Language="C#" Title="提交留言" AutoEventWireup="true" CodeBehind="AddMessage.aspx.cs" Inherits="HoverTreeWeb.GuestBook.AddMessage" ValidateRequest="false" MasterPageFile="~/SiteResource/HvtSite.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="width: 100%; margin: 10px auto">
        <div style="text-align: center; color: burlywood">
            <h2>提交留言</h2>
        </div>
        <table class="table table-condensed">
            <tr>
                <td>标题：</td>
                <td>
                    <asp:TextBox runat="server" ID="txtTitle" /><asp:RequiredFieldValidator runat="server" ID="rfvTitle" ControlToValidate="txtTitle" Text="必填" /></td>
            </tr>
            <tr>
                <td>内容：</td>
                <td>
                    <asp:TextBox ID="txtContent" runat="server" Height="200" TextMode="MultiLine" /><asp:RequiredFieldValidator runat="server" ID="rfvContent" ControlToValidate="txtContent" Text="必填" /></td>
            </tr>
            <tr>
                <td>留言者：</td>
                <td>
                    <asp:TextBox runat="server" ID="txtUser" /><asp:RequiredFieldValidator runat="server" ID="rftUser" ControlToValidate="txtUser" Text="必填" /></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button CssClass="btn btn-xs btn-default" runat="server" ID="btnSubmit" Text="提交" OnClick="btnSubmit_Click" />
                    <a href="/guestbook/Default.aspx" target="_blank">查看留言</a></td>
            </tr>
        </table>
        <asp:Literal runat="server" ID="ltlTips" />
    </div>
</asp:Content>







<%--<%@ Page Language="C#" Title="提交留言" AutoEventWireup="true" CodeBehind="AddMessage.aspx.cs" Inherits="HoverTreeWeb.GuestBook.AddMessage" ValidateRequest="false" MasterPageFile="~/SiteResource/HvtSite.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:800px;margin:10px auto">
        <h2>提交留言</h2>
        <table><tr><td> 标题：</td><td><asp:TextBox runat="server" ID="txtTitle" Width="500" /><asp:RequiredFieldValidator runat="server" ID="rfvTitle" ControlToValidate="txtTitle" Text="必填" /></td></tr>
            <tr><td>内容：</td><td><asp:TextBox ID="txtContent" runat="server" Height="200" Width="500" TextMode="MultiLine" /><asp:RequiredFieldValidator runat="server" ID="rfvContent" ControlToValidate="txtContent" Text="必填" /></td></tr>
            <tr><td>留言者：</td><td><asp:TextBox runat="server" ID="txtUser"  /><asp:RequiredFieldValidator runat="server" ID="rftUser" ControlToValidate="txtUser" Text="必填" /></td></tr>
        <tr><td></td><td><asp:Button runat ="server" ID="btnSubmit" Text="提交" OnClick="btnSubmit_Click" /> <a href="/guestbook/Default.aspx" target="_blank">查看留言</a></td></tr>
        </table>
        <asp:Literal runat="server" ID="ltlTips" />
    </div>
    
    最近打算开发一个留言板,asp.net的开源项目，http://hovertree.codeplex.com 
    </asp:Content>--%>
