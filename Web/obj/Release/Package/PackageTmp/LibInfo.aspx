<%@ Page Title="" Language="C#" MasterPageFile="~/YDLib.Master" AutoEventWireup="true" CodeBehind="LibInfo.aspx.cs" Inherits="YueDuLibrary.Web.LibInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    /* body{
      margin-left: 50px;
      width: 800px;
  
    } */
    #td1{
    width: 400px;
     text-align: right;
     font-size: 18px;
    }
    #td2{
           font-size:medium;
            
    }

</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="panel panel-primary">
        <div class="panel-heading"><h4>图书馆信息</h4></div>
        <div class="panel-body">
       <h3>图书馆名称:</h3>
       <div class="well"><h4><b>悦读图书馆</b></h4></div>
            <table class="table">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
                    <ItemTemplate>
                        <tbody>
                            <tr class="active">
                                <td id="td1">馆&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;主</td>
                                <td>:</td>
                                <td></td>
                                <td id="td2">&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("curator") %></td>
                            </tr>
                            <tr class="active">
                                <td id="td1">手&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;机</td>
                                <td>:</td>
                                <td></td>
                                <td id="td2">&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("tel") %></td>
                            </tr>
                            <tr class="active">
                                <td id="td1">E&nbsp;&nbsp;-&nbsp;&nbsp;&nbsp;m&nbsp;a&nbsp;i&nbsp;l</td>
                                <td>:</td>
                                <td></td>
                                <td id="td2">&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("email") %></td>
                            </tr>
                            <tr class="active">
                                <td id="td1">办&nbsp;馆&nbsp;时&nbsp;间</td>
                                <td>:</td>
                                <td></td>
                                <td id="td2">&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("createDate") %></td>
                            </tr>
                            <tr class="active">
                                <td id="td1">图书馆地址</td>
                                <td>:</td>
                                <td></td>
                                <td id="td2">&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("Addresss") %></td>
                            </tr>
                            <tr class="active">
                                <td id="td1">图书馆信息</td>
                                <td>:</td>
                                <td></td>
                                <td id="td2">&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("remark") %></td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YueDuLibraryConnectionString %>" SelectCommand="SELECT [libarayName], [curator], [tel], [Addresss], [email], [createDate], [remark] FROM [Library]"></asp:SqlDataSource>


            </table>
      
   
        </div>

      </div>
</asp:Content>
