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
namespace YueDuLibrary.Web.BookCase
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
					int caseId=(Convert.ToInt32(strid));
					ShowInfo(caseId);
				}
			}
		}
		
	private void ShowInfo(int caseId)
	{
		YueDuLibrary.BLL.BookCase bll=new YueDuLibrary.BLL.BookCase();
		YueDuLibrary.Model.BookCase model=bll.GetModel(caseId);
		this.lblcaseId.Text=model.caseId.ToString();
		this.lblcaseName.Text=model.caseName;

	}


    }
}
