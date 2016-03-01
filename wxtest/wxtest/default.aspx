<%@ Page Language="C#" MasterPageFile="~/SiteResource/HvtSite.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HoverTreeWeb._default" %>

<%--<%@ Page Title="ASP.NET开源CMS" Language="C#" MasterPageFile="~/SiteResource/HvtSite.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HoverTreeWeb._default" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        div.message {
            border-top: 1px solid black;
            border-bottom: 1px solid black;
            margin: 15px auto;
        }
    </style>
    <link rel="stylesheet" href="/assets/css/hvtimg.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<div style="border: 1px solid silver;">
        <span>文章</span>
        <asp:Repeater runat="server" ID="rptArt">
            <HeaderTemplate>
                <ul style="list-style: none;">
            </HeaderTemplate>
            <ItemTemplate>
                <li><a href="<%#((HoverTree.Model.ArticleInfo)Container.DataItem).Url %>" target="_blank"><%#HttpUtility.HtmlEncode(((HoverTree.Model.ArticleInfo)Container.DataItem).HvtTitle) %></a></li>
            </ItemTemplate>
            <FooterTemplate></ul></FooterTemplate>
        </asp:Repeater>
    </div>
    <div style="border: 1px solid silver; margin-top: 20px;">
        <span>图片</span>
        <asp:Repeater runat="server" ID="rptImg">
            <HeaderTemplate>
                <div class="dengxaing-hovertree-com">
            </HeaderTemplate>
            <ItemTemplate>
                <a title="<%#((HoverTree.Model.PictureInfo)Container.DataItem).HvtTitle %>" href="<%#((HoverTree.Model.PictureInfo)Container.DataItem).HvtSrc %>">
                    <img src="<%#((HoverTree.Model.PictureInfo)Container.DataItem).HvtListSrc %>" style="width: 180px; height: 140px;" /></a>
            </ItemTemplate>
            <FooterTemplate></div></FooterTemplate>
        </asp:Repeater>
    </div>--%>
    <div style="border: 1px solid silver; margin-top: 20px;">
        <div style="text-align:center; color:burlywood"><h2>留言板</h2></div>
        <asp:Repeater runat="server" ID="rptMessage">
            <ItemTemplate>
                <div class="message">
                    <h3 style="color:blueviolet"><%# HttpUtility.HtmlEncode( Eval("hvttitle")) %></h3>
                    <%#HttpUtility.HtmlEncode(Eval("hvtuser")) %> | <%#Eval("hvttime") %><br />
                    <br />
                    <%#HttpUtility.HtmlEncode(Eval("hvtcontent")) %>
                    <hr />
                    <%#HttpUtility.HtmlEncode(Eval("hvtreply")) %>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <script type="text/javascript" src="/assets/js/hvtimg.min.js"></script>
    <script type="text/jscript">
        $(document).ready(function () {
            $('.dengxaing-ho' + 'vertree-com').magnificPopup({
                delegate: 'a',
                type: 'image',
                tLoading: 'Loading image #%curr%...',
                mainClass: 'mfp-img-mobile',
                gallery: {
                    enabled: true,
                    navigateByImgClick: true,
                    preload: [0, 1]
                },
                image: {
                    tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
                    titleSrc: function (item) {
                        return item.el.attr('title') + '<small>by hovertree</small>';
                    }
                }
            });
        });
    </script>
</asp:Content>
