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
namespace YueDuLibrary.Web.BorrowandReturn
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		YueDuLibrary.BLL.BorrowandReturn bll=new YueDuLibrary.BLL.BorrowandReturn();
		YueDuLibrary.Model.BorrowandReturn model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtReaderID.Text=model.ReaderID.ToString();
		this.txtBookCode.Text=model.BookCode;
		this.txtBorrowTime.Text=model.BorrowTime.ToString();
		this.txtBackTime.Text=model.BackTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtReaderID.Text))
			{
				strErr+="ReaderID格式错误！\\n";	
			}
			if(this.txtBookCode.Text.Trim().Length==0)
			{
				strErr+="BookCode不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBorrowTime.Text))
			{
				strErr+="BorrowTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBackTime.Text))
			{
				strErr+="BackTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int ReaderID=int.Parse(this.txtReaderID.Text);
			string BookCode=this.txtBookCode.Text;
			DateTime BorrowTime=DateTime.Parse(this.txtBorrowTime.Text);
			DateTime BackTime=DateTime.Parse(this.txtBackTime.Text);


			YueDuLibrary.Model.BorrowandReturn model=new YueDuLibrary.Model.BorrowandReturn();
			model.ID=ID;
			model.ReaderID=ReaderID;
			model.BookCode=BookCode;
			model.BorrowTime=BorrowTime;
			model.BackTime=BackTime;

			YueDuLibrary.BLL.BorrowandReturn bll=new YueDuLibrary.BLL.BorrowandReturn();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
