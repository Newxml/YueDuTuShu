<%@ Page Title="" Language="C#" MasterPageFile="~/YDLib.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="YueDuLibrary.Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .xml {
            height: 140px;
            width: 180px;
            float: left;
            margin-left: 30px;
            margin-top: 20px;
            box-shadow: 3px 4px 8px gray;
            border-radius: 15px;
        }

            .xml:hover {
                cursor: pointer;
                box-shadow: 6px 3px 8px gray;
            }

            .xml img {
                margin-left: 20px;
            }

            .xml span {
                font-size: 18px;
                color: #777777;
            }

        .center {
            display: block;
            margin: 30px 80px;
        }

        #four {
            margin-left: 35px;
        }

        #five {
            margin-left: 30px;
        }

        #six {
            margin-left: 20px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container center">
        <div class="panel panel-info xml">
            <div class="panel-body">
                <a href="Borrow.aspx"><img height="100" width="108" src="Images/1102.jpg" /><br /></a>
                <span id="four">图书借阅
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                <a href="Back.aspx"><img height="100" width="108" src="Images/1004.png" /><br /></a>
                <span id="four">图书归还
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                 <a href="/bookcase/list.aspx"><img height="100" width="108" src="Images/shujia.jpg" /><br /></a>
                <span id="four">书架管理
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                <a href="/BookType/List.aspx"><img height="100" width="108" src="Images/leixing.jpg" /><br /></a>
                <span id="six">图书类型管理
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                <a href="BookInfo/list.aspx"> <img height="100" width="108" src="Images/777.jpg" /><br /></a>
                <span id="six">图书档案管理
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                <a href="/ReaderType/list.aspx"><img height="100" width="108" src="Images/6655.jpg" /><br /></a>
                <span id="six">读者类型管理
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                <a href="/Readers/list.aspx"><img height="100" width="108" src="Images/duzhedangan.png" /><br /></a>
              <span id="six">读者档案管理
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                <a href="LibInfo.aspx"><img height="100" width="108" src="Images/info.png" /><br /></a>
                <span id="five">图书馆信息
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                <img height="100" width="108" src="Images/guan.png" /><br />
                <span id="five">管理员设置
                </span>
            </div>
        </div>
        <div class="panel panel-info xml">
            <div class="panel-body">
                <a href="login.aspx"><img height="100" width="108" src="Images/exit.jpg" /><br /></a>
                <span id="four">安全退出
                </span>
            </div>
        </div>
    </div>
</asp:Content>
