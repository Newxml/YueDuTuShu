<%@ Page Title="Admin" Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="YueDuLibrary.Web.Admin.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
    <style type="text/css">
        .auto-style1 {
            width: 160px;
        }
        .auto-style2 {
            width: 238px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin: 30px 10px 30px 10px;">
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="add" runat="server" class="btn btn-info" Text="添加管理员" OnClick="add_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text="删除管理员" OnClick="btnDelete_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="exit" runat="server" class="btn btn-success" Text="返回" OnClick="exit_Click" />
        <p>&nbsp;</p>

        <!--Search -->
        <!--Search end-->
        <br />
        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
            <tr>
                <td align="right" class="auto-style1">
                    <b>管理员账号：</b>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtKeyword" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="查询" OnClick="btnSearch_Click" CssClass="btn btn-warning"></asp:Button>
                </td>

                
           
            </tr>
            <tr>
                <td align="right" class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>

                
           
            </tr>
        </table>
      
        <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3" OnPageIndexChanging="gridView_PageIndexChanging"
            BorderWidth="1px" DataKeyNames="adminId" OnRowDataBound="gridView_RowDataBound" CssClass="table"
            AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated" EnableModelValidation="True">
            <Columns>
                <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                    <ItemTemplate>
                        <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                    </ItemTemplate>

                    <ControlStyle Width="30px" BorderStyle="None"></ControlStyle>
                    <FooterStyle BorderStyle="None" />
                    <HeaderStyle BorderStyle="None" />
                    <ItemStyle BorderStyle="None" />
                </asp:TemplateField>

                <asp:BoundField DataField="adminName" HeaderText="管理员账号" SortExpression="adminName" ItemStyle-HorizontalAlign="Center">
                    <HeaderStyle BorderStyle="None" />
                    <ItemStyle HorizontalAlign="Left" BorderStyle="None"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="adminPass" HeaderText="管理员密码" SortExpression="adminPass" ItemStyle-HorizontalAlign="Center">
                    <HeaderStyle BorderStyle="None" />
                    <ItemStyle HorizontalAlign="Left" BorderStyle="None"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="adminType" HeaderText="管理员类型" SortExpression="adminType" ItemStyle-HorizontalAlign="Center">
                    <HeaderStyle BorderStyle="None" />
                    <ItemStyle HorizontalAlign="Left" BorderStyle="None"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="adminImg" HeaderText="管理员头像" SortExpression="adminImg" ItemStyle-HorizontalAlign="Center">

                    <HeaderStyle BorderStyle="None" />
                    <ItemStyle HorizontalAlign="Left" BorderStyle="None"></ItemStyle>
                </asp:BoundField>

                <asp:HyperLinkField HeaderText="修改信息" ControlStyle-Width="50" DataNavigateUrlFields="adminId" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                    Text="编辑">
                    <ControlStyle Width="50px" BorderStyle="None" CssClass="btn btn-warning"></ControlStyle>
                    <FooterStyle BorderStyle="None" />
                    <HeaderStyle BorderStyle="None" />
                    <ItemStyle BorderStyle="None" HorizontalAlign="Left" />
                </asp:HyperLinkField>
                <asp:TemplateField ControlStyle-Width="50" HeaderText="删除" Visible="false">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                            Text="删除"></asp:LinkButton>
                    </ItemTemplate>

                    <ControlStyle Width="50px"></ControlStyle>
                </asp:TemplateField>
            </Columns>

            <RowStyle HorizontalAlign="Center"></RowStyle>
        </asp:GridView>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
