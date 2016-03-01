using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoverTree.Model
{
    public class ArticleInfo
    {
        int _HvtId;
        /// <summary>
        /// 文章ID
        /// </summary>
        public int HvtId
        {
            get { return _HvtId; }
            set { _HvtId = value; }
        }

        string  _hvtTitle;
        /// <summary>
        /// 标题
        /// </summary>
        public string  HvtTitle
        {
            get { return _hvtTitle; }
            set { _hvtTitle = value; }
        }

        string _hvtContent;
        /// <summary>
        /// 内容
        /// </summary>
        public string HvtContent
        {
            get { return _hvtContent; }
            set { _hvtContent = value; }
        }

        string _hvtContentShow;
        public string HvtContentShow
        {
            get { return _hvtContentShow; }
            set { _hvtContentShow = value; }
        }

        DateTime _hvtTime;
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime HvtTime
        {
            get { return _hvtTime; }
            set { _hvtTime = value; }
        }


        bool _hvtIsShow;
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool HvtIsShow
        {
            get { return _hvtIsShow; }
            set { _hvtIsShow = value; }
        }

        bool _hvtIsHome;
        /// <summary>
        /// 是否在首页显示
        /// </summary>
        public bool HvtIsHome
        {
            get { return _hvtIsHome; }
            set { _hvtIsHome = value; }
        }

        bool _hvtIsDelete;
        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool HvtIsDelete
        {
            get { return _hvtIsDelete; }
            set { _hvtIsDelete = value; }
        }

        string _hvtFileName;
        /// <summary>
        /// 文件名
        /// </summary>
        public string HvtFileName
        {
            get { return _hvtFileName; }
            set { _hvtFileName = value; }
        }

        string _hvtFolder = "hewenqi";
        public string HvtFolder
        {
            get { return _hvtFolder; }
            set { _hvtFolder = value.ToLower(); }
        }

        int _hvtEditor = 0;
        public int HvtEditor
        {
            get { return _hvtEditor; }
            set { _hvtEditor = value; }
        }


        public string Url
        {
            get { return "/hvtart/"+HvtFolder+"/"+HvtFileName+".htm"; }
        }
    }
}