<%@ Page Title="读者类型" Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="YueDuLibrary.Web.ReaderType.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:30px 10px 30px 10px;">
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="add" runat="server" class="btn btn-info" Text="添加类型" OnClick="add_Click" />  
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text="删除类型" OnClick="btnDelete_Click" />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="exit" runat="server" class="btn btn-success" Text="返回" OnClick="exit_Click"  />     
          <p>&nbsp;</p>
   

    <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3" OnPageIndexChanging="gridView_PageIndexChanging"
        BorderWidth="1px" DataKeyNames="id" OnRowDataBound="gridView_RowDataBound" CssClass="table"
        AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated" EnableModelValidation="True">
        <Columns>
            <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                <ItemTemplate>
                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                </ItemTemplate>

                <ControlStyle Width="10px" BorderStyle="None"></ControlStyle>
                <HeaderStyle BorderStyle="None" />
                <ItemStyle BorderStyle="None" HorizontalAlign="Left" Width="30px" />
            </asp:TemplateField>

            <asp:BoundField DataField="typeName" HeaderText="读者类型" SortExpression="typeName" ItemStyle-HorizontalAlign="Center">
                <HeaderStyle BorderStyle="None" />
                <ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="10px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="number" HeaderText="可借书数量"  SortExpression="number" ItemStyle-HorizontalAlign="Center">

                <HeaderStyle BorderStyle="None" />

                <ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="50px"></ItemStyle>
            </asp:BoundField>

            <asp:HyperLinkField  ControlStyle-CssClass="btn btn-warning"  DataNavigateUrlFields="id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                Text="编辑">
                <ControlStyle Width="80px" CssClass="btn btn-warning"></ControlStyle>
            <HeaderStyle BorderStyle="None" />
            <ItemStyle BorderStyle="None" HorizontalAlign="Left" Width="200px" />
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
