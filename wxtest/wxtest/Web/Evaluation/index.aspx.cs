using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using WxDev.Model;

namespace wxtest.Web.Evaluation
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EvaluationService eva = new EvaluationService();
            //List<cls_Evaluation> evaList = eva.QueryList(1, 20, null, string.Empty) as List<cls_Evaluation>;
            //if (evaList != null && evaList.Count > 0)
            //{
            //    rptMessageList.DataSource = evaList;
            //    rptMessageList.DataBind();
            //}
            //else
            //{
            //    evaList = new List<cls_Evaluation>();
            //    cls_Evaluation e1 = new cls_Evaluation();
            //    e1.Id = 1;
            //    e1.TargetObj = "11";
            //    e1.SourceObj = "111";
            //    e1.Tel = "1111";
            //    e1.ImgPath = "/images/web/air01.jpg";
            //    evaList.Add(e1);
            //    cls_Evaluation e2 = new cls_Evaluation();
            //    e2.Id = 2;
            //    e2.TargetObj = "22";
            //    e2.SourceObj = "222";
            //    e2.Tel = "2222";
            //    e2.ImgPath = "/images/web/air02.jpg";
            //    evaList.Add(e2);
            //    cls_Evaluation e3 = new cls_Evaluation();
            //    e3.Id = 3;
            //    e3.TargetObj = "33";
            //    e3.SourceObj = "333";
            //    e3.Tel = "3333";
            //    e3.ImgPath = "/images/web/air03.jpg";
            //    evaList.Add(e3);
            //    rptMessageList.DataSource = evaList;
            //    rptMessageList.DataBind();
            //}
            List<cls_Evaluation> evaList = new List<cls_Evaluation>();
            cls_Evaluation e1 = new cls_Evaluation();
            e1.Id = 1;
            e1.TargetObj = "11";
            e1.SourceObj = "111";
            e1.Tel = "1111";
            e1.ImgPath = "/images/web/air01.jpg";
            e1.CreateTime = DateTime.Now;
            e1.ContentMSG = "111111111111111111";
            evaList.Add(e1);
            cls_Evaluation e2 = new cls_Evaluation();
            e2.Id = 2;
            e2.TargetObj = "22";
            e2.SourceObj = "222";
            e2.Tel = "2222";
            e2.ImgPath = "/images/web/air02.jpg";
            e2.CreateTime = DateTime.Now;
            e2.ContentMSG = "22222222222222";
            evaList.Add(e2);
            cls_Evaluation e3 = new cls_Evaluation();
            e3.Id = 3;
            e3.TargetObj = "33";
            e3.SourceObj = "333";
            e3.Tel = "3333";
            e3.ImgPath = "/images/web/air03.jpg";
            e3.CreateTime = DateTime.Now;
            e3.ContentMSG = "333333333333333333333";
            evaList.Add(e3);
            rptMessageList.DataSource = evaList;
            rptMessageList.DataBind();
        }
    }
}