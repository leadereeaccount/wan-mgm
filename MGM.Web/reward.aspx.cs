using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeChatJsSdk.SdkCore;

namespace MGM.Web
{
    public partial class reward : System.Web.UI.Page
    {
        public int num = 0;
        public int successnum = 0;
        public int money = 0;
        public int successmoney = 0;
        public int recnum = 0;
        public int recmoney = 0;
        public string configstr;

        MGM.BLL.OrderInfo bll = new BLL.OrderInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            string appId = System.Configuration.ConfigurationManager.AppSettings["WeChatAppId"];
            string appSecret = System.Configuration.ConfigurationManager.AppSettings["WeChatAppSecret"];
            bool debug = System.Configuration.ConfigurationManager.AppSettings["WeChatJsDebug"].ToLower() == "true";
            JSSDK sdk = new JSSDK(appId, appSecret, debug);
            SignPackage config = sdk.GetSignPackage(JsApiEnum.onMenuShareTimeline | JsApiEnum.onMenuShareQQ | JsApiEnum.onMenuShareAppMessage | JsApiEnum.onMenuShareWeibo);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            configstr = serializer.Serialize(config);



            if (!IsPostBack)
            {
                Bind();
            }
        }



        void Bind()
        {
            System.Data.DataSet ds = bll.GetList("RefereePhone='" + Request.Params["phone"] + "' and StateInfo!=2");

            if (ds.Tables[0].Rows.Count > 0)
            {
                num = ds.Tables[0].Rows.Count;
                money = num * 10;

                successnum = ds.Tables[0].Select("StateInfo=1").Count();

                if (successnum == 0)
                {
                    recnum = 1;
                    recmoney = 50 + 10;
                    successmoney = successnum * 0;
                }
                else if (successnum >= 1 && successnum <= 3)
                {
                    recnum = 4 - successnum;
                    recmoney = 4 * 100 + 4 * 10;
                    successmoney = successnum * 50;
                }
                else if (successnum >= 4 && successnum <= 6)
                {
                    recnum = 7 - successnum;
                    recmoney = 7 * 150 + 7 * 10;
                    successmoney = successnum * 100;
                }
                else if (successnum >= 7 && successnum <= 9)
                {
                    recnum = 10 - successnum;
                    recmoney = 10 * 200 + 10 * 10;
                    successmoney = successnum * 150;
                }
                else
                {
                    recnum = 5;
                    recmoney = (successnum + 5) * (200 + 10);
                    successmoney = successnum * 200;
                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }

        }



    }
}