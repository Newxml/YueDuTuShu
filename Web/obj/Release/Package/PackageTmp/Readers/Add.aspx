<%@ Page Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="YueDuLibrary.Web.Readers.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		姓名：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		性别：</td>
	<td height="25" width="*" align="left">
	    <asp:RadioButtonList ID="RBLSex" runat="server" BorderStyle="None" RepeatDirection="Horizontal">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:RadioButtonList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		证件类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlPertype" runat="server">
            <asp:ListItem>学生证</asp:ListItem>
            <asp:ListItem>教工证</asp:ListItem>
            <asp:ListItem>其他</asp:ListItem>
        </asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		证件号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPerNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		读者类型
	：</td>
	<td height="25" width="*" align="left">
         <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="typeName" DataValueField="id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YueDuLibraryConnectionString2 %>" SelectCommand="SELECT [id], [typeName] FROM [ReaderType]"></asp:SqlDataSource>
	
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
