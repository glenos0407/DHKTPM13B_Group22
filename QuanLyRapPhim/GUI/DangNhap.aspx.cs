using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GUI.wcfQLRP;

namespace GUI
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[1-9][0-9]*$");

            if (!regex.IsMatch(txtTenDangNhap.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Đăng Nhập Không Thành Công !')", true);
                return;
            }

            if(txtMatKhau.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Đăng Nhập Không Thành Công !')", true);
                return;
            }

            wcfQLRP.QLRPClient wcfQLRP = new QLRPClient();

            eNhanVien eNhanVien = wcfQLRP.DangNhap(Convert.ToInt32(txtTenDangNhap.Text), txtMatKhau.Text);

            if (eNhanVien != null)
            {
                Session["NhanVienDangNhap"] = eNhanVien;

                if (eNhanVien.chucVu == ChucVu.NhanVienBanVe)
                {
                    Response.Redirect("BanVe.aspx");
  
                }
                if (eNhanVien.chucVu == ChucVu.NhanVienQuanLyRap)
                {
                    Response.Redirect("QuanLyRap.aspx");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Đăng Nhập Không Thành Công !')", true);
                return;
            }
        }
    }
}