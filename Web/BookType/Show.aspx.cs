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
namespace YueDuLibrary.Web.BookType
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
					int typeId=(Convert.ToInt32(strid));
					ShowInfo(typeId);
				}
			}
		}
		
	private void ShowInfo(int typeId)
	{
		YueDuLibrary.BLL.BookType bll=new YueDuLibrary.BLL.BookType();
		YueDuLibrary.Model.BookType model=bll.GetModel(typeId);
		this.lbltypeId.Text=model.typeId.ToString();
		this.lbltypeName.Text=model.typeName;
		this.lblbrDays.Text=model.brDays.ToString();

	}


    }
}
