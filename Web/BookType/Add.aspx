<%@ Page Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="YueDuLibrary.Web.BookType.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            height: 25px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td height="25" width="30%" align="right">图书类型
	：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td height="25" width="*" align="left">
                <asp:TextBox ID="txttypeName" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td height="20"></td>
        </tr>
        <tr>
            <td width="30%" align="right" class="auto-style6">可借天数
	：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td width="*" align="left" class="auto-style6">
                <asp:TextBox ID="txtbrDays" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td height="20"></td>
        </tr>
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
