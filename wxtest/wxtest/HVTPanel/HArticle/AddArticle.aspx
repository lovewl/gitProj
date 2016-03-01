<%@ Page Title="" Language="C#" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.HArticle.AddArticle" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
<h3>添加文章</h3>
<table>
<tr><td>标题：</td><td><asp:TextBox runat="server" ID="txtTitle" Width="500" /></td></tr>
<tr><td>内容：</td><td><asp:TextBox runat="server" ID="txtContet" TextMode="MultiLine" Height="300" Width="500"/></td></tr>
<tr><td>选项：</td><td><asp:CheckBox runat="server"  ID="cbIsShow" Checked="true" Text="是否显示"  />  <asp:CheckBox runat="server" ID="cbIsHome" Checked="true" Text="是否首页" /></td></tr>
<tr><td>编辑器：</td><td><asp:RadioButtonList runat="server" ID="rblEditor"><asp:ListItem Text="编码" Value="0" Selected="True"></asp:ListItem>
<asp:ListItem Text="源码" Value="1"></asp:ListItem></asp:RadioButtonList></td></tr>
    <tr><td>文件夹名：</td><td><asp:TextBox runat="server" ID="tbFolder" /></td></tr>
<tr><td>文件名：</td><td><asp:TextBox runat="server" ID="txtFileName" ReadOnly="true" /></td></tr>
<tr><td></td><td><asp:Button runat="server" ID="btnSubmit"  Text="添加" OnClick="btnSubmit_Click"/></td></tr>
</table>
    <asp:Literal runat="server" ID="ltlTips" />
</asp:Content>