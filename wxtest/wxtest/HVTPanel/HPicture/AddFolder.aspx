<%@ Page Title="" Language="C#" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" AutoEventWireup="true" CodeBehind="AddFolder.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.HPicture.AddFolder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    在hvtimg目录下建立新文件夹：<br />
    文件夹名称：<asp:TextBox runat="server" ID="tbFolder" />    
    <asp:Button runat="server" ID="btnSubimt" Text="创建文件夹" OnClick="btnSubimt_Click" />
    <br />
    <asp:Literal runat="server" ID="ltlTips" />
    <div style="margin-top:20px;">
        已经存在的文件夹名称：<br />
        <asp:ListBox runat="server" ID="lbFolder" />
    </div>
</asp:Content>