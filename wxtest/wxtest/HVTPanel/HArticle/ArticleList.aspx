<%@ Page Title="" Language="C#" MasterPageFile="~/HVTPanel/MPages/HvtMaster.Master" AutoEventWireup="true" CodeBehind="ArticleList.aspx.cs" Inherits="HoverTreeWeb.HVTPanel.HArticle.ArticleList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <h3>文章列表</h3>
    <asp:Repeater runat="server" ID="rptList">
        <HeaderTemplate><table></HeaderTemplate>
        <ItemTemplate><tr><td><a href="AlterArticle.aspx?hvtid=<%#((HoverTree.Model.ArticleInfo)Container.DataItem).HvtId.ToString() %>"><%#HttpUtility.HtmlEncode(((HoverTree.Model.ArticleInfo)Container.DataItem).HvtTitle) %></a></td>
            <td><a href="javascript:HvtGenerate(<%#((HoverTree.Model.ArticleInfo)Container.DataItem).HvtId.ToString() %>)" target="_self">重新生成</a></td>
                      </tr></ItemTemplate>
        <FooterTemplate></table></FooterTemplate>
    </asp:Repeater>
    <asp:Literal runat="server" ID="ltlPages" />
    <script type="text/javascript">
        function HvtGenerate(hvtid) {
            $.ajax({
                type: "Post",
                url: "articlelist.aspx/GenerateArticle",
                //方法传参的写法一定要对
                data: "{'hvtid':'"+hvtid+"'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    //返回的数据用data.d获取内容
                    if (data.d == '')
                        alert("生成成功");
                    else
                        alert(data.d);
                },
                error: function (err) {
                    alert(err);
                }
            });
        }
        </script>

</asp:Content>