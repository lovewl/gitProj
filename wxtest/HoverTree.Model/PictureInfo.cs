using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoverTree.Model
{
    public class PictureInfo
    {
        int _hvtId;
        public int HvtId
        {
            get { return _hvtId; }
            set { _hvtId = value; }
        }

        string _hvtFilename=string.Empty;
        public string HvtFilename
        {
            get { return _hvtFilename; }
            set { _hvtFilename = value; }
        }

        string _hvtSuffix=string.Empty;
        public string HvtSuffix
        {
            get { return _hvtSuffix; }
            set { _hvtSuffix = value; }
        }

        string _hvtFolder=string.Empty;
        public string HvtFolder
        {
            get { return _hvtFolder; }
            set { _hvtFolder = value; }
        }

        DateTime _hvtTime;
        public DateTime HvtTime
        {
            get { return _hvtTime; }
            set { _hvtTime = value; }
        }

        string _hvtTitle;
        public string HvtTitle
        {
            get { return _hvtTitle; }
            set { _hvtTitle = value; }
        }

        bool _hvtIsshow;
        public bool HvtIsshow
        {
            get { return _hvtIsshow; }
            set { _hvtIsshow = value; }
        }

        bool _hvtIshome;
        public bool HvtIshome
        {
            get { return _hvtIshome; }
            set { _hvtIshome = value; }
        }

        string _hvtNote;
        public string HvtNote
        {
            get { return _hvtNote; }
            set { _hvtNote = value; }
        }

        public string HvtSrc
        {
            get { return "/hvtimg/" + _hvtFolder + "/" + _hvtFilename + _hvtSuffix; }
        }

        public string HvtListSrc { get { return "/hvtimg/" + _hvtFolder + "/" + _hvtFilename+"_l" + _hvtSuffix; } }

    }
}