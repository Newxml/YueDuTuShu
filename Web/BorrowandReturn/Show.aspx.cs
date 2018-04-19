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
using System.Text;
namespace YueDuLibrary.Web.BorrowandReturn
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		YueDuLibrary.BLL.BorrowandReturn bll=new YueDuLibrary.BLL.BorrowandReturn();
		YueDuLibrary.Model.BorrowandReturn model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblReaderID.Text=model.ReaderID.ToString();
		this.lblBookCode.Text=model.BookCode;
		this.lblBorrowTime.Text=model.BorrowTime.ToString();
		this.lblBackTime.Text=model.BackTime.ToString();

	}


    }
}
