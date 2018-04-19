<%@ Page Language="C#" MasterPageFile="~/YDLib.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="YueDuLibrary.Web.BookCase.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">         
    
                <div>
                    <h4 class="well">
                        添加书架
                    </h4>
                </div>
       <div style="margin-left:30px;">
                <div>
                    <table>
                        <tr>
                            <td>书架名称：</td>
                            <td><asp:TextBox id="txtcaseName" class="form-control " runat="server" Width="200px"></asp:TextBox></td>
                        </tr>
                    </table>
                    	
                </div>
                <div style="margin-top:20px;margin-left:50px;">
                     <asp:Button ID="btnSave" runat="server" Text="保存" CssClass="btn btn-primary"
                    OnClick="btnSave_Click" class="inputbutton" ></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="Button1" runat="server" Text="取消" CssClass="btn btn-default"
                    OnClick="btnCancle_Click" class="inputbutton" ></asp:Button>                
                </div>
           </div>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
