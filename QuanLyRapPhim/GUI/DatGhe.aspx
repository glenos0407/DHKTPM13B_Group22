<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatGhe.aspx.cs" Inherits="GUI.DatGhe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <section>
            <!--Modal-->
            <div class="modal fade" id="modalLoginForm" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                    <div class="modal-dialog" role="document">
                      <div class="modal-content">
                        <div class="modal-header text-center">
                          <h4 class="modal-title w-100 font-weight-bold" data-toggle="modal" data-target="#modalLoginForm">Đăng nhập</h4>
                          <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                          </button>
                        </div>
                        <div class="modal-body mx-3">
                          <div class="md-form mb-5">
                            <label data-error="wrong" data-success="right" for="defaultForm-email">Số điện thoại</label>
                            <input type="email" id="defaultForm-email" class="form-control validate"/>
                          </div>
                  
                          <div class="md-form mb-4">
                            <label data-error="wrong" data-success="right" for="defaultForm-pass">Password</label>
                            <input type="password" id="defaultForm-pass" class="form-control validate"/>
                          </div>
                  
                        </div>
                        <div class="modal-footer d-flex justify-content-center">
                          <button class="btn btn-default">Login</button>
                        </div>
                      </div>
                    </div>
                  </div>
					<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 container text-center bg-dark mr-auto" style="color: white">
						<div id="infor-movie">

						</div>
						<input type="button" id="btnDaChon" class="btn btn-outline-warning" style="background:red" value="  "/>
						<label for="btnDaChon">Ghế đang chọn</label>
						<input type="button" id="btnGheTrong" class="btn btn-outline-warning" style="background:gray" value="  "/>
						<label for="btnGheTrong">Ghế ghế trống</label>
						<input type="button" id="btnDaBan" class="btn btn-outline-warning" style="background:#CCC" value="  "/>
						<label for="btnDaBan">Ghế đã bán</label>
					</div>
					<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 container text-center bg-dark">
						<h2 style="color:white">SCREEN</h2>
					</div>
					<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 container text-center">
					    <table class="table-dark col-lg-12 col-md-12 col-sm-12 col-xs-12 container" id="ghe">
						    <tbody></tbody>
					    </table>
					</div>
                    <br />
                    <div id="btn-xac-nhan"></div>
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
    </form>
</body>
</html>
