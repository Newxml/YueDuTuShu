
using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YueDuLibrary.Web
{
  
    public partial class Borrow : System.Web.UI.Page
    {
        BLL.Readers readers = new BLL.Readers();
        BLL.BookInfo BookInfo = new BLL.BookInfo();
        BLL.BorrowandReturn borrowandReturn = new BLL.BorrowandReturn();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string txtReadSer = this.txtReadSer.Text.Trim();
            if (!string.IsNullOrEmpty(txtReadSer))
            {
                YueDuLibrary.Model.Readers readersModel = readers.GetModeByNumber(txtReadSer);
                if (readersModel != null)
                {
                    labName.Text = readersModel.Name;
                    LabPer.Text = readersModel.PerType;
                    LabPerNumber.Text = readersModel.PerNumber;
                    LabSex.Text = readersModel.Sex;
                    readID.Text = readersModel.Id.ToString();
                    
                }
                else
                {
                   MessageBox.Show(this, "无该读者信息！");
                }
            }
            else
            {
                MessageBox.Show(this, "请输入读者编号！");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            string txtBookSer = this.txtBookSer.Text.Trim();
            if (!string.IsNullOrEmpty(txtBookSer))
            {
                YueDuLibrary.Model.BookInfo booksModel = BookInfo.GetModeBybookCode(txtBookSer);
                if (booksModel != null)
                {
                    this.imgBookFace.ImageUrl= "UploadFiles/" + booksModel.bookImg;
                    labBookName.Text = booksModel.bookName;
                    labAuthor.Text = booksModel.author;
                    labPublish.Text = booksModel.publish;
                    LabNum.Text = booksModel.storage.ToString();
                    this.btnBorrow.Visible = true;
                }
                else
                {
                    MessageBox.Show(this, "该书未收录图书馆！");
                }
            }
          
        }

        protected void btnBorrow_Click(object sender, EventArgs e)
        {
           string bookCode= this.txtBookSer.Text.Trim();
            YueDuLibrary.Model.BookInfo bookModel = BookInfo.GetModeBybookCode(bookCode);
            if (bookModel != null)
            {
                if (bookModel.storage > 0)
                {
                    bookModel.storage--;
                    BookInfo.Update(bookModel);
                    YueDuLibrary.Model.BorrowandReturn borrowandReturnModel = new Model.BorrowandReturn();
                    borrowandReturnModel.ReaderID = Convert.ToInt32(readID.Text);
                    borrowandReturnModel.BookCode = this.txtBookSer.Text.Trim();
                    borrowandReturn.Add(borrowandReturnModel);
                    MessageBox.Show(this, "借阅成功！");
                    
                }
                else
                {
                    MessageBox.Show( this,"该书已经被借完！");
                }


            }
            else {
                MessageBox.Show(this , "暂无该书！");
            }
            
           
        }
    }
}