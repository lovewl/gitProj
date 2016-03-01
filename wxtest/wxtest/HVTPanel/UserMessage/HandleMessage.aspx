<%@ Page Language="C#" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" AutoEventWireup="true" CodeBehind="HandleMessage.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.UserMessage.HandleMessage" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">

  <div style="width:100%;margin:10px auto">
        <h2>处理留言</h2>
        <table><tr><td> 标题：</td><td><asp:TextBox style="width:100%;" runat="server" ID="txtTitle"/></td></tr>
            <tr><td>内容：</td><td><asp:TextBox style="width:100%;" ID="txtContent" runat="server" Height="200" TextMode="MultiLine" /></td></tr>
            <tr><td>留言者：</td><td><asp:TextBox style="width:100%;" runat="server" ID="txtUser"  /> 留言ID：<asp:Literal runat="server" ID="ltlID" /></td></tr>
            <tr><td>是否公开：</td><td><asp:CheckBox runat="server" ID="cbIsshow" /></td></tr>
            <tr><td>回复：</td><td><asp:TextBox style="width:100%;" ID="txtReply" runat="server" Height="200" TextMode="MultiLine" /></td></tr>
        <tr><td></td><td><asp:Button runat ="server" ID="btnSubmit" Text="处理" OnClick="btnSubmit_Click" /></td></tr>
        </table>
        <asp:Literal runat="server" ID="ltlTips" />
    </div>
    <div style="width:100%;margin:10px auto;font-family:Arial, Helvetica, sans-serif;text-align:center;">陕西永久 &copy; 2015 www.yongjiu.co  </div>
</asp:Content>

