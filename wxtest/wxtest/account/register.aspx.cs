using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using WxDev.Model;

namespace wxtest.account
{
    public partial class register : System.Web.UI.Page
    {
        UserService _service = new UserService();
        protected string Message { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsPostBack())
            {
                PostBack();
            }
        }
        private void PostBack()
        {
            // 1.采集表单
            string login = Request["username"];
            string password = Request["password"];
            string confirm = Request["confirm"];
            string vcode = Request["vcode"];
            string mobile = Request["mobile"];
            string name = Request["name"];
            mobile = name = login;
            //bool isChecked = Request["checked"] != null;
            string redirect = Request["redirect"];
            // 2.参数校验
            if (string.IsNullOrEmpty(login)
                || string.IsNullOrEmpty(password)
                || confirm != password
                || string.IsNullOrEmpty(vcode))
            {
                Message = "请检查用户名和密码";
                return;
            }
            string varEx = @"^[a-zA-Z][a-zA-Z0-9]{5,19}$";
            varEx = @"^[1]+[3-8]+\d{9}$";
            if (!Regex.IsMatch(login, varEx))
            {
                //Message = "用户名格式不正确，首位必须为字母，长度为6-20";
                Message = "手机号码不正确";
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                varEx = @"^[1]+[3-8]+" + i.ToString() + "{9}$";
                if (Regex.IsMatch(login, varEx))
                {
                    Message = "手机号码已注册";
                    return;
                }
            }
            varEx = @"^[1]+[3-8]+\d{9}$";
            if (!Regex.IsMatch(mobile, varEx))
            {
                Message = "手机号码不正确";
                return;
            }
            string path = Server.MapPath("/") + "1.txt";
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                sw.WriteLine("id:" + login);
                sw.WriteLine("pw:" + password);
            }
            // 3.验证码校验
            var session = Session["user_vcode"];
            if (session == null)
            {
                Message = "验证码错误";
                return;
            }
            var sessionCode = session.ToString();
            if (sessionCode != vcode)
            {
                Message = "验证码错误";
                return;
            }
            // 4.调用业务方法
            var res = _service.Register(login, password);
            switch (res)
            {
                case WxDev.Model.RegisterResult.用户名已存在:
                    Message = "用户名已存在";
                    return;
                case WxDev.Model.RegisterResult.注册成功:
                    Message = "注册成功";
                    User user = new User();
                    var ures = _service.Login(login, password, out user);
                    if (ures == LoginResult.登录成功)
                    {
                        user.Mobile = mobile;
                        user.Name = name;
                        _service.Update(user);
                    }
                    if (Session["redirect"] != null)
                    {
                        Response.Redirect(Session["redirect"].ToString());
                    }
                    Response.Redirect("/account/login.aspx");
                    break;
                case WxDev.Model.RegisterResult.注册失败:
                    Message = "注册失败";
                    return;
            }
        }
    }
}