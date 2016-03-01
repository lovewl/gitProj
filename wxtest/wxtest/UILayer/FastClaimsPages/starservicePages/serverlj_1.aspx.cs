using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using WxDev.Model;
using WxDev.Utility;

namespace wxtest.UILayer.FastClaimsPages.starservicePages
{
    public partial class serverlj_1 : System.Web.UI.Page
    {
        /// <summary>
        /// 阅读次数
        /// </summary>
        protected string ReadTimes { get; set; }
        public static string DateStr { get; set; }
        protected string Name { get; set; }
        protected string Tel { get; set; }
        protected string Satisfaction { get; set; }
        protected string Msgs { get; set; }
        protected string InputName { get; set; }
        protected string InputTel { get; set; }
        protected string InputSatis { get; set; }
        protected string DisplayStarts { get; set; }
        private List<VoteForEmployee> VoteInfoList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadTimes = XmlHelper.UpdateReadTimes("LiuJun01");
            VoteForEmployeeService service = new VoteForEmployeeService();
            DateStr = DateTime.Now.ToString();
            if (RequestHelper.IsPostBack(Request))
            {
                var name = Request.Form["name"];
                var tel = Request.Form["tel"];
                var statis = Request.Form["pjstar"];
                var msgs = Request.Form["memo"];
                if (!string.IsNullOrWhiteSpace(name))
                    name.ToString();
                else
                {
                    InputName = "请输入姓名";
                    return;
                }
                if (!string.IsNullOrWhiteSpace(tel))
                {
                    if (tel.Length < 8)
                    {
                        InputTel = "电话号码格式不正确";
                        return;
                    }
                    else if (tel.Length < 10 && tel[0].ToString().Trim() != "1")
                    {
                        InputTel = "电话号码格式不正确";
                        return;
                    }
                }
                else
                {
                    InputTel = "请输入电话号码";
                    return;
                }
                if (!string.IsNullOrWhiteSpace(statis))
                    statis.ToString();
                else
                {
                    InputSatis = "请选择满意度";
                    return;
                }
                if (msgs != null)
                    msgs.ToString();
                Name = name;
                Tel = tel;
                Satisfaction = statis;
                Msgs = msgs;
                VoteForEmployee VoteInfo = new VoteForEmployee();
                VoteInfo.EmployeeId = 2;
                VoteInfo.Msg = msgs;
                VoteInfo.Name = name;
                switch (statis)
                {
                    case "1":
                        VoteInfo.Satisfaction = 1;
                        break;
                    case "2":
                        VoteInfo.Satisfaction = 2;
                        break;
                    case "3":
                        VoteInfo.Satisfaction = 3;
                        break;
                }
                VoteInfo.Tel = tel;
                service.Insert(VoteInfo);
            }
            VoteInfoList = service.GetAll(2);
            if (VoteInfoList != null)
            {
                var satisfactionSum = 0;
                var count = 0.0;
                foreach (var item in VoteInfoList)
                {
                    satisfactionSum += item.Satisfaction;
                    count++;
                }
                if (count > 0)
                {
                    DisplayStarts = (satisfactionSum / count).ToString("0.0");
                }
                //if (satisfactionSum >= 20)
                //{
                //    for (int i = 0; i < satisfactionSum / 20; i++)
                //    {
                //        if (i >= 5) break;
                //        DisplayStarts += "<img src='/images/web/star.gif' width='15' height='20' style='margin-top: 0px;' />";
                //    }
                //}
            }
        }
    }
}