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
namespace YueDuLibrary.Web.Readers
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="名字不能为空！\\n";	
			}
			
			
			
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Name=this.txtName.Text;
            string Sex = this.RBLSex.Text;
            string PerType = this.ddlPertype.Text;
			string PerNumber=this.txtPerNumber.Text;
			int ReadtypeID=int.Parse(this.DropDownList1.Text);

			YueDuLibrary.Model.Readers model=new YueDuLibrary.Model.Readers();
			model.Name=Name;
			model.Sex=Sex;
			model.PerType=PerType;
			model.PerNumber=PerNumber;
			model.ReadtypeID=ReadtypeID;

			YueDuLibrary.BLL.Readers bll=new YueDuLibrary.BLL.Readers();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
