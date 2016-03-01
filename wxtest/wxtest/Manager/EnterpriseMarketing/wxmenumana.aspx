<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wxmenumana.aspx.cs" Inherits="wxtest.Manager.EnterpriseMarketing.wxmenumana" %>

<!DOCTYPE html>
<html lang="zh-CN">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->
    <title>微信后台管理</title>
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet">
    <link href="/assets/css/bootstrap-theme.min.css" rel="stylesheet">
    <style>
        td a:nth-of-type(2) {
            margin-left: 20px;
        }
    </style>
</head>
<body style="padding: 4px">
    <ol class="breadcrumb">
        <li><a href="#">企业营销管理</a></li>
        <li class="active">微信菜单管理</li>
    </ol>
    <form id="form1" runat="server">
        <div>
            <table class="table table-bordered table-condensed table-striped">
                <tr>
                    <th>序号</th>
                    <th>上级名称</th>
                    <th>菜单名称</th>
                    <th>菜单标题</th>
                    <th>当前级别</th>
                    <th>关联模块</th>
                    <th>操作</th>
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Container.DataItem %> </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td>1</td>
                    <td>--</td>
                    <td>快速理赔</td>
                    <td>快速理赔</td>
                    <td>一级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>快速理赔</td>
                    <td>理赔须知</td>
                    <td>理赔须知</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>快速理赔</td>
                    <td>星级服务</td>
                    <td>星级服务</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>星级服务</td>
                    <td>星级服务：赵国兰</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>星级服务</td>
                    <td>星级服务 景亚茹</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>6</td>
                    <td>星级服务</td>
                    <td>星级服务 陈珍</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>7</td>
                    <td>星级服务</td>
                    <td>星级服务 赵露</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>14</td>
                    <td>快速理赔</td>
                    <td>责任划分</td>
                    <td>责任划分</td>
                    <td>二级</td>
                    <td>电话导航(描述里的电话号码会变成可以拨打的电话)</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>15</td>
                    <td>快速理赔</td>
                    <td>车险办理</td>
                    <td>车险办理</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr style="height: 5px"></tr>
                <tr>
                    <td>1</td>
                    <td>--</td>
                    <td>快速理赔</td>
                    <td>快速理赔</td>
                    <td>一级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>快速理赔</td>
                    <td>理赔须知</td>
                    <td>理赔须知</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>快速理赔</td>
                    <td>星级服务</td>
                    <td>星级服务</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>星级服务</td>
                    <td>星级服务：赵国兰</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>星级服务</td>
                    <td>星级服务 景亚茹</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>6</td>
                    <td>星级服务</td>
                    <td>星级服务 陈珍</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>7</td>
                    <td>星级服务</td>
                    <td>星级服务 赵露</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>14</td>
                    <td>快速理赔</td>
                    <td>责任划分</td>
                    <td>责任划分</td>
                    <td>二级</td>
                    <td>电话导航(描述里的电话号码会变成可以拨打的电话)</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>15</td>
                    <td>快速理赔</td>
                    <td>车险办理</td>
                    <td>车险办理</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr style="height: 5px"></tr>
                <tr>
                    <td>1</td>
                    <td>--</td>
                    <td>快速理赔</td>
                    <td>快速理赔</td>
                    <td>一级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>快速理赔</td>
                    <td>理赔须知</td>
                    <td>理赔须知</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>快速理赔</td>
                    <td>星级服务</td>
                    <td>星级服务</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>星级服务</td>
                    <td>星级服务：赵国兰</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>星级服务</td>
                    <td>星级服务 景亚茹</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>6</td>
                    <td>星级服务</td>
                    <td>星级服务 陈珍</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>7</td>
                    <td>星级服务</td>
                    <td>星级服务 赵露</td>
                    <td>快赔专员</td>
                    <td>三级</td>
                    <td>客户顾问</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>14</td>
                    <td>快速理赔</td>
                    <td>责任划分</td>
                    <td>责任划分</td>
                    <td>二级</td>
                    <td>电话导航(描述里的电话号码会变成可以拨打的电话)</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
                <tr>
                    <td>15</td>
                    <td>快速理赔</td>
                    <td>车险办理</td>
                    <td>车险办理</td>
                    <td>二级</td>
                    <td>--</td>
                    <td><a href="#"><span class="glyphicon glyphicon-pencil"></span>编辑</a><a href="#"><span class="glyphicon glyphicon-remove"></span> 删除</a></td>
                </tr>
            </table>
            <div style="text-align: center">
                <a href="/Manager/EnterpriseMarketing/addmenupage.aspx" class="btn btn-default btn-sm">新建</a>
                <a style="margin-left: 20px" href="#" class="btn btn-default btn-sm">设置服务号菜单项</a>
            </div>
        </div>
    </form>
</body>
</html>
