﻿<%@ Page Title="Admin" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="YueDuLibrary.Web.Admin.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="adminId" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="False"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated" EnableModelValidation="True">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>

<ControlStyle Width="30px"></ControlStyle>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="adminName" HeaderText="管理员账号" SortExpression="adminName" ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="adminPass" HeaderText="管理员密码" SortExpression="adminPass" ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="adminType" HeaderText="管理员类型" SortExpression="adminType" ItemStyle-HorizontalAlign="Center"  > 
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
		<asp:BoundField DataField="adminImg" HeaderText="管理员头像" SortExpression="adminImg" ItemStyle-HorizontalAlign="Center"  > 
                            
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="adminId" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  >
<ControlStyle Width="50px"></ControlStyle>
                        </asp:HyperLinkField>
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="adminId" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  >
<ControlStyle Width="50px"></ControlStyle>
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
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>