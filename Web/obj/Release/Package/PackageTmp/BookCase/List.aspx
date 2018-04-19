<%@ Page Title="书架管理" Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="YueDuLibrary.Web.BookCase.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
     <style type="text/css">	
         .aaa{
             text-align:left;
         }
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:30px 10px 30px 10px;">
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="add" runat="server" class="btn btn-info" Text="添加类型" OnClick="add_Click"/>  
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="btnDelete" runat="server" class="btn btn-danger" Text="删除类型" OnClick="btnDelete_Click"/>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="exit" runat="server" class="btn btn-success" Text="返回" OnClick="exit_Click" />     
          <p>&nbsp;</p>
   
    <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3" OnPageIndexChanging="gridView_PageIndexChanging" DataKeyNames="caseId" OnRowDataBound="gridView_RowDataBound"
        AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated" EnableModelValidation="True" CssClass="table">
        <Columns>
            <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                <ItemTemplate>
                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                </ItemTemplate>

                <ControlStyle Width="30px" BorderStyle="None"></ControlStyle>
                <HeaderStyle BorderStyle="None" Width="50px" HorizontalAlign="Left" />
                <ItemStyle BorderStyle="None" HorizontalAlign="Left" />
            </asp:TemplateField>

            <asp:BoundField DataField="caseName" HeaderText="书架列表" SortExpression="caseName" ItemStyle-HorizontalAlign="Center">

                <ControlStyle BorderStyle="None" />
            <HeaderStyle BorderStyle="None" Width="200px" />

                <ItemStyle HorizontalAlign="Left" BorderStyle="None"></ItemStyle>
            </asp:BoundField>

            <asp:HyperLinkField HeaderText="编辑" ControlStyle-CssClass="btn btn-warning" ControlStyle-Width="50" DataNavigateUrlFields="caseId" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                Text="编辑类型">
                <ControlStyle Width="150px"></ControlStyle>
            <HeaderStyle BorderStyle="None" />
            <ItemStyle BorderStyle="None" BorderWidth="200px" HorizontalAlign="Left" />
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
