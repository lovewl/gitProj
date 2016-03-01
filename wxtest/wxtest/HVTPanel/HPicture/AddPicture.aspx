<%@ Page Title="" Language="C#" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" AutoEventWireup="true" CodeBehind="AddPicture.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.HPicture.AddPicture" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <h2>添加图片</h2>
    选择图片：<asp:FileUpload runat="server" ID="fuPicture" />
    <br />描述：<asp:TextBox runat="server" ID="tbTitle" Width="500" />
    <br />内部备注：<br /><asp:TextBox runat="server" TextMode="MultiLine" ID="tbNote" Columns="80" Rows="10" />
    <br /><asp:CheckBox runat="server" ID="cbIsshow" Checked="true" Text="是否显示" /> <asp:CheckBox runat="server" ID="cbIshome" Text="是否首页显示" />
    <br /><asp:Button runat="server" ID="btnSubmit" Text="提交" OnClick="btnSubmit_Click" />
    <br />
    <asp:Literal runat="server" ID="ltlTips" />
</asp:Content>