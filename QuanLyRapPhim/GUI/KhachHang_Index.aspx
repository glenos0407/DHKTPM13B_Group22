<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KhachHang_Index.aspx.cs" Inherits="GUI.KhachHang_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
</head>
<body>
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
                <div id="slide-" class="carousel slide" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#slide-" data-slide-to="0" class="active"></li>
                        <li data-target="#slide-" data-slide-to="1"></li>
                        <li data-target="#slide-" data-slide-to="2"></li>
                        <li data-target="#slide-" data-slide-to="3"></li>
                        <li data-target="#slide-" data-slide-to="4"></li>
                    </ol>
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img style="width:100%; " src="../image/slide0.png" alt="First slide">
                        </div>
                        <div class="carousel-item">
                            <img style="width:100%; " src="../image/slide1.jpg" alt="Second slide">
                        </div>
                        <div class="carousel-item">
                            <img style="width:100%; " src="../image/slide2.jpg" alt="Third slide">
                        </div>
                        <div class="carousel-item">
                            <img style="width:100%; " src="../image/slide3.jpg" alt="Fourth slide">
                        </div>
                        <div class="carousel-item">
                            <img style="width:100%; " src="../image/slide4.jpg" alt="Fifth slide">
                        </div>
                    </div>
                    <a class="carousel-control-prev" href="#slide-" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#slide-" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
            </div>
            <div>
                <div class="wrapper" id="phim">
                    <h2>PHIM ĐANG CHIẾU</h2>
                    <div class="informov">
                        <div class="hovereffect">
                            <a href="#" ><img src="../image/poster0" class="img-responsive"></img></a>
                        </div>
                        <h5>TenPhim</h5>
                        <a class="btn btn-success" href="#"><i class="fa fa-ticket-alt" aria-hidden="true"></i> MUA VÉ</a>
                    </div>

                    <div class="informov">
                        <div class="hovereffect">
                            <a href="#" ><img src="../image/poster1" class="img-responsive"></img></a>
                        </div>
                        <h5>TenPhim</h5>
                        <a class="btn btn-success" href="#"><i class="fa fa-ticket-alt" aria-hidden="true"></i> MUA VÉ</a>
                    </div>

                    <div class="informov">
                        <div class="hovereffect">
                            <a href="#" ><img src="../image/poster2" class="img-responsive"></img></a>
                        </div>
                        <h5>TenPhim</h5>
                        <a class="btn btn-success" href="#"><i class="fa fa-ticket-alt" aria-hidden="true"></i> MUA VÉ</a>
                    </div>

                    <div class="informov">
                        <div class="hovereffect">
                            <a href="#" ><img src="../image/poster3" class="img-responsive"></img></a>
                        </div>
                        <h5>TenPhim</h5>
                        <a class="btn btn-success" href="#"><i class="fa fa-ticket-alt" aria-hidden="true"></i> MUA VÉ</a>
                    </div>

                    <div class="informov">
                        <div class="hovereffect">
                            <a href="#" ><img src="../image/poster4" class="img-responsive"></img></a>
                        </div>
                        <h5>TenPhim</h5>
                        <a class="btn btn-success" href="#"><i class="fa fa-ticket-alt" aria-hidden="true"></i> MUA VÉ</a>
                    </div>

                    <div class="informov">
                        <div class="hovereffect">
                            <a href="#" ><img src="../image/poster5" class="img-responsive"></a>
                        </div>
                        <h5>TenPhim</h5>
                        <a class="btn btn-success" href="#"><i class="fa fa-ticket-alt" aria-hidden="true"></i> MUA VÉ</a>
                    </div>

                </div>
            </div>
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
    <script src="Scripts/jquery-3.5.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery.flexslider.js"></script>
    <script src="Scripts/all.js"></script>
    <script src="Scripts/data.js"></script>
    <script src="Scripts/dataaccess.js"></script>
</body>
</html>
