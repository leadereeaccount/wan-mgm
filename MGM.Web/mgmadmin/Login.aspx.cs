using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGM.Web.mgmadmin
{
    public partial class Login : System.Web.UI.Page
    {
        MGM.BLL.AdminInfo bllAdmin = new MGM.BLL.AdminInfo();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Session["loginnum"] == null)
            {
                Session["loginnum"] = 0;
            }

            if (int.Parse(Session["loginnum"].ToString()) <= 3)
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text) & !string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    string name = txtName.Text;
                    string pwd = Microsoft.Common.DESEncrypt.Encrypt(txtPass.Text.Trim());

                    DataSet ds = bllAdmin.GetList("Account='" + name + "' and Pwd='" + pwd + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (string.Equals(ds.Tables[0].Rows[0]["StateInfo"].ToString(), "1"))
                        {
                            Session["loginnum"] = null;
                            Session["AdminId"] = ds.Tables[0].Rows[0]["Id"].ToString();
                            Session["AdminAccount"] = ds.Tables[0].Rows[0]["Account"].ToString();

                            Session.Timeout = 45;

                            Microsoft.Common.Utils.WriteCookie("AdminAccount", Microsoft.Common.DESEncrypt.Encrypt(ds.Tables[0].Rows[0]["Account"].ToString()));
                            Microsoft.Common.Utils.WriteCookie("AdminPwd", ds.Tables[0].Rows[0]["pwd"].ToString());

                            Response.Redirect("/mgmadmin/LInkOrder/List.aspx");

                        }
                        else
                        {
                            lbMessage.Text = "您的帐号已被禁用，请联系管理人员";
                        }
                    }
                    else
                    {
                        lbMessage.Text = "请输入正确的用户名密码";
                        Session["loginnum"] = (int.Parse(Session["loginnum"].ToString()) + 1).ToString();
                    }
                }
                else
                {
                    lbMessage.Text = "用户名或密码不能为空";
                }
            }
            else
            {
                lbMessage.Text = "密码输入错误超过3次，请关闭浏览器重新登录";
            }

        }

    }
}