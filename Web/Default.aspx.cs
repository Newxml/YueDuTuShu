using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace YueDuLibrary.Web
{
    public partial class Default : System.Web.UI.Page
    {
        BLL.BookInfo bll = new BLL.BookInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
 
            this.DataList1.DataSource = bll.GetList("");
            this.DataList1.DataBind();

        }

        protected void btnSer_Click(object sender, EventArgs e)
        {
            string txtBookName=this.txtBookName.Text.Trim();
            this.DataList1.DataSource = bll.GetList( "bookName like'%"+txtBookName+"%'" );
            this.DataList1.DataBind();
        }
    }
}
