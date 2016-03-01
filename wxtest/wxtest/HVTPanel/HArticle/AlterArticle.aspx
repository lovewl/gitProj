<%@ Page Language="C#" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" AutoEventWireup="true" CodeBehind="AlterArticle.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.HArticle.AlterArticle" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
<h3>修改文章</h3>
<table>
    <tr><td>ID:</td><td><asp:Literal runat="server" ID="ltlHvtId" /></td></tr>
<tr><td>标题：</td><td><asp:TextBox runat="server" ID="txtTitle" Width="500" /></td></tr>
<tr><td>内容：</td><td><asp:TextBox runat="server" ID="txtContet" TextMode="MultiLine" Height="300" Width="500"/></td></tr>
<tr><td>选项：</td><td><asp:CheckBox runat="server"  ID="cbIsShow" Checked="true" Text="是否显示"  />  <asp:CheckBox runat="server" ID="cbIsHome" Checked="true" Text="是否首页" /></td></tr>
<tr><td>编辑器：</td><td><asp:RadioButtonList runat="server" ID="rblEditor"><asp:ListItem Text="编码" Value="0"></asp:ListItem>
<asp:ListItem Text="源码" Value="1"></asp:ListItem></asp:RadioButtonList></td></tr>
    <tr><td>文件夹名：</td><td><asp:TextBox runat="server" ID="tbFolder" /></td></tr>
<tr><td>文件名：</td><td><asp:TextBox runat="server" ID="txtFileName" ReadOnly="true"  /></td></tr>
    <tr><td>添加时间：</td><td><asp:Literal runat="server" ID="ltlTime" /></td></tr>
<tr><td></td><td><asp:Button runat="server" ID="btnSubmit"  Text="修改" OnClick="btnSubmit_Click"/> <asp:HyperLink runat="server" ID="hlBack" Text="返回" Visible="false"></asp:HyperLink></td></tr>
</table>
    <asp:Literal runat="server" ID="ltlTips" />
</asp:Content>