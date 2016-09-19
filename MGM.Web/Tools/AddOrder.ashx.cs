using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LitJson;
using System.Data;
namespace MGM.Web.Tools
{
    /// <summary>
    /// AddOrder 的摘要说明
    /// </summary>
    public class AddOrder : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            MGM.BLL.OrderInfo bll = new BLL.OrderInfo();

            JsonData jd = new JsonData();


            string name = context.Request["txtname"].ToString();
            string phone = context.Request["txtPhone"].ToString();
            string cardNum = context.Request["txtCardNum"].ToString();
            string zhizhao = context.Request["txtZhizhao"].ToString();
            string recName = context.Request["txtRecName"].ToString();
            string recPhone = context.Request["txtRecPhone"].ToString();

            if (phone != recPhone)
            {
                DataSet ds = bll.GetList("Phone='" + phone + "' or CardNum='" + cardNum + "'");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    jd["status"] = "n";
                    jd["info"] = "您已经申请过该产品，请勿重复提交信息！";
                }
                else
                {
                    MGM.Model.OrderInfo model = new Model.OrderInfo();
                    model.Addtime = DateTime.Now;
                    model.CardNum = cardNum;
                    model.LicenseNum = zhizhao;
                    model.NameInfo = name;
                    model.Phone = phone;
                    model.RefereeName = recName;
                    model.RefereePhone = recPhone;
                    model.StateInfo = 2;
                    if (bll.Add(model) > 0)
                    {
                        jd["status"] = "y";
                    }
                    else
                    {
                        jd["status"] = "n";
                        jd["info"] = "申请提交失败，请稍后重试！";
                    }

                }
            }
            else
            {
                jd["status"] = "n";
                jd["info"] = "推荐人和申请人不能为同一手机号！";
            }

            context.Response.Write(jd.ToJson());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}