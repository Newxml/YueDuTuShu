<%@ Page Title="" Language="C#" MasterPageFile="~/YDLib.Master" AutoEventWireup="true" CodeBehind="Back.aspx.cs" Inherits="YueDuLibrary.Web.Back" %>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        
    <div class="well">
         
            &nbsp;&nbsp;
            <div style="color:rgb(35, 51, 51);font-size:18px;float:right;margin-right:5px;margin-top:4px">读者信息</div>
        </div>
     
      
           <div style="height:30px;"></div> 
            <!-- 读者验证 -->
        <div style="color:rgb(35, 51, 51);font-size:15px;margin-left:80px;">读者验证：
           
            <asp:TextBox ID="txtReaderSer" placeholder="读者编号" runat="server" class="input-sm"></asp:TextBox>
            <asp:Button ID="btnReadSer" runat="server" OnClick="btnSer_Click"  class="btn btn-primary" Text="确定" />
    </div>
            <!-- 高度 -->

            <div style="height:30px;"></div> 
    <div style=""> <!-- 读者信息 -->
        <label class="col-sm-1" style="text-align:right;">姓名:</label>
        <div class="col-sm-1">
              <asp:Label ID="LabName" runat="server" class="form-control input-sm" Text=""></asp:Label>
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
            <asp:Label ID="LabPerNumber" runat="server" class="form-control input-sm" Text="" Width="180px"></asp:Label>
        </div>
           <label class="col-sm-1"style="text-align:right">读者类型:</label>
        <div class="col-sm-1">
            <asp:Label ID="LabReadType" runat="server" class="form-control input-sm" Text=""></asp:Label>
        </div>
           <label class="col-sm-1"style="text-align:right">可借数量:</label>
        <div class="col-sm-1">
            <asp:Label ID="LabcurNum" runat="server" class="form-control input-sm" Text=""></asp:Label>
        </div>
      <asp:Label ID="readID" runat="server" Text="Label"  Visible="False"></asp:Label>
        <asp:Label ID="readTypeId" runat="server" Text="Label"  Visible="False"></asp:Label>
    </div> <!--  end-读者信息 -->

    <div class="clearfix clearfix" style="height: 30px;"></div>
    <hr style="color: red; background-color: blue" />
    <div style="color: rgb(35, 51, 51); font-size: 15px; margin-left: 80px;">
        还书编号：
        
        <asp:TextBox ID="txtBookSer" runat="server" class="input-sm" laceholder="书籍编号"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="确定" OnClick="Button2_Click" />
    </div>
               
 <!-- 已借阅书籍 -->
        <div style="height:30px;"></div>
        <div class="well" style="height:50px ">
            <div style="margin-top:2px"  class="img-rounded"  ></div>       
            <div style="color:rgb(35, 51, 51);font-size:18px;float:right;margin-right:4px;">已借阅书籍</div>
    </div>
  


   
   
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Class="table" >
        <Columns>
            <asp:BoundField DataField="bookName" HeaderText="书名" SortExpression="bookName" >
            <ControlStyle BorderStyle="None" />
            <HeaderStyle BorderStyle="None" />
            <ItemStyle BorderStyle="None" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:ImageField DataImageUrlField="bookImg" DataImageUrlFormatString="/UploadFiles/{0}" HeaderText="封面">
                <ControlStyle BorderStyle="None" />
                <HeaderStyle BorderStyle="None" />
                <ItemStyle Height="150px" Width="220px" BorderStyle="None" />
            </asp:ImageField>
            <asp:BoundField DataField="bookCode" HeaderText="图书编码" SortExpression="bookCode" >
            <ControlStyle BorderStyle="None" />
            <FooterStyle BorderStyle="None" />
            <HeaderStyle BorderStyle="None" />
            <ItemStyle BorderStyle="None" />
            </asp:BoundField>
            <asp:BoundField DataField="BorrowTime" HeaderText="借阅时间" SortExpression="BorrowTime" >
            <FooterStyle BorderStyle="None" VerticalAlign="Middle" />
            <HeaderStyle BorderStyle="None" />
            <ItemStyle BorderStyle="None" />
            </asp:BoundField>
            <asp:BoundField DataField="BackTime" HeaderText="还书时间" SortExpression="BackTime">
            <ControlStyle BorderStyle="None" />
            <FooterStyle BorderStyle="None" />
            <HeaderStyle BorderStyle="None" />
            <ItemStyle BorderStyle="None" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    </asp:Content>
