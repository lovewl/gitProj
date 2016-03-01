using HoverTree.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HoverTreeWeb.HVTPanel.UserMessage
{
    public partial class HandleMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                int m_id;
                m_id = HoverTree.Framework.RequestHelper.GetQueryInt("id", 0);

                if (m_id == 0)
                {
                    ltlTips.Text = "不存在该留言。";
                    return;
                }

                ltlID.Text = m_id.ToString();

                DataRow m_dr = new HoverTree.BLL.UserMessage().Get(m_id);

                txtTitle.Text = m_dr["hvttitle"].ToString();
                txtContent.Text = m_dr["hvtcontent"].ToString();
                txtUser.Text = m_dr["hvtuser"].ToString();
                txtReply.Text = m_dr["hvtreply"].ToString();
                cbIsshow.Checked = Convert.ToBoolean(m_dr["hvtisshow"]==DBNull.Value?true:false);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ltlTips.Text = new HoverTree.BLL.UserMessage().Handle(Convert.ToInt32(ltlID.Text), cbIsshow.Checked, txtReply.Text);
            if (ltlTips.Text == string.Empty) ltlTips.Text = "处理成功";
        }
    }
}