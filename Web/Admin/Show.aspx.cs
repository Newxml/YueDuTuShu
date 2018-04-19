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
namespace YueDuLibrary.Web.Admin
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
					int adminId=(Convert.ToInt32(strid));
					ShowInfo(adminId);
				}
			}
		}
		
	private void ShowInfo(int adminId)
	{
		YueDuLibrary.BLL.Admin bll=new YueDuLibrary.BLL.Admin();
		YueDuLibrary.Model.Admin model=bll.GetModel(adminId);
		this.lbladminId.Text=model.adminId.ToString();
		this.lbladminName.Text=model.adminName;
		this.lbladminPass.Text=model.adminPass;
		this.lbladminType.Text=model.adminType.ToString();
		this.lbladminImg.Text=model.adminImg;

	}


    }
}
