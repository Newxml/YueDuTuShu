<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="YueDuLibrary.Web.BookInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		图书 I D
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbookId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		图书编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbookCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		图书名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbookName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		类别编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltypeId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		作者
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblauthor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td width="30%" align="right" class="auto-style1">
		价格
	：</td>
	<td width="*" align="left" class="auto-style1">
		<asp:Label id="lblprice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		书架编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbookCaseId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		页数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbookPage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出版社
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpublish" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		修改次数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbloperId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		存馆数量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstorage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		入馆时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInCreateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		封面
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbookImg" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




