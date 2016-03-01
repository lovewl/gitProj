using System;
using System.IO;

namespace HoverTreeWeb.HVTPanel.HPicture
{
    public partial class AddFolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {ListFolders(); }
            
        }

        private void ListFolders()
        {
            string[] m_subKeleyiFolder = Directory.GetDirectories(Server.MapPath("/hvtimg\\"));

            int m_countHovertree = m_subKeleyiFolder.Length;
            for (int i = 0; i < m_countHovertree; i++)
            {
                m_subKeleyiFolder[i] = m_subKeleyiFolder[i].Substring(m_subKeleyiFolder[i].LastIndexOf("\\") + 1);
            }

            lbFolder.DataSource = m_subKeleyiFolder;
            lbFolder.DataBind();
        }

        protected void btnSubimt_Click(object sender, EventArgs e)
        {
            string m_folderName=tbFolder.Text.Trim();
            if (m_folderName == string.Empty)
            { ltlTips.Text = "请输入文件夹名称。"; return;}

            if(m_folderName.Contains("\\")||m_folderName.Contains("/"))
            {
                ltlTips.Text = "名称不能包含\\或者/";
                return;
            }

            string m_fullFolderName;
            try
            {
                m_fullFolderName = Server.MapPath("/hvtimg\\" + m_folderName);
            }
            catch(Exception ex)
            {
                ltlTips.Text = ex.Message;
                return;
            }

            if (Directory.Exists(m_fullFolderName))
            {
                ltlTips.Text = "文件夹已经存在";

                    return;
            }else
            {
                try{
                    Directory.CreateDirectory(m_fullFolderName);
                    ltlTips.Text = "创建成功";
                    ListFolders();
                }
                catch(Exception ex)
                {
                    ltlTips.Text = "创建失败。"+ex.Message;
                    return;
                }
            }

        }
    }
}