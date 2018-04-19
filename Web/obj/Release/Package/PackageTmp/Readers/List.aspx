<%@ Page Title="Readers" Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="YueDuLibrary.Web.Readers.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div style="margin:30px 10px 30px 10px;">
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="add" runat="server" class="btn btn-info" Text="添加读者" OnClick="add_Click"/>  
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="btnDelete" runat="server" class="btn btn-danger" Text="删除" OnClick="btnDelete_Click"/>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="exit" runat="server" class="btn btn-success" Text="返回"  OnClick="exit_Click"/> 

         
           
    <div class="input-group navbar-left" style="width:300px;">
        <asp:TextBox ID="txtKeyword" runat="server" class="form-control" placeholder="Search for..."></asp:TextBox>
        <span class="input-group-btn">
       <asp:Button ID="btnSearch" runat="server" Text="搜索" class="btn btn-default"  OnClick="btnSearch_Click" />
        </span>
    </div>
                <p>&nbsp;</p>
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="Id" OnRowDataBound="gridView_RowDataBound" CssClass="table"
                    AutoGenerateColumns="False"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated" EnableModelValidation="True">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>

<ControlStyle Width="30px"></ControlStyle>
                                <HeaderStyle BorderStyle="None" Width="30px" />
                                <ItemStyle BorderStyle="None" />
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="Name" HeaderText="名字" SortExpression="Name" ItemStyle-HorizontalAlign="Center"  > 
                        <HeaderStyle BorderStyle="None" />
<ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="150px"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="Sex" HeaderText="性别" SortExpression="Sex" ItemStyle-HorizontalAlign="Center"  > 
                        <HeaderStyle BorderStyle="None" />
<ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="100px"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="PerType" HeaderText="证件类型" SortExpression="PerType" ItemStyle-HorizontalAlign="Center"  > 
                        <HeaderStyle BorderStyle="None" />
<ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="100px"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="PerNumber" HeaderText="证件号码" SortExpression="PerNumber" ItemStyle-HorizontalAlign="Center"  > 
                        <HeaderStyle BorderStyle="None" />
<ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="250px"></ItemStyle>
                        </asp:BoundField>
                            
                            <asp:HyperLinkField ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  >
<ControlStyle Width="50px"></ControlStyle>
                        <HeaderStyle BorderStyle="None" />
                        <ItemStyle BorderStyle="None" HorizontalAlign="Left" />
                        </asp:HyperLinkField>
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
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


