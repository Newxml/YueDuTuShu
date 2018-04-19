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
namespace YueDuLibrary.Web.ReaderType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		YueDuLibrary.BLL.ReaderType bll=new YueDuLibrary.BLL.ReaderType();
		YueDuLibrary.Model.ReaderType model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txttypeName.Text=model.typeName;
		this.txtnumber.Text=model.number.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txttypeName.Text.Trim().Length==0)
			{
				strErr+="typeName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtnumber.Text))
			{
				strErr+="number格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string typeName=this.txttypeName.Text;
			int number=int.Parse(this.txtnumber.Text);


			YueDuLibrary.Model.ReaderType model=new YueDuLibrary.Model.ReaderType();
			model.id=id;
			model.typeName=typeName;
			model.number=number;

			YueDuLibrary.BLL.ReaderType bll=new YueDuLibrary.BLL.ReaderType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
