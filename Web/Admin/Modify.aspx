<%@ Page Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="YueDuLibrary.Web.Admin.Modify" Title="修改密码" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		管理员账号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadminName" runat="server" Width="200px" ReadOnly="True" CssClass="form-control"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		请输入新密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadminPass" runat="server" Width="200px" CssClass="form-control" ></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		管理员类型：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadminType" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		管理员头像
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadminImg" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
	</td></tr>
<td height="20"></td>

  <tr>
            <td height="25" width="30%" align="right">&nbsp;</td>
            <td height="25" width="*" align="left">
                   <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" CssClass="btn btn-info"></asp:Button>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		 <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" CssClass="btn btn-default"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

