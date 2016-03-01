<%@ Page Language="C#"  Title="留言板" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HoverTreeWeb.GuestBook.Default" MasterPageFile="~/SiteResource/HvtSite.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        div.message {
            border: 1px solid black;
            margin: 5px auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%; margin: 10px auto; text-align:center; color:burlywood;">
        <h2>留言板</h2>
    </div>
    <div style="width: 100%; margin: 10px auto;">
        <asp:Repeater runat="server" ID="rptList">
            <ItemTemplate>
                <div class="message" style="width:100%">
                    <h3 style="color:blueviolet"><%# HttpUtility.HtmlEncode( Eval("hvttitle")) %></h3>
                    <%#HttpUtility.HtmlEncode(Eval("hvtuser")) %> | <%#Eval("hvttime") %><br /><br />
                    <%#HttpUtility.HtmlEncode(Eval("hvtcontent")) %>
                    <hr />
                    <%#HttpUtility.HtmlEncode(Eval("hvtreply")) %>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </asp:Content>