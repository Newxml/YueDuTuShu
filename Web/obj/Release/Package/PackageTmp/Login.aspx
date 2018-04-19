<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="YueDuLibrary.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>管理员登录</title>
   <link rel="stylesheet" type="text/css" href="css/bootstrap-theme.css"/>
   <link rel="stylesheet" type="text/css" href="css/bootstrap-theme.min.css"/>
   <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css"/>
   <link rel="stylesheet" type="text/css" href="css/bootstrap.css"/>
</head>
<body class="jumbotron">
    <form id="form1" runat="server">

        <div style="width: 600px; margin: auto;">
            <div class="panel panel-default">
                <div class="panel-heading text-center">
                    <h4>管理员登录</h4>
                </div>
                <div class="panel-body">
                    <div class="bs-example bs-example-form">
                        <div class="row" style="margin: 0px auto; text-align: center;">
                            <div class="col-md-4 thumbnail">
                                <img src="images/logo.png"
                                    alt="LOGO占位符缩略图"/>
                            </div>
                            <div class="col-lg-8">
                                <div class="input-group input-sm">
                                    <span class="input-group-addon">账号
                                    </span>
                                    <asp:TextBox ID="txtUsername" runat="server" class="form-control" placeholder="请输入账号"></asp:TextBox>
                                   
                                </div>
                                <br />
                                <div class="input-group input-sm">
                                    <span class="input-group-addon">密码
                                    </span>
                                    <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
                                </div>
                                <br />
                                <p><asp:Button ID="Button1" runat="server" Text="登录" class="btn btn-primary btn-lg" OnClick="Button1_Click" /></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
