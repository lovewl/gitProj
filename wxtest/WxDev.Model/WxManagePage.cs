using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    public class WxManagePage
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        /// <summary>
        /// 菜单等级
        /// </summary>
        public string MenuLevel { get; set; }
        /// <summary>
        /// 上级菜单
        /// </summary>
        public string UpLevel { get; set; }
        /// <summary>
        /// 关联模块
        /// </summary>
        public string CorrelationModule { get; set; }
        /// <summary>
        /// 发送对象 默认all
        /// </summary>
        public string SendTo { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        public byte MsgType { get; set; }
        /// <summary>
        /// 菜单状态
        /// </summary>
        public byte MenuStatus { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImgPath { get; set; }
        /// <summary>
        /// 链接 可选，默认为空
        /// </summary>
        public string UrlLink { get; set; }
        /// <summary>
        /// 菜单顺序
        /// </summary>
        public int MenuSort { get; set; }
        /// <summary>
        /// 内容标题
        /// </summary>
        public string ContentTitle { get; set; }
        /// <summary>
        /// 编辑内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
