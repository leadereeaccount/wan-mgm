using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MGM.Web.App_Code
{
    public class LookNumDemo
    {


        /// <summary>
        /// 添加查看记录
        /// </summary>
        /// <param name="typeId">0首页，1参加活动页面，2产品详情页面，3分享点击次数，4数据填写页面，5推荐查询</param>
        public static void AddNum(int typeId)
        {
            MGM.BLL.LookNum bll = new BLL.LookNum();
            MGM.Model.LookNum model = new Model.LookNum();
            model.AddTime = DateTime.Now;
            model.NameInfo = "";
            model.Num = 1;
            model.TypeName = typeId;
            bll.Add(model);

        }



        /// <summary>
        /// 获取查看总数
        /// </summary>
        /// <param name="typeId">0首页，1参加活动页面，2产品详情页面，3分享点击次数，4数据填写页面，5推荐查询</param>
        /// <returns></returns>
        public static int GetLookNum(int typeId)
        {
            MGM.BLL.LookNum bll = new BLL.LookNum();
            return bll.GetRecordCount("TypeName=" + typeId);

        }






    }




}