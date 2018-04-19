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
namespace YueDuLibrary.Web.Admin
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadminName.Text.Trim().Length==0)
			{
				strErr+="管理员账号不能为空！\\n";	
			}
			if(this.txtadminPass.Text.Trim().Length==0)
			{
				strErr+="管理员密码不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtadminType.Text))
			{
				strErr+="请选择管理员类型！\\n";	
			}
			if(this.txtadminImg.Text.Trim().Length==0)
			{
				strErr+="请上传管理员头像！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string adminName=this.txtadminName.Text;
			string adminPass=FormsAuthentication.HashPasswordForStoringInConfigFile(this.txtadminPass.Text, "MD5");
            int adminType=int.Parse(this.txtadminType.Text);
			string adminImg=this.txtadminImg.Text;
      
            YueDuLibrary.Model.Admin model=new YueDuLibrary.Model.Admin();
			model.adminName=adminName;
			model.adminPass=adminPass;
			model.adminType=adminType;
			model.adminImg=adminImg;

			YueDuLibrary.BLL.Admin bll=new YueDuLibrary.BLL.Admin();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
