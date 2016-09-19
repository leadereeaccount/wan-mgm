using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LitJson;
using System.Text.RegularExpressions;

namespace MGM.Web.Tools
{
    /// <summary>
    /// CheckPhone 的摘要说明
    /// </summary>
    public class CheckPhone : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            App_Code.LookNumDemo.AddNum(5);


            MGM.BLL.OrderInfo bll = new BLL.OrderInfo();

            JsonData jd = new JsonData();


            string phone = context.Request["phone"].ToString();


            if (!string.IsNullOrWhiteSpace(phone))
            {
                Regex r = new Regex("1\\d{10}");

                if (r.Match(phone).Success)
                {

                    if (bll.GetRecordCount("RefereePhone='" + phone + "'") > 0)
                    {
                        jd["status"] = "y";

                    }
                    else
                    {
                        jd["status"] = "n";
                        jd["info"] = "您还未成功推荐好友或者您的推荐信息还在路上请稍后查询";
                    }
                }
                else
                {
                    jd["status"] = "n";
                    jd["info"] = "请输入正确的手机号码！";
                }
            }
            else
            {
                jd["status"] = "n";
                jd["info"] = "请输入您要查询的手机号码！";
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