using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    /// <summary>
    /// 客户评价类
    /// </summary>
    public class cls_Evaluation
    {
        /// <summary>
        /// 主键，Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 被评论的对象
        /// </summary>
        public string TargetObj { get; set; }
        /// <summary>
        /// 评论人
        /// </summary>
        public string SourceObj { get; set; }
        /// <summary>
        /// 评论人电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 评论人头像路径
        /// </summary>
        public string ImgPath { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string ContentMSG { get; set; }
        /// <summary>
        /// 服务态度评级
        /// </summary>
        public string Service { get; set; }
        /// <summary>
        /// 专业知识评级
        /// </summary>
        public string Professional { get; set; }
        /// <summary>
        /// 个人形象评级
        /// </summary>
        public string Grooming { get; set; }
        /// <summary>
        /// 店面环境评级
        /// </summary>
        public string Environment { get; set; }
        /// <summary>
        /// 评论日期
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 消息状态(0：隐藏；1：正常)
        /// </summary>
        public string Status { get; set; }
    }
}
