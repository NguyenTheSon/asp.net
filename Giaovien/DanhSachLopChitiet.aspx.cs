using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GiaoVien_DanhSachLopChitiet : System.Web.UI.Page
{
    GiaoVienBLL1 gvBLL = new GiaoVienBLL1();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["action"] == "hienthi")
        {
            string action = Request.QueryString["action"];
            string malop = Request.QueryString["malop"];
            string tenlop = Request.QueryString["tenlop"];
            LopHoc lh = new LopHoc();
            lh.MaLop = malop;
            gridDSSinhVien.DataSource = gvBLL.LayDanhSachHS(lh);
            gridDSSinhVien.DataBind();
            lbTenLop.Text = tenlop;
        }
    }


}