using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeChatJsSdk.SdkCore;

namespace MGM.Web
{
    public partial class telfind : System.Web.UI.Page
    {
        public string configstr;
        protected void Page_Load(object sender, EventArgs e)
        {
            string appId = System.Configuration.ConfigurationManager.AppSettings["WeChatAppId"];
            string appSecret = System.Configuration.ConfigurationManager.AppSettings["WeChatAppSecret"];
            bool debug = System.Configuration.ConfigurationManager.AppSettings["WeChatJsDebug"].ToLower() == "true";
            JSSDK sdk = new JSSDK(appId, appSecret, debug);
            SignPackage config = sdk.GetSignPackage(JsApiEnum.onMenuShareTimeline | JsApiEnum.onMenuShareQQ | JsApiEnum.onMenuShareAppMessage | JsApiEnum.onMenuShareWeibo);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            configstr = serializer.Serialize(config);
        }
    }
}