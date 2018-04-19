using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YueDuLibrary.Web
{
    public partial class YDLib : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null || string.IsNullOrEmpty(Session["role"].ToString()))
            {
                Response.Redirect("/login.aspx");
            }

            this.Label1.Text = Session["role"].ToString();

        }
    }
}