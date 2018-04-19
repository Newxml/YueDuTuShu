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
namespace YueDuLibrary.Web.BookCase
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int caseId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(caseId);
				}
			}
		}
			
	private void ShowInfo(int caseId)
	{
		YueDuLibrary.BLL.BookCase bll=new YueDuLibrary.BLL.BookCase();
		YueDuLibrary.Model.BookCase model=bll.GetModel(caseId);
		this.lblcaseId.Text=model.caseId.ToString();
		this.txtcaseName.Text=model.caseName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcaseName.Text.Trim().Length==0)
			{
				strErr+="caseName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int caseId=int.Parse(this.lblcaseId.Text);
			string caseName=this.txtcaseName.Text;


			YueDuLibrary.Model.BookCase model=new YueDuLibrary.Model.BookCase();
			model.caseId=caseId;
			model.caseName=caseName;

			YueDuLibrary.BLL.BookCase bll=new YueDuLibrary.BLL.BookCase();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
