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
namespace YueDuLibrary.Web.Library
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		YueDuLibrary.BLL.Library bll=new YueDuLibrary.BLL.Library();
		YueDuLibrary.Model.Library model=bll.GetModel();
		this.lbllibarayName.Text=model.libarayName;
		this.lblcurator.Text=model.curator;
		this.lbltel.Text=model.tel;
		this.lblAddresss.Text=model.Addresss;
		this.lblemail.Text=model.email;
		this.lblurl.Text=model.url;
		this.lblcreateDate.Text=model.createDate.ToString();
		this.lblremark.Text=model.remark;

	}


    }
}
