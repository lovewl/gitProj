using HoverTree.DBTools;
using HoverTree.Framework;
using HoverTree.IDAL;
using HoverTree.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web.UI.WebControls;

namespace HoverTree.SQLServerDAL
{
    public class HvtPicture : IPicture
    {
        public string Add(PictureInfo picInfo, FileUpload fileUpload)
        {
            string m_return = string.Empty;
            string m_fileExtension;
            m_return = CheckPic(fileUpload, out m_fileExtension);

            if (m_return != string.Empty)
            {
                return m_return;
            }
            picInfo.HvtSuffix = m_fileExtension;            

            picInfo = PreparePictureInfo(picInfo);

            string m_sql = "insert into hovertr"
                + "ee_picture(hvtfilename,hvtsuffix,hvtfolder"
                + ",hvttime,hvttitle,hvtnote,hvtisshow,hvtishome)values(" + SQLTools.GetQuotes(picInfo.HvtFilename)
                + "," + SQLTools.GetQuotes(picInfo.HvtSuffix) + "," + SQLTools.GetQuotes(picInfo.HvtFolder)
                + "," + SQLTools.GetQuotes(picInfo.HvtTime.ToString())
                + "," + SQLTools.GetQuotes(picInfo.HvtTitle)
                + "," + SQLTools.GetQuotes(picInfo.HvtNote)
                + "," + Convert.ToInt32(picInfo.HvtIsshow).ToString()
                + "," + Convert.ToInt32(picInfo.HvtIshome).ToString()
                + " )";

            int m_i = KeleyiSQLHelper.ExecuteSql(m_sql);
            if (m_i != 1)
            {
                m_return = "添加记录失败。";
                return m_return;
            }

            string m_saveFolder = Utils.GetMapPath("/") + "hvtimg/" + picInfo.HvtFolder + "/";

            if (!Directory.Exists(m_saveFolder))
                Directory.CreateDirectory(m_saveFolder);

            string m_saveFullName = m_saveFolder + picInfo.HvtFilename + picInfo.HvtSuffix;

            fileUpload.SaveAs(m_saveFullName);
            fileUpload.Dispose();

            using (System.Drawing.Image originalImage = System.Drawing.Image.FromFile(m_saveFullName))
            {
                GetThumbnail(originalImage, 180, 140).Save(m_saveFolder + picInfo.HvtFilename +"_l"+picInfo.HvtSuffix);
            }

            return string.Empty;
        }

        /// <summary> 
        /// 为图片生成缩略图   
        /// </summary> 
        /// <param name="phyPath">原图片的路径</param> 
        /// <param name="width">缩略图宽</param> 
        /// <param name="height">缩略图高</param> 
        /// <returns></returns> 
        public System.Drawing.Image GetThumbnail(System.Drawing.Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            //从Bitmap创建一个System.Drawing.Graphics 
            System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bmp);
            //设置  
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //下面这个也设成高质量 
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            //下面这个设成High 
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //把原始图像绘制成上面所设置宽高的缩小图 
            System.Drawing.Rectangle rectDestination = new System.Drawing.Rectangle(0, 0, width, height);

            gr.DrawImage(image, rectDestination, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            return bmp;
        }

        PictureInfo PreparePictureInfo(PictureInfo pictureInfo)
        {
            DateTime m_now = DateTime.Now;
            if (pictureInfo.HvtTime.Year < 1900)
                pictureInfo.HvtTime = m_now;

            if (pictureInfo.HvtFolder == string.Empty)
                pictureInfo.HvtFolder = m_now.ToString("yyyyMM");

            if (pictureInfo.HvtFilename == string.Empty)
                pictureInfo.HvtFilename = HoverTree.Framework.Utils.GetHoverTreeString();

            return pictureInfo;
        }

        private string CheckPic(FileUpload fuPic, out string fileExtension)
        {
            string m_tips = string.Empty;
            fileExtension = string.Empty;
            if (!(fuPic.HasFile))
            {
                m_tips = "请先选择图片";
                return m_tips;
            }
            fileExtension = GetImageFileExtension(fuPic.PostedFile.ContentType);
            if (fileExtension == string.Empty)
            {
                m_tips = fuPic.PostedFile.ContentType + "只能上传图片,请选择图片文件(jpg,gif,bmp,png)";
            }
            else if (fuPic.PostedFile.ContentLength > 1048576)
            {
                m_tips = "文件太大";
            }
            return m_tips;
        }

        string GetImageFileExtension(string contentType)
        {
            switch (contentType)
            {
                case "image/jpeg":
                    return ".jpg";
                case "image/pjpeg":
                    return ".jpg";
                case "image/gif":
                    return ".gif";
                case "image/bmp":
                    return ".bmp";
                case "image/png":
                    return ".png";
                case "image/x-png":
                    return ".png";
                default:
                    return string.Empty;
            }
        }


        public List<PictureInfo> HvtPageQuery(PictureSelect pictureSelect, int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
        {

            string m_where = " 1=1 ";
            if (pictureSelect.HvtIsShow == 1)
                m_where = m_where + " and hvtisshow=1 ";
            else if (pictureSelect.HvtIsShow == 0)
                m_where = m_where + " and hvtisshow=0 ";

            if (pictureSelect.HvtIsHome == 1)
                m_where = m_where + " and HvtIsHome=1 ";
            else if (pictureSelect.HvtIsHome == 0)
                m_where = m_where + " and HvtIsHome=0 ";

            DataTable m_dt = KeleyiSQLHelper.HvtPageQuery("hove" + "r" + "tree_picture", "*", "hvtid", m_where
                , "  hvtId desc  ", sortType, pageSize, pageIndex, 0, out totalCount, out totalPageCount);

            return ConvertToList(m_dt);
        }

        List<PictureInfo> ConvertToList(DataTable pictureTable)
        {
            List<PictureInfo> m_pictureList = new List<PictureInfo>();
            if (pictureTable == null)
                return null;
            int m_rows = pictureTable.Rows.Count;
            if (m_rows == 0)
                return m_pictureList;


            for (int i = 0; i < m_rows; i++)
            {
                PictureInfo m_pictureInfo = new PictureInfo();
                m_pictureInfo.HvtTitle = pictureTable.Rows[i]["hvttitle"].ToString();
                m_pictureInfo.HvtNote = pictureTable.Rows[i]["hvtnote"].ToString();
                m_pictureInfo.HvtFilename = pictureTable.Rows[i]["hvtfilename"].ToString();
                m_pictureInfo.HvtId = Convert.ToInt32(pictureTable.Rows[i]["hvtid"]);
                m_pictureInfo.HvtTime = Convert.ToDateTime(pictureTable.Rows[i]["hvtTime"].ToString());
                m_pictureInfo.HvtIsshow = Convert.ToBoolean(pictureTable.Rows[i]["hvtisshow"]);
                m_pictureInfo.HvtIshome = Convert.ToBoolean(pictureTable.Rows[i]["hvtishome"]);
                m_pictureInfo.HvtSuffix = pictureTable.Rows[i]["hvtsuffix"].ToString();
                m_pictureInfo.HvtFolder = pictureTable.Rows[i]["hvtfolder"].ToString();

                m_pictureList.Add(m_pictureInfo);
            }


            return m_pictureList;
        }


        public PictureInfo Get(PictureSelect select)
        {
            if (select.HvtId < 1)
                return null;

            string m_where = " hvtid=" + select.HvtId.ToString();

            if (select.HvtIsShow == 1)
                m_where = m_where + " and hvtisshow=1 ";
            else if (select.HvtIsShow == 0)
                m_where = m_where + " and hvtisshow=0 ";

            if (select.HvtIsHome == 1)
                m_where = m_where + " and HvtIsHome=1 ";
            else if (select.HvtIsHome == 0)
                m_where = m_where + " and HvtIsHome=0 ";

            string m_sql = "select  * from hovertree_picture where " + m_where;

            DataRow m_dr = KeleyiSQLHelper.QueryRow(m_sql);

            if (m_dr == null)
                return null;

            PictureInfo m_pictureInfo = new PictureInfo();

            m_pictureInfo.HvtTitle = m_dr["hvttitle"].ToString();
            m_pictureInfo.HvtFilename = m_dr["hvtfilename"].ToString();
            m_pictureInfo.HvtId = select.HvtId;
            m_pictureInfo.HvtTime = Convert.ToDateTime(m_dr["hvtTime"].ToString());
            m_pictureInfo.HvtIsshow = Convert.ToBoolean(m_dr["hvtisshow"]);
            m_pictureInfo.HvtIshome = Convert.ToBoolean(m_dr["hvtishome"]);
            m_pictureInfo.HvtNote = m_dr["hvtnote"].ToString();
            m_pictureInfo.HvtSuffix = m_dr["HvtSuffix"].ToString();
            m_pictureInfo.HvtFolder = m_dr["HvtFolder"].ToString();

            return m_pictureInfo;
        }


        public string ReUpload(PictureInfo pictureInfo, FileUpload fileUpload)
        {
            string m_return = string.Empty;
            string m_fileExtension;
            m_return = CheckPic(fileUpload, out m_fileExtension);

            if (m_return != string.Empty)
            {
                return m_return;
            }

            string m_saveFolder = Utils.GetMapPath("/") + "hvtimg/" + pictureInfo.HvtFolder + "/";

            if (pictureInfo.HvtSuffix != m_fileExtension)
            {
                //删除原图
                string m_formerFile = m_saveFolder + pictureInfo.HvtFilename + pictureInfo.HvtSuffix;
                string m_formerListFile = m_saveFolder + pictureInfo.HvtFilename + "_l" + pictureInfo.HvtSuffix;
                if (File.Exists(m_formerFile))
                    File.Delete(m_formerFile);
                if (File.Exists(m_formerListFile))
                    File.Delete(m_formerListFile);

                //修改数据库后缀

                string m_sql = "update hovertree_picture set hvtsuffix=" + SQLTools.GetQuotes(m_fileExtension)+" where hvtid="+pictureInfo.HvtId.ToString();
                int m_i = KeleyiSQLHelper.ExecuteSql(m_sql);
                if (m_i != 1)
                {
                    return "原图删除了，修改后缀失败";
                }
            }

            pictureInfo.HvtSuffix = m_fileExtension;
            

            if (!Directory.Exists(m_saveFolder))
                Directory.CreateDirectory(m_saveFolder);

            string m_saveFullName = m_saveFolder + pictureInfo.HvtFilename + pictureInfo.HvtSuffix;

            fileUpload.SaveAs(m_saveFullName);
            fileUpload.Dispose();

            using (System.Drawing.Image originalImage = System.Drawing.Image.FromFile(m_saveFullName))
            {
                GetThumbnail(originalImage, 180, 140).Save(m_saveFolder + pictureInfo.HvtFilename + "_l" + pictureInfo.HvtSuffix);
            }

            return string.Empty;
        }


        public string AlterInfo(PictureInfo pictureInfo)
        {

            string m_sql = "update hover" + "tree_picture set "
                + "hvttitle=" + SQLTools.GetQuotes(pictureInfo.HvtTitle)
                + ",hvtnote=" + SQLTools.GetQuotes(pictureInfo.HvtNote)
                + ",hvtisshow=" + Convert.ToInt32(pictureInfo.HvtIsshow).ToString()
                + ",hvtishome=" + Convert.ToInt32(pictureInfo.HvtIshome).ToString()
                +" where hvtid="+pictureInfo.HvtId.ToString()
                ;

            int m_i = KeleyiSQLHelper.ExecuteSql(m_sql);
            if (m_i == 1)
                return string.Empty;
            else
                return "修改失败";

        }
    }
}