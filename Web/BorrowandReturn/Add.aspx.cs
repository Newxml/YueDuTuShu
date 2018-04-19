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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			int ReaderID=int.Parse(this.txtReaderID.Text);
			string BookCode=this.txtBookCode.Text;
			DateTime BorrowTime=DateTime.Parse(this.txtBorrowTime.Text);
			DateTime BackTime=DateTime.Parse(this.txtBackTime.Text);

			YueDuLibrary.Model.BorrowandReturn model=new YueDuLibrary.Model.BorrowandReturn();
			model.ReaderID=ReaderID;
			model.BookCode=BookCode;
			model.BorrowTime=BorrowTime;
			model.BackTime=BackTime;

			YueDuLibrary.BLL.BorrowandReturn bll=new YueDuLibrary.BLL.BorrowandReturn();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
