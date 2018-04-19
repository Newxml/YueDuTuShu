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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int bookId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(bookId);
				}
			}
		}
			
	private void ShowInfo(int bookId)
	{
		YueDuLibrary.BLL.BookInfo bll=new YueDuLibrary.BLL.BookInfo();
		YueDuLibrary.Model.BookInfo model=bll.GetModel(bookId);
		this.lblbookId.Text=model.bookId.ToString();
		this.txtbookCode.Text=model.bookCode;
		this.txtbookName.Text=model.bookName;
		//this.txttypeId.Text=model.typeId;
		this.txtauthor.Text=model.author;
		this.txtprice.Text=model.price;
		//this.txtbookCaseId.Text=model.bookCaseId.ToString();
		this.txtbookPage.Text=model.bookPage.ToString();
		this.txtpublish.Text=model.publish;
		//this.txtoperId.Text=model.operId.ToString();
		this.txtstorage.Text=model.storage.ToString();
		//this.txtInCreateTime.Text=model.InCreateTime.ToString();
		//this.txtbookImg.Text=model.bookImg;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtbookCode.Text.Trim().Length==0)
			{
				strErr+="图书编码不能为空！\\n";	
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
			//if(!PageValidate.IsNumber(txtoperId.Text))
			//{
			//	strErr+="operId格式错误！\\n";	
			//}
		
			//if(!PageValidate.IsDateTime(txtInCreateTime.Text))
			//{
			//	strErr+="InCreateTime格式错误！\\n";	
			//}
			//if(this.txtbookImg.Text.Trim().Length==0)
			//{
			//	strErr+="封面上传不能为空！\\n";	
			//}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int bookId=int.Parse(this.lblbookId.Text);
			string bookCode=this.txtbookCode.Text;
			string bookName=this.txtbookName.Text;
			string typeId=this.ddlType.Text;
			string author=this.txtauthor.Text;
			string price=this.txtprice.Text;
			int bookCaseId=int.Parse(this.ddlCase.Text);
			int bookPage=int.Parse(this.txtbookPage.Text);
			string publish=this.txtpublish.Text;
			//int operId=int.Parse(this.txtoperId.Text);
			int storage=int.Parse(this.txtstorage.Text);
            //DateTime InCreateTime=DateTime.Parse(this.txtInCreateTime.Text);
        
            string bookImgName = BLL.tools.UploadFile(this.fupUpPic, 1, 5);
            if (bookImgName != "")
            {
                YueDuLibrary.Model.BookInfo model = new YueDuLibrary.Model.BookInfo();
                model.bookId = bookId;
                model.bookCode = bookCode;
                model.bookName = bookName;
                model.typeId = typeId;
                model.author = author;
                model.price = price;
                model.bookCaseId = bookCaseId;
                model.bookPage = bookPage;
                model.publish = publish;
                //model.operId=operId;
                model.storage = storage;
                //model.InCreateTime=InCreateTime;
                model.bookImg = bookImgName;

                YueDuLibrary.BLL.BookInfo bll = new YueDuLibrary.BLL.BookInfo();
                bll.Update(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");
            }
		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
