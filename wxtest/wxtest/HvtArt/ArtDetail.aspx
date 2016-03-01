<%@ Page Title="" Language="C#" MasterPageFile="~/SiteResource/HvtSite.Master" AutoEventWireup="true" CodeBehind="ArtDetail.aspx.cs" Inherits="HoverTreeWeb.HvtArt.ArtDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:left;width:700px;margin-left:50px;">
    <h3><asp:Literal runat="server" ID="ltlTitle" /></h3>
    <asp:Literal runat="server" ID="ltlTime" /><br />
    <asp:Literal runat="server" ID="ltlContent" /><br />
    <asp:Literal runat="server" ID="ltlTips" />
    </div>
</asp:Content>