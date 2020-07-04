<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemPhim.aspx.cs" Inherits="GUI.ThemPhim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.css" type="text/css" />
    <script type="text/javascript" src="Scripts/jquery-3.5.1.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.js"></script>
    <link rel="stylesheet" href="Content/font-awesome.css" type="text/css" />
    <style type="text/css">
        body {
            background-color: rgb(35,35,35);
        }

        .box-center {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        #pnlFormDangNhap {
            padding: 2em;
            background-color: rgb(42, 64, 87);
            border: none;
        }

        label {
            color: lightgray;
        }
    </style>
</head>
<body>
    <form id="frmThemPhim" runat="server">
        <div class="box-center">
            <div style="width: 800px; text-align: right; border: 1px solid black;" id="pnlFormDangNhap">
                <div style="text-align: center;">
                    <h4 style="font-weight: 400; color: lightgray;">THÊM PHIM</h4>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-6">
                        <div class="form-group" style="text-align: left;">
                            <label for="txtTenPhim">Tên Phim</label>
                            <asp:TextBox ID="txtTenPhim" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="text-align: left;">
                            <label>Thể Loại</label>
                            <asp:TextBox ID="txtTheLoai" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="text-align: left;">
                            <label>Đạo Diễn</label>
                            <asp:TextBox ID="txtDaoDien" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="text-align: left;">
                            <label>Thời Lượng</label>
                            <asp:TextBox ID="txtThoiLuong" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="text-align: left;">
                            <label>Ngôn Ngữ</label>
                            <asp:TextBox ID="txtNgonNgu" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="form-group" style="text-align: left;">
                            <label>Lứa Tuổi</label>
                            <asp:TextBox ID="txtLuaTuoi" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="text-align: left;">
                            <label>Ngày Công Chiếu</label>
                            <asp:TextBox ID="txtNgayCongChieu" type="date" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="text-align: left;">
                            <label>Ngày Đóng Phim</label>
                            <asp:TextBox ID="txtNgayDongPhim" type="date" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="text-align: left;">
                            <label for="txtPoster">Poster</label>
                            <br />
                            <asp:TextBox ID="txtPoster" type="file" runat="server" Style="color: lightgray;" CssClass="file"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-12">
                        <div class="form-group" style="text-align: left;">
                            <label>Nội Dung Phim</label>
                            <asp:TextBox TextMode="MultiLine" Rows="6" ID="txtNoiDung" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div>
                    <asp:Button runat="server" ID="btnLuu" CssClass="btn btn-success" Text="Lưu" style="width: 100px;"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
