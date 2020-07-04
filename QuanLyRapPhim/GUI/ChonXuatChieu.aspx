<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChonXuatChieu.aspx.cs" Inherits="GUI.ChonXuatChieu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chọn Xuất Chiếu</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'/>
    <link rel="stylesheet" type="text/css" href="Content\bootstrap.css"/>
    <link rel="stylesheet" type="text/css" href="Content\bootstrap-theme.min.css"/>
    <link rel="stylesheet" type="text/css" href="Content\css\Layout.css"/>
    <link rel="stylesheet" type="text/css" href="Content\css\flexslider.css"/>
    <link rel="stylesheet" type="text/css" href="Content\css\index.css"/>
    <link rel="stylesheet" type="text/css" href="Content\css\all.css"/>
    <link rel="stylesheet" type="text/css" href="Content\css\image-style.css"/>
</head>
<body>
        <form runat="server">
      <nav class="navbar navbar-expand-lg navbar-light bg-dark">
        <a style="color: #f2f2f2;" class="navbar-brand" href="#"><img style="width: 25px; height: 25px; border-radius:100%; margin-right: 5px; margin-left: 5px" src="Image/logo.jpg" />Trang chủ</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div class="navbar-nav">
                <a style="color: #f2f2f2;" class="nav-item nav-link" href="#">Lịch Chiếu</a>
                <a style="color: #f2f2f2;" class="nav-item nav-link" href="#">Hệ thống rạp</a>
            </div>
        </div>
    </nav>
        <section>
            <asp:Image ImageUrl="" ID="imageBanVe" runat="server"  />
            <asp:Table runat="server" ID="tblChonXuatChieu" OnInit="Unnamed1_Init">
                <asp:TableHeaderRow>
                    <asp:TableCell>Tên phim</asp:TableCell>
                </asp:TableHeaderRow>
                <asp:TableHeaderRow>
                    <asp:TableCell>Chọn Xuất Chiếu </asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
            <asp:TextBox runat="server" ID="txtchonXuatChieu"/>
            <asp:Button Text="Submit" runat="server" ID="submit" />
        </section>
<footer style="clear: both; padding-top: 35px;" id="nav-foot" class="bg-dark">
            <div class="container">
                <div class="row" style="color:#c2d6d6;">
                    <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6">
                        <h3>Giới thiệu</h3>
                        <ul class="list-unstyled clear-margins footer-ul" style="margin-left: 20px;">
                            <li>
                                <a href="about-us.html" style="color:#c2d6d6;"><i class="fas fa-angle-double-right"></i> Về chúng tôi</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Thỏa thuận sử dụng</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Quy chế hoạt động</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Chính sách bảo mật</a>
                            </li>
                        </ul>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6">
                        <h3>Góc điện ảnh</h3>
                        <ul class="list-unstyled clear-margins footer-ul" style="margin-left: 20px;">
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Thể loại</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Bình luận</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Blog điện ảnh</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Phim hay tháng</a>
                            </li>
                        </ul>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6">
                        <h3>Hỗ trợ</h3>
                        <ul class="list-unstyled clear-margins footer-ul" style="margin-left: 20px;">
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Góp ý</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Sales & Service</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Rạp / giá vé</a>
                            </li>
                            <li>
                                <a><i class="fas fa-angle-double-right"></i> Tuyển dụng</a>
                            </li>
                        </ul>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-6 col-xs-6">
                        <h3>Kết nối</h3>
                        <ul id="footer-ul-social">
                            <li>
                                <a><i class="fab fa-facebook-square"></i></a>
                            </li>
                            <li>
                                <a><i class="fab fa-youtube"></i></a>
                            </li>
                            <li>
                                <a><i class="fab fa-instagram"></i></a>
                            </li>
                            <li>
                                <a><i class="fab fa-twitter-square"></i></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </footer>
            </form>
    <script src="Scripts/jquery-3.5.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery.flexslider.js"></script>
    <script src="Scripts/all.js"></script>
    <script src="Scripts/data.js"></script>
    <script src="Scripts/dataaccess.js"></script>
</body>
</html>
