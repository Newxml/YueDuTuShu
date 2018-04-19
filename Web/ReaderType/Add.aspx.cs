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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string typeName=this.txttypeName.Text;
			int number=int.Parse(this.txtnumber.Text);

			YueDuLibrary.Model.ReaderType model=new YueDuLibrary.Model.ReaderType();
			model.typeName=typeName;
			model.number=number;

			YueDuLibrary.BLL.ReaderType bll=new YueDuLibrary.BLL.ReaderType();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
