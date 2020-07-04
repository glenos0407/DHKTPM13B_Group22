using QLRPWCFServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class BanVe : System.Web.UI.Page
    {
        private QLRP ql = new QLRP();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Session["NhanVienDangNhap"] == null)
            //{
            //    Response.Redirect("DangNhap.aspx");
            //    return;
            //}
        }

        protected void Unnamed1_Init(object sender, EventArgs e)
        {
            var lstPhimDangChieu = ql.GetPhimConChieu();
            foreach (var item in lstPhimDangChieu)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                Label lb_ten = new Label();
                lb_ten.Text = item.tenPhim;
                lb_ten.Attributes.Add("onclick", "document.location.href=\"/SuatChieu?Id=\"");

                cell.Controls.Add(cell);
                row.Controls.Add(cell);
                tblBanVe.Controls.Add(row);
            }
        }
    }
}