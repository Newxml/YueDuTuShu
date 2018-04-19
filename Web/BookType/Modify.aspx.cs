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
namespace YueDuLibrary.Web.BookType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int typeId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(typeId);
				}
			}
		}
			
	private void ShowInfo(int typeId)
	{
		YueDuLibrary.BLL.BookType bll=new YueDuLibrary.BLL.BookType();
		YueDuLibrary.Model.BookType model=bll.GetModel(typeId);
		this.lbltypeId.Text=model.typeId.ToString();
		this.txttypeName.Text=model.typeName;
		this.txtbrDays.Text=model.brDays.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txttypeName.Text.Trim().Length==0)
			{
				strErr+="typeName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtbrDays.Text))
			{
				strErr+="brDays格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int typeId=int.Parse(this.lbltypeId.Text);
			string typeName=this.txttypeName.Text;
			int brDays=int.Parse(this.txtbrDays.Text);


			YueDuLibrary.Model.BookType model=new YueDuLibrary.Model.BookType();
			model.typeId=typeId;
			model.typeName=typeName;
			model.brDays=brDays;

			YueDuLibrary.BLL.BookType bll=new YueDuLibrary.BLL.BookType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
