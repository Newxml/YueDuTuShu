<%@ Page Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="YueDuLibrary.Web.BookInfo.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		图书编码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbookCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		图书名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbookName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		图书类别
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="typeName" DataValueField="typeId">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YueDuLibraryConnectionString %>" SelectCommand="SELECT [typeId], [typeName] FROM [BookType]"></asp:SqlDataSource>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		作者
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtauthor" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		价格
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtprice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属书架
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlBookCase" runat="server" DataSourceID="SqlDataSource2" DataTextField="caseName" DataValueField="caseId">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:YueDuLibraryConnectionString %>" SelectCommand="SELECT * FROM [BookCase]"></asp:SqlDataSource>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		页数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbookPage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出版社
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpublish" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		存馆数量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstorage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		图书封面
	：</td>
	<td height="25" width="*" align="left">
		<asp:FileUpload ID="fupBookFace" runat="server" />
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
