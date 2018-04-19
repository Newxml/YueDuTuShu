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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace YueDuLibrary.Web.Admin
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int adminId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(adminId);
				}
			}
		}
			
	private void ShowInfo(int adminId)
	{
		YueDuLibrary.BLL.Admin bll=new YueDuLibrary.BLL.Admin();
		YueDuLibrary.Model.Admin model=bll.GetModel(adminId);
		this.txtadminName.Text=model.adminName;
		this.txtadminPass.Text="";
		this.txtadminType.Text=model.adminType.ToString();
		this.txtadminImg.Text=model.adminImg;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadminName.Text.Trim().Length==0)
			{
				strErr+="adminName不能为空！\\n";	
			}
			if(this.txtadminPass.Text.Trim().Length==0)
			{
				strErr+="adminPass不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtadminType.Text))
			{
				strErr+="adminType格式错误！\\n";	
			}
			if(this.txtadminImg.Text.Trim().Length==0)
			{
				strErr+="adminImg不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			
			string adminName=this.txtadminName.Text;
		    string adminPass=FormsAuthentication.HashPasswordForStoringInConfigFile(this.txtadminPass.Text, "MD5");
			int adminType=int.Parse(this.txtadminType.Text);
			string adminImg=this.txtadminImg.Text;


			YueDuLibrary.Model.Admin model=new YueDuLibrary.Model.Admin();
			
			model.adminName=adminName;
			model.adminPass=adminPass;
			model.adminType=adminType;
			model.adminImg=adminImg;

			YueDuLibrary.BLL.Admin bll=new YueDuLibrary.BLL.Admin();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
