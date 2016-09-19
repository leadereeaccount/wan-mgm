using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MGM.Web.Tools
{
    /// <summary>
    /// ShareNum 的摘要说明
    /// </summary>
    public class ShareNum : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            App_Code.LookNumDemo.AddNum(3);
            context.Response.Write("Hello World");
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