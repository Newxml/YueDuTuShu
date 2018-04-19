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
namespace YueDuLibrary.Web.Library
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		YueDuLibrary.BLL.Library bll=new YueDuLibrary.BLL.Library();
		YueDuLibrary.Model.Library model=bll.GetModel();
		this.txtlibarayName.Text=model.libarayName;
		this.txtcurator.Text=model.curator;
		this.txttel.Text=model.tel;
		this.txtAddresss.Text=model.Addresss;
		this.txtemail.Text=model.email;
		this.txturl.Text=model.url;
		this.txtcreateDate.Text=model.createDate.ToString();
		this.txtremark.Text=model.remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtlibarayName.Text.Trim().Length==0)
			{
				strErr+="libarayName不能为空！\\n";	
			}
			if(this.txtcurator.Text.Trim().Length==0)
			{
				strErr+="curator不能为空！\\n";	
			}
			if(this.txttel.Text.Trim().Length==0)
			{
				strErr+="tel不能为空！\\n";	
			}
			if(this.txtAddresss.Text.Trim().Length==0)
			{
				strErr+="Addresss不能为空！\\n";	
			}
			if(this.txtemail.Text.Trim().Length==0)
			{
				strErr+="email不能为空！\\n";	
			}
			if(this.txturl.Text.Trim().Length==0)
			{
				strErr+="url不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcreateDate.Text))
			{
				strErr+="createDate格式错误！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string libarayName=this.txtlibarayName.Text;
			string curator=this.txtcurator.Text;
			string tel=this.txttel.Text;
			string Addresss=this.txtAddresss.Text;
			string email=this.txtemail.Text;
			string url=this.txturl.Text;
			DateTime createDate=DateTime.Parse(this.txtcreateDate.Text);
			string remark=this.txtremark.Text;


			YueDuLibrary.Model.Library model=new YueDuLibrary.Model.Library();
			model.libarayName=libarayName;
			model.curator=curator;
			model.tel=tel;
			model.Addresss=Addresss;
			model.email=email;
			model.url=url;
			model.createDate=createDate;
			model.remark=remark;

			YueDuLibrary.BLL.Library bll=new YueDuLibrary.BLL.Library();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
