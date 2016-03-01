<%@ Page Title="" Language="C#" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" AutoEventWireup="true" CodeBehind="PictureList.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.HPicture.PictureList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <h3>图片列表</h3>
    <asp:Repeater runat="server" ID="rptList">
        <HeaderTemplate><table></HeaderTemplate>
        <ItemTemplate><tr><td><a href="PictureAlter.aspx?hvtid=<%#((HoverTree.Model.PictureInfo)Container.DataItem).HvtId.ToString() %>"><img  src="<%#((HoverTree.Model.PictureInfo)Container.DataItem).HvtSrc %>" style="width:200px;height:160px;" /></a></td></tr></ItemTemplate>
        <FooterTemplate></table></FooterTemplate>
    </asp:Repeater>
</asp:Content>