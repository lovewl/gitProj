<%@ Page Title="文章列表" Language="C#" MasterPageFile="~/SiteResource/HvtSite.Master" AutoEventWireup="true" CodeBehind="HvtList.aspx.cs" Inherits="HoverTreeWeb.HvtArt.HvtList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>文章列表</h2>
    <asp:Repeater runat="server" ID="rptList">
        <HeaderTemplate><table></HeaderTemplate>
        <ItemTemplate><tr><td><a href="<%#((HoverTree.Model.ArticleInfo)Container.DataItem).Url %>"><%#HttpUtility.HtmlEncode(((HoverTree.Model.ArticleInfo)Container.DataItem).HvtTitle) %></a></td></tr></ItemTemplate>
        <FooterTemplate></table></FooterTemplate>
    </asp:Repeater>
    <asp:Literal runat="server" ID="ltlPages" />
</asp:Content>