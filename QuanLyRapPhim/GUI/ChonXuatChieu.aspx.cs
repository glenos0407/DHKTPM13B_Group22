using QLRPWCFServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class ChonXuatChieu : System.Web.UI.Page
    {
        private QLRP ql = new QLRP();
        List<Entities.eSuatChieu> lstSuatChieu = new List<Entities.eSuatChieu>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NhanVienDangNhap"] == null)
            {
                Response.Redirect("DangNhap.aspx");
                return;
            }
        }

        protected void Unnamed1_Init(object sender, EventArgs e)
        {
            //lstSuatChieu = (ql.GetSuatChieuByID(Convert.ToInt32(txtchonXuatChieu.Text)));
            //foreach (var item in lstSuatChieu)
            //    if (Session["NhanVienDangNhap"] == null)

            //    {
            //        TableRow row1 = new TableRow();
            //        TableRow row2 = new TableRow();
            //        TableCell cell1 = new TableCell();
            //        TableCell cell2 = new TableCell();

            //        Label lb_ten = new Label();
            //        Label lb_xuatchieu = new Label();
                    
            //        lb_xuatchieu.Text = item.thoiGianChieu;
            //        lb_xuatchieu.Attributes.Add("onclick", "document.location.href=\"/SuatChieu?Id=\"");

            //        cell1.Controls.Add(cell1);
            //        cell2.Controls.Add(cell2);

            //        row1.Controls.Add(cell1);
            //        row2.Controls.Add(cell2);
            //        tblChonXuatChieu.Controls.Add(row1);
            //        tblChonXuatChieu.Controls.Add(row2);
            //    }
        }
    }
}