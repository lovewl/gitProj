using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using WxDev.Model;

namespace wxtest.Manager
{
    public partial class login : System.Web.UI.Page
    {
        public string Username { get; set; }
        public string Password { get; set; }
        protected string loginRes { get; set; }

        private UserService _userService = new UserService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsPostBack())
            {
                Login();
            }
        }

        private void Login()
        {
            // 接收参数
            Username = Request["username"];
            Password = Request["password"];
            var url = Request.UrlReferrer.ToString();
            // 参数校验
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                loginRes = "<div class=\"alert alert-danger\" role=\"alert\"><span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\" /><strong>  用户名或密码为空！</strong></div>";
                return;
            }

            User user;
            LoginResult res = _userService.Login(Username, Password, out user);
            switch (res)
            {
                case LoginResult.用户名不存在:
                case LoginResult.密码错误:
                    loginRes = "<div class=\"alert alert-danger\" role=\"alert\"><span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\" /><strong>  用户名或密码错误！</strong></div>";
                    return;
                case LoginResult.用户已被冻结:
                    loginRes = "<div class=\"alert alert-danger\" role=\"alert\"><span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\" /><strong>  用户状态异常！</strong></div>";
                    return;
                case LoginResult.登录成功:
                    Response.Write("登陆成功");
                    Session["UserInfo"] = user;

                    //if (isRemember)
                    //{
                    //    // 处理记住我
                    //    //HttpCookie c1 = new HttpCookie("ysb");
                    //    //c1.Value = Username;
                    //    //HttpCookie c2 = new HttpCookie("yssb");
                    //    //c2.Value = user.Password;
                    //    //Response.Cookies.Add(c1);
                    //    //Response.Cookies.Add(c2);
                    //    CookieHelper.Set("ysb", Username, DateTime.Now.AddDays(7));
                    //    CookieHelper.Set("yssb", user.Password, DateTime.Now.AddDays(7));
                    //}
                    Response.Redirect("/Manager");
                    break;
            }
        }
    }
}