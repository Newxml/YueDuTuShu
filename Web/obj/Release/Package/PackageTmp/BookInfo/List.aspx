<%@ Page Title="BookInfo" Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="YueDuLibrary.Web.BookInfo.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
    <style>
        .xml{
            margin-top:30px;
        }
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:30px 10px 30px 10px;">
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="add" runat="server" class="btn btn-info" Text="添加新书" OnClick="add_Click"/>  
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="btnDelete" runat="server" class="btn btn-danger" Text="删除" OnClick="btnDelete_Click"/>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="exit" runat="server" class="btn btn-success" Text="返回" OnClick="exit_Click"/> 
    
                                       
    
    <div class="input-group navbar-left" style="width:300px;">
        <asp:TextBox ID="txtKeyword" runat="server" class="form-control" placeholder="Search for..."></asp:TextBox>
        <span class="input-group-btn">
       <asp:Button ID="btnSearch" runat="server" Text="搜索" class="btn btn-default"  OnClick="btnSearch_Click" />
        </span>
    </div>

         <p>&nbsp;</p>
          
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="bookId" OnRowDataBound="gridView_RowDataBound" CssClass="table"
                    AutoGenerateColumns="False"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated" EnableModelValidation="True">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>

<ControlStyle Width="30px"></ControlStyle>
                                <HeaderStyle BorderStyle="None" />
                                <ItemStyle BorderStyle="None" Width="50px" />
                            </asp:TemplateField> 
                            
		                <asp:ImageField HeaderText="图片封面" DataImageUrlField="bookImg" DataImageUrlFormatString="/UploadFiles/{0}">
                            <ControlStyle Height="120px" Width="100px" />
                            <HeaderStyle BorderStyle="None" />
                            <ItemStyle BorderStyle="None" HorizontalAlign="Center" />
                        </asp:ImageField>
                     
		<asp:BoundField DataField="bookName" HeaderText="图书名称" SortExpression="bookName" ItemStyle-HorizontalAlign="Center"  > 
                        <ControlStyle CssClass="xml" />
                        <HeaderStyle BorderStyle="None" />
<ItemStyle HorizontalAlign="Left" BorderStyle="None" Width="150px" ></ItemStyle>  
                        </asp:BoundField>
		<asp:BoundField DataField="author" HeaderText="作者" SortExpression="author" ItemStyle-HorizontalAlign="Center"  > 
          
                        <HeaderStyle BorderStyle="None" />
          
<ItemStyle HorizontalAlign="Left" BorderStyle="None" ></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="publish" HeaderText="出版社" SortExpression="publish" ItemStyle-HorizontalAlign="Center"  > 
                        <HeaderStyle BorderStyle="None" />
<ItemStyle HorizontalAlign="Left" BorderStyle="None" CssClass="xml" Width="180px"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="storage" HeaderText="藏馆数量" SortExpression="storage" ItemStyle-HorizontalAlign="Center"  > 
                        <HeaderStyle BorderStyle="None" />
<ItemStyle HorizontalAlign="Left" BorderStyle="None" CssClass="xml" Width="100px"></ItemStyle>
                        </asp:BoundField>
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="bookId" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"   >
<ControlStyle Width="50px" CssClass="xml"></ControlStyle>
                        <HeaderStyle BorderStyle="None" />
                        <ItemStyle BorderStyle="None" />
                        </asp:HyperLinkField>
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="bookId" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  >
<ControlStyle Width="50px"  CssClass="xml"></ControlStyle>
                        <HeaderStyle BorderStyle="None" />
                        <ItemStyle BorderStyle="None" />
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
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
