using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MGM.Web.Tools
{
    /// <summary>
    /// Lookdetail 的摘要说明
    /// </summary>
    public class Lookdetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            App_Code.LookNumDemo.AddNum(2);
            context.Response.Write("0");
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