using Entities;
using GUI.wcfQLRP;
using QLRPWCFServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class KhachHang_ListPhim : System.Web.UI.Page
    {
        private QLRP ql = new QLRP();
        List<Entities.ePhim> lstPhimConChieu = new List<Entities.ePhim>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Init(object sender, EventArgs e)
        {
            lstPhimConChieu = ql.GetPhimConChieu();
            foreach (var item in lstPhimConChieu)
            {
                TableRow row = new TableRow();
                TableCell cel1 = new TableCell();
                TableCell cel2 = new TableCell();
                TableCell cel3 = new TableCell();
                TableCell cel4 = new TableCell();
                TableCell cel5 = new TableCell();
                TableCell cel6 = new TableCell();

                Label lb_id = new Label();
                Image img_poster = new Image();
                Label lb_Ten = new Label(); 
                Label lb_tenDaoDien = new Label();
                Label lb_theloai = new Label();

                lb_id.Text = item.idPhim.ToString();
                img_poster.ImageUrl = item.poster;
                lb_Ten.Text = item.tenPhim;
                lb_tenDaoDien.Text = item.tenDaoDien;
                lb_theloai.Text = item.theLoai;

                lb_Ten.Attributes.Add("onclick","javascript:document.location.href=\"google.com\"");

                cel1.Controls.Add(lb_id);
                cel2.Controls.Add(img_poster);
                cel3.Controls.Add(lb_Ten);
                cel4.Controls.Add(lb_tenDaoDien);
                cel5.Controls.Add(lb_theloai);

                row.Attributes.Add("runat", "server");

                row.Cells.Add(cel1);
                row.Cells.Add(cel2);
                row.Cells.Add(cel3);
                row.Cells.Add(cel4);
                row.Cells.Add(cel5);
                row.Cells.Add(cel6);

                tblPhim.Style.Add("background-color","black");
                tblPhim.Style.Add("style", "border: 1px solid white");
                tblPhim.Rows.Add(row);
            }
        }
    }
}