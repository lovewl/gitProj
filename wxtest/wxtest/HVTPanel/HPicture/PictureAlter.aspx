<%@ Page Title="" Language="C#" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" AutoEventWireup="true" CodeBehind="PictureAlter.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.HPicture.PictureAlter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <h2>重传图片</h2>
    原图：<br />
    <asp:Image runat="server" ID="imgPicture" Width="200" Height="160" />
    <br />
    选择图片：<asp:FileUpload runat="server" ID="fuPicture" />
    <br /><asp:Button runat="server" ID="btnReUpload" Text="重传图片" OnClick="btnReUpload_Click" />
    <hr />
    <h2>修改图片信息</h2>
    <br />ID:<asp:Literal runat="server" ID="ltlHvtid" />
    <br />描述：<asp:TextBox runat="server" ID="tbTitle" Width="500" />
    <br />内部备注：<br /><asp:TextBox runat="server" TextMode="MultiLine" ID="tbNote" Columns="80" Rows="10" />
    <br /><asp:CheckBox runat="server" ID="cbIsshow" Checked="true" Text="是否显示" /> <asp:CheckBox runat="server" ID="cbIshome" Text="是否首页显示" />
    <br /><asp:Button runat="server" ID="btnSubmit" Text="修改信息" OnClick="btnSubmit_Click" />
    <br />
    <asp:Literal runat="server" ID="ltlTips" />
</asp:Content>