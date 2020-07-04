using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class KhachHang_InforPhim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currurl = HttpContext.Current.Request.RawUrl;
            Uri myUri = new Uri("currurl");
            string param1 = HttpUtility.ParseQueryString(myUri.Query).Get("id");
        }
    }
}