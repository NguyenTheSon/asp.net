using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hocsinh_Default2 : System.Web.UI.Page
{
    GiaoVienBLL1 gvBLL = new GiaoVienBLL1();
    protected void Page_Load(object sender, EventArgs e)
    {
        int ma = int.Parse(Session["MaHS"].ToString());
        gridBangDiem.DataSource = gvBLL.XemDiemThanhPhan(ma);
        gridBangDiem.DataBind();
    }
}