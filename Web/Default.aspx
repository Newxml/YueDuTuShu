<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YueDuLibrary.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>悦读图书管理系统</title>
    <link rel="stylesheet" type="text/css" href="/css/bootstrap-theme.css"/>
    <link rel="stylesheet" type="text/css" href="/css/bootstrap-theme.min.css"/>
    <link rel="stylesheet" type="text/css" href="/css/bootstrap.min.css"/>
    <link rel="stylesheet" type="text/css" href="/css/bootstrap.css"/>
    <script src="/js/jquery.min.js" type="text/javascript"></script>
    <script src='/js/bootstrap.min.1.js'></script>
    <script src="/js/bootstrap.js"></script>
    <script src="/js/bootstrap.min.js"></script>
    <style type="text/css">
        .pic {
            width: 300px;
            height: 250px;
        }

        .bn {
            width: 150px;
        }
    
    </style>


</head>
<body>
   
    <form id="form1" runat="server">
   
<div class="jumbotron">
    <div class="container">
       <img src="/Images/logo.png" style="width: 80px; margin-right: 20px" class="img-rounded pull-left">
        <h2>欢迎来到悦读图书馆！</h2>
        <h5>悦读图书，快乐的学习。</h5>
    </div>
</div>
      <div class="container">
        <div class="pull-left"><asp:TextBox ID="txtBookName"  placeholder="请输入书名" runat="server" class="form-control" Width="300px"></asp:TextBox></div>
        <div class="pull-left" style="margin-left:30px;"><asp:Button ID="btnSer" runat="server"  class="btn btn-primary" Text="搜索" OnClick="btnSer_Click" /></div>
          <div class="pull-clear"></div>

          <div class="container">
              <asp:DataList ID="DataList1" runat="server" CssClass="container">
           
                  <ItemTemplate>
                      <table class="table table-condensed">
                          <thead>
                              <tr>
                                  <th>封面</th>
                                  <th>书名</th>
                                  <th>作者</th>
                                  <th>出版社</th>
                                  <th>页码</th>
                                  <th>馆存数量</th>
                              </tr>
                          </thead>
                          <tbody>
                              <tr>
                                  <td class="pic">
                                      <asp:Image ID="Image1" runat="server" ImageUrl='<%# "UploadFiles/"+Eval("bookimg") %>' Height="240px" Width="200px" /></td>
                                  <td class="bn">
                                      <asp:Label ID="bName" runat="server" Text='<%# Eval("bookName") %>'></asp:Label></td>
                                  <td class="bn">
                                      <asp:Label ID="Author" runat="server" Text='<%# Eval("author") %>'></asp:Label></td>
                                   <td class="bn">
                                      <asp:Label ID="bPub" runat="server" Text='<%# Eval("publish") %>'></asp:Label></td>
                                  <td class="bn">
                                      <asp:Label ID="bPage" runat="server" Text='<%# Eval("bookPage") %>'></asp:Label></td>
                                  <td class="bn">
                                      <asp:Label ID="storage" runat="server" Text='<%# Eval("storage") %>'></asp:Label></td>
                              </tr>
                          </tbody>
                      </table>
                  </ItemTemplate>
              </asp:DataList>
          </div>
    </form>
</body>
</html>
