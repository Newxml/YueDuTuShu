using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YueDuLibrary.Web
{
    public partial class Back : System.Web.UI.Page
    {
        BLL.Readers readers = new BLL.Readers();
        BLL.BookInfo BookInfo = new BLL.BookInfo();
        BLL.ReaderType ReaderType = new BLL.ReaderType();
        BLL.BorrowandReturn borrowandReturn = new BLL.BorrowandReturn();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnSer_Click(object sender, EventArgs e)
        {
            string txtReadSer = this.txtReaderSer.Text.Trim();
            if (!string.IsNullOrEmpty(txtReadSer))
            {
                Model.Readers readersModel = readers.GetModeByNumber(txtReadSer);
                Model.ReaderType ReadtypeModel = ReaderType.GetModel(readersModel.ReadtypeID);
                DataSet ds = borrowandReturn.GetList2(" BorrowandReturn.ReaderID=" + readersModel.Id);
                GridView2.DataSource = ds;
                GridView2.DataBind();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    LabName.Text = readersModel.Name;
                    LabPer.Text = readersModel.PerType;
                    LabPerNumber.Text = readersModel.PerNumber;
                    LabSex.Text = readersModel.Sex;
                    readID.Text = readersModel.Id.ToString();
                    readTypeId.Text = readersModel.ReadtypeID.ToString();
                    LabReadType.Text = ReadtypeModel.typeName;
                    LabcurNum.Text = ReadtypeModel.number.ToString();
                }

            }

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string bookCode = this.txtBookSer.Text.Trim();
            string readID = this.readID.Text.Trim();
            if (string.IsNullOrEmpty(bookCode) || string.IsNullOrEmpty(readID)) {
                MessageBox.Show(this, "图书编号或者读者编号不能为空");
            }
            YueDuLibrary.Model.BookInfo bookModel = BookInfo.GetModeBybookCode(bookCode);
            if (bookModel != null)
            {

                if (borrowandReturn.BackBook(readID, bookCode))
                {
                    bookModel.storage++;
                    BookInfo.Update(bookModel);
                    MessageBox.Show(this, "还书成功！");
                    DataSet ds = borrowandReturn.GetList2(" BorrowandReturn.ReaderID=" + readID);
                    GridView2.DataSource = ds;               
                    GridView2.DataBind();
                }
                else
                {
                    MessageBox.Show(this, "还书失败！");
                }
            }
            else
            {
                MessageBox.Show(this, "该书不存在！");
            }
        }
    }
}