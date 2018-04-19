using Maticsoft.Common;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YueDuLibrary.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strErr = "";
            BLL.Admin bll = new BLL.Admin();
            int aaa = bll.GetRecordCount("adminName='" + txtUsername.Text + "'and adminPass='"
                + FormsAuthentication.HashPasswordForStoringInConfigFile(this.txtPassword.Text, "MD5") + "'");
            if (aaa >= 1)
            {
                Session["role"] = txtUsername.Text;
                Response.Redirect("index.aspx");
            }
            else
            {
                strErr += "所输入的帐号或密码不正确！\\n";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
        }
    }
}