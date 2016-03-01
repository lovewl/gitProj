using HoverTree.Framework;
using HoverTree.Model;
using System;

namespace HoverTreeWeb.HVTPanel.HPicture
{
    public partial class PictureAlter : System.Web.UI.Page
    {
        protected PictureInfo _pictureInfo = new PictureInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int m_id;
                m_id = RequestHelper.GetQueryInt("hvtid", 0);

                if (m_id == 0)
                {
                    ltlTips.Text = "不存在该图片。";
                    btnSubmit.Enabled = false;
                    btnReUpload.Enabled = false;
                    return;
                }
                ltlHvtid.Text = m_id.ToString();

                PictureSelect m_pictureSelect = new PictureSelect();
                m_pictureSelect.HvtId = m_id;

                _pictureInfo = new HoverTree.BLL.HvtPicture().Get(m_pictureSelect);

                if(_pictureInfo==null)
                {
                    ltlTips.Text = "不存在该图片。";
                    btnSubmit.Enabled = false;
                    btnReUpload.Enabled = false;
                    return;
                }

                imgPicture.ImageUrl = _pictureInfo.HvtSrc + "?hvt=" + DateTime.Now.Millisecond.ToString();

                tbTitle.Text = _pictureInfo.HvtTitle;
                tbNote.Text = _pictureInfo.HvtNote;
                cbIsshow.Checked = _pictureInfo.HvtIsshow;
                cbIshome.Checked = _pictureInfo.HvtIshome;

                Cache["picInfo"] = _pictureInfo;
            }
        }

        protected void btnReUpload_Click(object sender, EventArgs e)
        {
            if(!fuPicture.HasFile)
            {
                ltlTips.Text = "请先选择图片";
                return;
            }

            PictureInfo m_pictureInfo = (PictureInfo)Cache["picInfo"];

            ltlTips.Text = new HoverTree.BLL.HvtPicture().ReUpload(m_pictureInfo, fuPicture);
            if (ltlTips.Text == string.Empty)
                ltlTips.Text = "重传图片成功";

            imgPicture.ImageUrl = m_pictureInfo.HvtSrc+"?hvt="+DateTime.Now.Millisecond.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PictureInfo m_pictureInfo = new PictureInfo();
            m_pictureInfo.HvtId = Convert.ToInt32(ltlHvtid.Text);
            m_pictureInfo.HvtTitle = tbTitle.Text.Trim();
            m_pictureInfo.HvtNote = tbNote.Text;
            m_pictureInfo.HvtIsshow = cbIsshow.Checked;
            m_pictureInfo.HvtIshome = cbIshome.Checked;


           ltlTips.Text= new HoverTree.BLL.HvtPicture().AlterInfo(m_pictureInfo);
           if (ltlTips.Text == string.Empty)
               ltlTips.Text = "修改成功";
        }
    }
}