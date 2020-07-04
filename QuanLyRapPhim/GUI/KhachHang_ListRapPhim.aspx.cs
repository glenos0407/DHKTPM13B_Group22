using QLRPWCFServices;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class KhachHang_ListRapPhim : System.Web.UI.Page
    {
        private QLRP ql = new QLRP();
        List<Entities.eRapPhim> lstRapPhim = new List<Entities.eRapPhim>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Init(object sender, EventArgs e)
        {
            lstRapPhim = ql.GetAllRapPhim();
            foreach (var item in lstRapPhim)
            {
                TableRow row = new TableRow();
                TableCell cel1 = new TableCell();
                TableCell cel2 = new TableCell();
                TableCell cel3 = new TableCell();

                Label lb_id = new Label();
                Label lb_diaChi = new Label();
                Label lb_Ten = new Label();


                lb_id.Text = item.idRapPhim.ToString();
                lb_Ten.Text = item.tenRap;
                lb_diaChi.Text = item.diaChi;

                lb_Ten.Attributes.Add("onclick", "javascript:window.location.href=KhachHang_InforPhim.aspx?Id=" + item.idRapPhim);

                cel1.Controls.Add(lb_id);
                cel3.Controls.Add(lb_diaChi);
                cel2.Controls.Add(lb_Ten);

                //row.Attributes.Add("runat", "server");

                row.Cells.Add(cel1);
                row.Cells.Add(cel2);
                row.Cells.Add(cel3);

                tblPhim.Style.Add("background-color", "black");
                tblPhim.Style.Add("style", "border: 1px solid white");
                tblPhim.Rows.Add(row);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("KhachHang_InforRapPhim?Id=" + txtidRap.Text);
            //Response.Redirect("KhachHang_InforPhim);
        }
    }
}