<%@ Page Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="YueDuLibrary.Web.BookType.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

    <br />
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		图书类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttypeName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		可借天数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbrDays" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="auto-style1">
                
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
            </asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
