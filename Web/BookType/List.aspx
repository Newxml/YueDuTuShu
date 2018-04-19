<%@ Page Title="图书类型" Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="YueDuLibrary.Web.BookType.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 30px 10px 30px 10px;">
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="add" runat="server" class="btn btn-info" Text="添加类型" OnClick="add_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="btnDelete" runat="server" class="btn btn-danger" Text="删除类型" OnClick="btnDelete_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="exit" runat="server" class="btn btn-success" Text="返回" OnClick="exit_Click" />
        <p>&nbsp;</p>


        <br />
        <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3" OnPageIndexChanging="gridView_PageIndexChanging"
            BorderWidth="1px" DataKeyNames="typeId" OnRowDataBound="gridView_RowDataBound" CssClass="table"
            AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated" EnableModelValidation="True">
            <Columns>
                <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                    <ItemTemplate>
                        <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                    </ItemTemplate>

                    <ControlStyle Width="30px" BorderStyle="None"></ControlStyle>
                    <HeaderStyle BorderStyle="None" />
                    <ItemStyle BorderStyle="None" HorizontalAlign="Left" Width="50px" />
                </asp:TemplateField>

                <asp:BoundField DataField="typeName" HeaderText="图书类型" SortExpression="typeName" ItemStyle-HorizontalAlign="Center">
                    <ControlStyle BorderStyle="None" />
                    <HeaderStyle BorderStyle="None" HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="brDays" HeaderText="可借天数" SortExpression="brDays" ItemStyle-HorizontalAlign="Center">

                    <ControlStyle BorderStyle="None" />
                    <HeaderStyle BorderStyle="None" />

                    <ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="100px"></ItemStyle>
                </asp:BoundField>

                <asp:HyperLinkField HeaderText="编辑" ControlStyle-CssClass="btn btn-warning" ControlStyle-Width="50" DataNavigateUrlFields="typeId" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                    Text="编辑">
                    <ControlStyle Width="50px" BorderStyle="None"></ControlStyle>
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

    </div>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
