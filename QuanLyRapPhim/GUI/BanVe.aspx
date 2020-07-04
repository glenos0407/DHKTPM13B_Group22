<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BanVe.aspx.cs" Inherits="GUI.BanVe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bán Vé</title>
    <link rel="stylesheet" href="Content/bootstrap.css" type="text/css" />
    <script type="text/javascript" src="Scripts/jquery-3.5.1.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.js"></script>
    <link rel="stylesheet" href="Content/font-awesome.css" type="text/css" />
</head>
<body>
    <form id="frmBanVe" runat="server">
        <div id="container">
        <nav class="navbar navbar-expand-sm bg-dark fixed-top justify-content-between" id="nav-head">
            <ul class="navbar-nav" id="bar" style="color: #c2d6d6;">
                <li class="nav-item">
                    <a style="color: #f2f2f2;" class="nav-link" href="index.html"><img style="width: 25px; height: 25px; border-radius:100%;" src="../image/bhd-logo.png" /> Trang Chủ</a>
                </li>
                <li class="nav-item">
                    <a style="color: #f2f2f2;" class="nav-link" href="lichchieu.html">Lịch Chiếu</a>
                </li>
                <li class="nav-item">
                    <a style="color: #f2f2f2;" class="nav-link" href="#">Hệ Thống Rạp</a>
                </li>
            </ul>
            <ul class="navbar-nav" id="bar" style="color: #c2d6d6; margin-right: 50px">
                <li class="nav-item">
                    <a style="color: #f2f2f2;" class="nav-link" href="dangky.html">Đăng Ký</a>
                </li>
                <li class="nav-item">
                    <a style="color: #f2f2f2;" class="nav-link" href="#" data-toggle="modal" data-target="#modalLoginForm">Đăng Nhập</a>
                </li>
            </ul>
        </nav>
        <section>
            <!--Modal-->
            <div class="modal fade" id="modalLoginForm" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                  <div class="modal-content">
                    <div class="modal-header text-center">
                      <h4 class="modal-title w-100 font-weight-bold">Đăng nhập</h4>
                      <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                      </button>
                    </div>
                    <div class="modal-body mx-3">
                      <div class="md-form mb-5">
                        <label data-error="wrong" data-success="right" for="defaultForm-email">Số điện thoại</label>
                        <input type="email" id="defaultForm-email" class="form-control validate">
                      </div>
              
                      <div class="md-form mb-4">
                        <label data-error="wrong" data-success="right" for="defaultForm-pass">Password</label>
                        <input type="password" id="defaultForm-pass" class="form-control validate">
                      </div>
              
                    </div>
                    <div class="modal-footer d-flex justify-content-center">
                      <button class="btn btn-default">Login</button>
                    </div>
                  </div>
                </div>
              </div>
              
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
                        
                    </div>
                </div>
        </section>
        <footer style="clear: both; padding-top: 35px;" id="nav-foot" class="footer-bg">
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
        </div>
   
    <script src="..\js\jquery-3.4.0.min.js"></script>
    <script src='..\js\bootstrap.min.js'></script>
    <script src='..\js\bootstrap.js'></script>
    <script src="..\js\jquery.flexslider.js"></script>
    <script src="..\js\all.js"></script>
    <script src="..\js\data.js"></script>
    <script src="..\js\dataaccess.js"></script>
    </form>
</body>

</html>
