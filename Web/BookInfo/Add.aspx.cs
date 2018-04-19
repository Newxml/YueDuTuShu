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
namespace YueDuLibrary.Web.BookInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtbookCode.Text.Trim().Length==0)
			{
				strErr+="bookCode不能为空！\\n";	
			}
			if(this.txtbookName.Text.Trim().Length==0)
			{
				strErr+="bookName不能为空！\\n";	
			}
		
			if(this.txtauthor.Text.Trim().Length==0)
			{
				strErr+="author不能为空！\\n";	
			}
			if(this.txtprice.Text.Trim().Length==0)
			{
				strErr+="price不能为空！\\n";	
			}
		
			if(!PageValidate.IsNumber(txtbookPage.Text))
			{
				strErr+="bookPage格式错误！\\n";	
			}
			if(this.txtpublish.Text.Trim().Length==0)
			{
				strErr+="publish不能为空！\\n";	
			}
			
		
		
			if(this.fupBookFace.FileName.Trim().Length==0)
			{
				strErr+="请添加该书封面！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string bookCode=this.txtbookCode.Text;
			string bookName=this.txtbookName.Text;
            string typeId = this.ddlType.Text;
			string author=this.txtauthor.Text;
			string price=this.txtprice.Text;
			int bookCaseId=int.Parse(this.ddlBookCase.Text);
			int bookPage=int.Parse(this.txtbookPage.Text);
			string publish=this.txtpublish.Text;
			
			int storage=int.Parse(this.txtstorage.Text);
            string bookImgName = BLL.tools.UploadFile(this.fupBookFace, 1, 5);
            if(bookImgName!="")
            {
                string bookImg = bookImgName;

                YueDuLibrary.Model.BookInfo model = new YueDuLibrary.Model.BookInfo();
                model.bookCode = bookCode;
                model.bookName = bookName;
                model.typeId = typeId;
                model.author = author;
                model.price = price;
                model.bookCaseId = bookCaseId;
                model.bookPage = bookPage;
                model.publish = publish;

                model.storage = storage;

                model.bookImg = bookImg;

                YueDuLibrary.BLL.BookInfo bll = new YueDuLibrary.BLL.BookInfo();
                bll.Add(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "add.aspx");

            }

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
