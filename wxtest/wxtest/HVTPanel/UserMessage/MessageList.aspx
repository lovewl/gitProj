<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" CodeBehind="MessageList.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.UserMessage.MessageList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /*.keleyitable {
            width: 100%;
        }

            .keleyitable table, td, th {
                border: 1px solid green;
                margin-top: 10px;
            }*/

        .klytd {
            width: 15%;
            /*text-align: right;*/
        }

        .hvttd {
            width: 85%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <div style="text-align: center; color:darkviolet" class="keleyitable">
        <h2>留言列表</h2>
    </div>
    <asp:Repeater runat="server" ID="rptMessageList">
        <ItemTemplate>
            <table class="table table-bordered table-condensed">
                <tr>
                    <td class="klytd"><a href="HandleMessage.aspx?id=<%#Eval("hvtid") %>" target="_blank">留言时间</a>：</td>
                    <td class="hvttd"><%#Eval("hvttime") %></td>
                </tr>
                <tr>
                    <td class="klytd">留言人：</td>
                    <td class="hvttd"><%#HttpUtility.HtmlEncode(Eval("hvtuser")) %></td>
                </tr>
                <tr>
                    <td class="klytd">标题：</td>
                    <td class="hvttd"><%#HttpUtility.HtmlEncode(Eval("hvttitle")) %></td>
                </tr>
                <tr>
                    <td class="klytd">内容：</td>
                    <td class="hvttd"><%#HttpUtility.HtmlEncode(Eval("hvtcontent")) %></td>
                </tr>
                <tr>
                    <td class="klytd">回复：</td>
                    <td class="hvttd"><%#HttpUtility.HtmlEncode(Eval("hvtreply")) %></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
    <asp:Literal runat="server" ID="ltlPages" />
    <div style="width: 100%; /*margin: 10px auto; font-family: Arial, Helvetica, sans-serif;*/ text-align: center;">陕西永久 &copy; 2015 www.yongjiu.co  </div>
    <!--asp.net的开源项目，http://hovertree.codeplex.com -->
</asp:Content>
