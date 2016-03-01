<%@ Page Title="图片" Language="C#" MasterPageFile="~/SiteResource/HvtSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HoverTreeWeb.HvtImg.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="/assets/css/hvtimg.css">
<script type="text/javascript" src="/assets/js/hvtimg.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater runat="server" ID="rptList" >
        <HeaderTemplate><div class="dengxaing-hovertree-com"> 
</HeaderTemplate>
        <ItemTemplate>
            <a title="<%#((HoverTree.Model.PictureInfo)Container.DataItem).HvtTitle %>" href="<%#((HoverTree.Model.PictureInfo)Container.DataItem).HvtSrc %>">
            <img src="<%#((HoverTree.Model.PictureInfo)Container.DataItem).HvtListSrc %>" style="width:180px;height:140px;" /></a>
        </ItemTemplate>
        <FooterTemplate></div></FooterTemplate>
    </asp:Repeater>
    <script type="text/jscript">
$(document).ready(function() {

    $('.dengxaing-ho' + 'vertree-com').magnificPopup({
		delegate: 'a',
		type: 'image',
		tLoading: 'Loading image #%curr%...',
		mainClass: 'mfp-img-mobile',
		gallery: {
			enabled: true,
			navigateByImgClick: true,
			preload: [0,1]
		},
		image: {
			tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
			titleSrc: function(item) {
				return item.el.attr('title') + '<small>by hovertree</small>';
			}
		}
	});


});

  </script>

</asp:Content>