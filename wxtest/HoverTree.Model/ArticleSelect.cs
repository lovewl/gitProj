using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoverTree.Model
{
   public  class ArticleSelect
    {
        int _hvtId = -1;

        public int HvtId
        {
            get { return _hvtId; }
            set { _hvtId = value; }
        }

        int _hvtIsShow=-1;
        /// <summary>
        /// 是否显示
        /// </summary>
        public int HvtIsShow
        {
            get { return _hvtIsShow; }
            set { _hvtIsShow = value; }
        }

        int _hvtIsHome=-1;
        /// <summary>
        /// 是否在首页显示
        /// </summary>
        public int HvtIsHome
        {
            get { return _hvtIsHome; }
            set { _hvtIsHome = value; }
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
    }
}