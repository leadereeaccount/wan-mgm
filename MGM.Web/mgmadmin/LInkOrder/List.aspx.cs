using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGM.Web.mgmadmin.LInkOrder
{
    public partial class List : System.Web.UI.Page
    {

        public int pagesize = 10;
        public int page;
        public int pcount;
        public System.Text.StringBuilder strUrl = new System.Text.StringBuilder();

        MGM.BLL.OrderInfo bll = new BLL.OrderInfo();


        public int indexnum = 0;
        public int huodongbtnnum = 0;
        public int fenxiangnum = 0;
        public int messagenum = 0;
        public int detailnum = 0;
        public int chaxunnum = 0;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                indexnum = App_Code.LookNumDemo.GetLookNum(0);

                huodongbtnnum = App_Code.LookNumDemo.GetLookNum(1);
                fenxiangnum = App_Code.LookNumDemo.GetLookNum(3);
                messagenum = App_Code.LookNumDemo.GetLookNum(4);
                detailnum = App_Code.LookNumDemo.GetLookNum(2);
                chaxunnum = App_Code.LookNumDemo.GetLookNum(5);

                BindRepList();
            }
        }


        /// <summary>
        /// 绑定申请列表
        /// </summary>
        void BindRepList()
        {

            System.Text.StringBuilder strWhere = new System.Text.StringBuilder();

            strWhere.Append("1=1");
            int stateId;
            if (int.TryParse(Request.Params["state"], out stateId))
            {
                switch (stateId)
                {
                    case 1:
                        strWhere.Append(" and StateInfo=0");
                        break;
                    case 2:
                        strWhere.Append(" and StateInfo=1");
                        break;
                    case 3:
                        strWhere.Append(" and StateInfo=2");
                        break;

                }
                strUrl.Append("&state=" + stateId);
                ddlState.SelectedValue = Request.Params["state"];
            }
            if (!string.IsNullOrWhiteSpace(Request.Params["key"]))
            {
                strWhere.Append(" and (NameInfo like '%" + Request.Params["key"] + "%' or Phone='" + Request.Params["key"] + "' or CardNum='" + Request.Params["key"] + "' or LicenseNum like '%" + Request.Params["key"] + "%' or RefereeName like '%" + Request.Params["key"] + "%' or RefereePhone='" + Request.Params["key"] + "')");
                strUrl.Append("&key=" + Request.Params["key"]);
                txtKey.Text = Request.Params["key"];
            }

            if (!int.TryParse(Request.Params["page"], out page))
            {
                page = 0;
            }
            pcount = bll.GetRecordCount(strWhere.ToString());
            repList.DataSource = bll.GetListByPage(strWhere.ToString(), "AddTime desc", pagesize * page + 1, pagesize * pagesize + pagesize);
            repList.DataBind();


        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtndel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repList.Items.Count; i++)
            {
                CheckBox ckSelect = repList.Items[i].FindControl("ckSelect") as CheckBox;
                if (ckSelect.Checked)
                {
                    HiddenField hidid = repList.Items[i].FindControl("hidid") as HiddenField;
                    bll.Delete(int.Parse(hidid.Value));
                }
            }
            BindRepList();
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx?state=" + ddlState.SelectedValue + "&key=" + txtKey.Text);
        }


        /// <summary>
        /// 显示所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAllList_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDaochu_Click(object sender, EventArgs e)
        {
            StringBuilder strWhere = new StringBuilder();

            strWhere.Append("1=1 ");


            switch (ddlState.SelectedValue)
            {

                case "1":
                    strWhere.Append(" and StateInfo=0");
                    break;
                case "2":
                    strWhere.Append(" and StateInfo=1");
                    break;
                case "3":
                    strWhere.Append(" and StateInfo=2");
                    break;
            }

            if (!string.IsNullOrWhiteSpace(txtKey.Text))
            {
                strWhere.Append(" and (NameInfo like '%" + Request.Params["key"] + "%' or Phone='" + Request.Params["key"] + "' or CardNum='" + Request.Params["key"] + "' or LicenseNum like '%" + Request.Params["key"] + "%' or RefereeName like '%" + Request.Params["key"] + "%' or RefereePhone='" + Request.Params["key"] + "')");
            }


            BindDaochu(strWhere.ToString());
        }


        /// <summary>
        /// 导出数据到Execl
        /// </summary>
        /// <param name="str"></param>
        void BindDaochu(string str)
        {
            DataTable tblDatas = new DataTable("Datas");
            DataColumn dc = null;
            dc = tblDatas.Columns.Add("编号", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("姓名", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("手机号码", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("身份证号", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("营业执照号", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("推荐人姓名", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("推荐人手机", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("状态", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("状态值", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("申请时间", Type.GetType("System.String"));




            DataTable tblList = bll.GetList(0, str, "Id desc").Tables[0];
            DataRow newRow;
            if (tblList.Rows.Count > 0)
            {

                for (int i = 0; i < tblList.Rows.Count; i++)
                {
                    newRow = tblDatas.NewRow();
                    newRow["编号"] = tblList.Rows[i]["Id"].ToString();
                    newRow["姓名"] = tblList.Rows[i]["NameInfo"].ToString();
                    newRow["手机号码"] = tblList.Rows[i]["Phone"].ToString();
                    newRow["身份证号"] = tblList.Rows[i]["CardNum"].ToString();
                    newRow["营业执照号"] = tblList.Rows[i]["LicenseNum"].ToString();
                    newRow["推荐人姓名"] = tblList.Rows[i]["RefereeName"].ToString();
                    newRow["推荐人手机"] = tblList.Rows[i]["RefereePhone"].ToString();
                    newRow["状态"] = GetStateName( tblList.Rows[i]["StateInfo"].ToString());
                    newRow["状态值"] = tblList.Rows[i]["StateInfo"].ToString();
                    newRow["申请时间"] = Convert.ToDateTime(tblList.Rows[i]["AddTime"].ToString()).ToString("yyyy-MM-dd");
                    tblDatas.Rows.Add(newRow);
                }

            }

            ExcelRender.RenderToExcel(tblDatas, Context, "申请导出" + DateTime.Now.ToString("yyyyMMdd") + ".xls");


        }

        /// <summary>
        /// 标记为借贷成功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repList.Items.Count; i++)
            {

                CheckBox ckSelect = repList.Items[i].FindControl("ckSelect") as CheckBox;

                if (ckSelect.Checked)
                {
                    HiddenField hidid = repList.Items[i].FindControl("hidid") as HiddenField;

                    MGM.Model.OrderInfo model = bll.GetModel(int.Parse(hidid.Value));

                    if (model.StateInfo == 0)
                    {
                        model.StateInfo = 1;
                    }

                    bll.Update(model);
                }


            }


            BindRepList();
        }


        /// <summary>
        /// 导入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDaoru_Click(object sender, EventArgs e)
        {
            if (fileExecl.FileName != "")
            {

                System.Data.DataTable dt = ExcelRender.RenderFromExcel(fileExecl.FileContent);


                if (dt.Rows.Count > 0)
                {
                    foreach (System.Data.DataRow item in dt.Rows)
                    {
                        if (item["状态值"].ToString() == "1")
                        {

                            MGM.Model.OrderInfo model = bll.GetModel(int.Parse(item["编号"].ToString()));

                            model.StateInfo = 1;

                            bll.Update(model);

                        }

                        if (item["状态值"].ToString() == "0")
                        {
                            MGM.Model.OrderInfo model = bll.GetModel(int.Parse(item["编号"].ToString()));
                            if(model.StateInfo==2)
                            { 
                                model.StateInfo = 0;
                                bll.Update(model);
                            }
                        }

                    }


                }

                BindRepList();

            }
        }


        /// <summary>
        /// 获取状态名称
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns></returns>
        public string GetStateName(string stateId)
        {
            string stateName = "";


            switch (stateId)
            {
                case "0":
                    stateName = "申请成功";
                    break;
                case "1":
                    stateName = "借款成功";
                    break;
                case "2":
                    stateName = "待审核";
                    break;
            }

            return stateName;

        }


        /// <summary>
        /// 标记为申请成功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnShenqing_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repList.Items.Count; i++)
            {
                CheckBox ckSelect = repList.Items[i].FindControl("ckSelect") as CheckBox;
                if (ckSelect.Checked)
                {
                    HiddenField hidid = repList.Items[i].FindControl("hidid") as HiddenField;

                    MGM.Model.OrderInfo model = bll.GetModel(int.Parse(hidid.Value));

                    if (model.StateInfo == 2)
                    {
                        model.StateInfo = 0;
                    }

                    bll.Update(model);
                }
            }


            BindRepList();
        }
    }
}