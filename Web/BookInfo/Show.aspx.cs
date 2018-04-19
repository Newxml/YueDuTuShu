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
namespace YueDuLibrary.Web.BookInfo
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
					int bookId=(Convert.ToInt32(strid));
					ShowInfo(bookId);
				}
			}
		}
		
	private void ShowInfo(int bookId)
	{
            BLL.BookInfo bll = new YueDuLibrary.BLL.BookInfo();
            Model.BookInfo model = bll.GetModel(bookId);
            BLL.BookType bllbooktype = new BLL.BookType();
            Model.BookType modelbooktype = bllbooktype.GetModel(short.Parse(model.typeId));
            BLL.BookCase bllbookcase = new BLL.BookCase();
            Model.BookCase modelbookcase = bllbookcase.GetModel(model.bookCaseId);
            this.lblbookId.Text = model.bookId.ToString();
            this.lblbookCode.Text = model.bookCode;
            this.lblbookName.Text = model.bookName;
            this.lbltypeId.Text = modelbooktype.typeName;
            this.lblauthor.Text = model.author;
            this.lblprice.Text = model.price;
            this.lblbookCaseId.Text = modelbookcase.caseName;
            this.lblbookPage.Text = model.bookPage.ToString();
            this.lblpublish.Text = model.publish;
            //this.lbloperId.Text = model.operId.ToString();
            this.lblstorage.Text = model.storage.ToString();
            this.lblInCreateTime.Text = model.InCreateTime.ToString();
            //this.lblbookImg.Text = model.bookImg;

        }


    }
}
