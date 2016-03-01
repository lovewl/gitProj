using HoverTree.Model;
using System;

namespace HoverTreeWeb.HVTPanel.HPicture
{
    public partial class AddPicture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PictureInfo m_picInfo = new PictureInfo();
            m_picInfo.HvtIshome = cbIshome.Checked;
            m_picInfo.HvtIsshow = cbIsshow.Checked;
            m_picInfo.HvtTitle = tbTitle.Text.Trim();
            m_picInfo.HvtNote = tbNote.Text;
            ltlTips.Text = new HoverTree.BLL.HvtPicture().Add(m_picInfo, fuPicture);
            if (ltlTips.Text == string.Empty)
            {
                ltlTips.Text = "添加成功";
                tbNote.Text = string.Empty;
                tbTitle.Text = string.Empty;
                cbIsshow.Checked = true;
                cbIshome.Checked = false;
            }
        }
    }
}