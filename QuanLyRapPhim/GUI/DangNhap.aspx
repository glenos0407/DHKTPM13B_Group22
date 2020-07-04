<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="GUI.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>
    <link rel="stylesheet" href="Content/bootstrap.css" type="text/css" />
    <script type="text/javascript" src="Scripts/jquery-3.5.1.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.js"></script>
    <link rel="stylesheet" href="Content/font-awesome.css" type="text/css" />
    <style type="text/css">
        body{
            background-color: rgb(35,35,35);
        }

        .box-center {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 80vh;
        }
        #pnlFormDangNhap{
            padding: 2em;
            height: 300px;
            background-color: rgb(42, 64, 87);
            border: none;
        }

        #txtTenDangNhap, #txtMatKhau{
            font-size: 1.5em;
            padding: 5px;
            outline: none;
            border: none;   
        }

        #btnDangNhap{
            margin-top: 20px;   
            border-radius: 0;
            padding: 0.6em 0.8em;
            width: 140px;
            background-color: rgb(2, 200, 113);
            font-weight: 500;
            color: rgb(45,45,45);
        }

        #btnDangNhap:hover{
             background-color: rgb(2, 230, 113);
        }
    </style>
</head>
<body>
    <form id="frmDangNhap" runat="server">
        <div class="box-center">
            <div style="width: 400px; text-align: right; border: 1px solid black;" id="pnlFormDangNhap">
                <div style="text-align: center;"><h4 style="font-weight: 400; color: lightgray;">ĐĂNG NHẬP HỆ THỐNG</h4></div>
                <br />
                <div style="text-align: center;">
                    <span style="color: lightgray;"><i class="fa fa-user" aria-hidden="true"></i>&emsp;</span>
                    <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
                </div>
                <div style="text-align: center; margin-top: 1.2em;">
                    <span style="color: lightgray;"><i class="fa fa-lock" aria-hidden="true"></i>&emsp;</span>
                    <asp:TextBox ID="txtMatKhau" runat="server" type="password"></asp:TextBox>
                </div>
                <div style="padding-right: 0.6em;">
                     <asp:Button runat="server" ID="btnDangNhap" CssClass="btn btn-success" Text="ĐĂNG NHẬP" OnClick="btnDangNhap_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
