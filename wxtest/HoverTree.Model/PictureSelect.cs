using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoverTree.Model
{
   public  class PictureSelect
    {
        int _hvtId = -1;

        public int HvtId
        {
            get { return _hvtId; }
            set { _hvtId = value; }
        }

        int _hvtIsShow = -1;
        public int HvtIsShow
        {
            get { return _hvtIsShow; }
            set { _hvtIsShow = value; }
        }

        int _hvtIsHome = -1;
        public int HvtIsHome
        {
            get { return _hvtIsHome; }
            set { _hvtIsHome = value; }
        }
    }
}
