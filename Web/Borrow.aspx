<%@ Page Title="" Language="C#" MasterPageFile="~/YDLib.Master" AutoEventWireup="true" CodeBehind="Borrow.aspx.cs" Inherits="YueDuLibrary.Web.Borrow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
    <style type="text/css">
        .auto-style1 {
            width: 256px;
        }
        </style>
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="well">
         
            &nbsp;&nbsp;
            <div style="color:rgb(35, 51, 51);font-size:18px;float:right;margin-right:5px;margin-top:4px">读者信息</div>
        </div>
      
      
           <div style="height:30px;"></div> 
            <!-- 读者验证 -->
        <div style="color:rgb(35, 51, 51);font-size:15px;margin-left:80px;">读者验证：
          <asp:TextBox ID="txtReadSer" runat="server" placeholder="读者编号" class="input-sm"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确定" class="btn btn-primary" />
      </div>
            <!-- 高度 -->

            <div style="height:30px;"></div> 
  <div style=""> <!-- 读者信息 -->
        <label class="col-sm-1" style="text-align:right;">姓名:</label>
        <div class="col-sm-1">
              <asp:Label ID="labName" runat="server" class="form-control input-sm" Text=""></asp:Label>
            </div> 
        <label class="col-sm-1"style="text-align:right">性别:</label>
        <div class="col-sm-1">
             <asp:Label ID="LabSex" runat="server" class="form-control input-sm" Text=""></asp:Label>
        </div>
        
        <label class="col-sm-1" style="text-align:right;">证件类型:</label>
        <div class="col-sm-1">
               <asp:Label ID="LabPer" runat="server" class="form-control input-sm" Text=""></asp:Label>
            </div>
            
        <label class="col-sm-1"style="text-align:right">证件号码:</label>
        <div class="col-sm-1">
            <asp:Label ID="LabPerNumber" runat="server" class="form-control input-sm" Text="" Width="200px"></asp:Label>
        </div>
      <asp:Label ID="readID" runat="server" Text="Label"  Visible="False"></asp:Label>
    </div> <!--  end-读者信息 -->
 <!-- 书籍查询 -->


    <div class="clearfix clearfix" style="height:30px;"></div> 
    <hr style="color:red;  background-color:blue" /> 
    <div style="color:rgb(35, 51, 51);font-size:15px;margin-left:80px;">书籍查询：
        
        <asp:TextBox ID="txtBookSer" runat="server" class="input-sm" laceholder="书籍编号"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" class="btn btn-primary" OnClick="Button2_Click" Text="确定" />
      </div>
            
 <!-- 借阅书籍 -->
        <div style="height:30px;"></div>
        <div class="well" style="height:50px ">
            <div style="margin-top:2px"  class="img-rounded"  ></div>       
            <div style="color:rgb(35, 51, 51);font-size:18px;float:right;margin-right:4px;">借阅书籍</div>
    </div>
      <%--借阅书籍--%>
    

      <table  visble="false" align="center"  id="tbBorrow" class="table">
          <tr>
              <td class="auto-style1">封面</td>
              <td>书名</td>
              <td>作者</td>
              <td>出版社</td>
              <td>馆藏数量</td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td class="auto-style1"><asp:Label ID="labbookImg" runat="server" Text=""></asp:Label>
                  <asp:Image ID="imgBookFace" runat="server" />
                 <%-- <img alt="" class="auto-style2" src="UploadFiles/2017122910444555494.jpg" />--%></td>
              <td><asp:Label ID="labBookName" runat="server" Text=""></asp:Label></td>
              <td><asp:Label ID="labAuthor" runat="server" Text=""></asp:Label></td>
              <td><asp:Label ID="labPublish" runat="server" Text=""></asp:Label></td>
              <td><asp:Label ID="LabNum" runat="server" Text=""></asp:Label> </td>
             <td><asp:Button ID="btnBorrow" runat="server" Text="借阅" OnClick="btnBorrow_Click"  Visible="False" /></td>
          </tr>
      </table>
    

</asp:Content>
