using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxtest.UILayer.award_activity.answer
{
    public partial class answer : System.Web.UI.Page
    {
        /// <summary>
        /// 答题内容
        /// </summary>
        protected string QuestionStr { get; set; }
        protected string InputTel { get; set; }
        protected bool IsFirst { get; set; }
        private string answer1 = string.Empty;
        private string answer2 = string.Empty;
        private string answer3 = string.Empty;
        private string answer4 = string.Empty;
        private string answer5 = string.Empty;
        private string username = string.Empty;
        private string userTel = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            string content = string.Empty;
            if (Session["telerr"] == null)
            {
                Session["telerr"] = string.Empty;
            }
            else
            {
                InputTel = Session["telerr"].ToString();
            }
            for (int i = 0; i < 5; i++)
            {
                content += "<p>题目" + (i + 1) + "</p><input type=\"radio\" name=\"answer" + (i + 1) + "\" value=\"1\"  checked=\"checked\"/>答案1<br /><input type=\"radio\" name=\"answer" + (i + 1) + "\" value=\"2\" />答案2<br /><input type=\"radio\" name=\"answer" + (i + 1) + "\" value=\"3\" />答案3<br /><input type=\"radio\" name=\"answer" + (i + 1) + "\" value=\"4\" />答案4<br />";
            }
            content += "<br />";
            content += "<input type=\"text\" name=\"username\" placeholder=\"请输入姓名(必填)\" required=\"required\"/><br /><input type=\"tel\" name=\"userTel\" placeholder=\"请输入电话(必填)\" required=\"required\" />" + "<br />" + InputTel + "<br />";
            content += "<br /><input type=\"submit\" value=\"完成\"/>    <input type=\"reset\" value=\"重置\" />";
            
            QuestionStr = content;
            
            if (RequestHelper.IsPostBack(Request))
            {
                username = Request.Form["username"];
                userTel = Request.Form["userTel"];
                answer1 = Request.Form["answer1"];
                answer2 = Request.Form["answer2"];
                answer3 = Request.Form["answer3"];
                answer4 = Request.Form["answer4"];
                answer5 = Request.Form["answer5"];
                if (userTel != null)
                {
                    userTel.ToString();
                    if (userTel.Length < 8)
                    {
                        Session["telerr"] = "电话号码格式不正确";
                        return;
                    }
                    else if (userTel.Length < 10 && userTel[0].ToString().Trim() != "1")
                    {
                        Session["telerr"] = "电话号码格式不正确";
                        return;
                    }
                    Session["telerr"] = string.Empty;
                }
                IsFirst = true;
            }
            if (IsFirst)
            {
                QuestionStr = "你的答案为： " + answer1 + " " + answer2 + " " + answer3 + " " + answer4 + " " + answer5;
                QuestionStr += "<br /><br />正确答案为： 1 2 3 3 3<br />";
                QuestionStr += "<br /><h3>获奖名单请关注下方公众微信</h3>";
                QuestionStr += "<br /><img src=\"/images/web/Manage/qrcode-8.jpg\" alt=\"陕西永久二维码\"></img>";
            }
        }
    }
}