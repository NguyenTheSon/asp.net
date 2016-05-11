using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GiaoVien_TraCuuDanhSachLop : System.Web.UI.Page
{
    GiaoVienBLL1 gvBLL = new GiaoVienBLL1();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            HienThiKhoi();
        }
    }

    public void HienThiKhoi()
    {
        drKhoi.DataSource = gvBLL.LayKhoiLop();
        drKhoi.DataTextField = "TenKhoi";
        drKhoi.DataValueField = "MaKhoi";
        drKhoi.DataBind();
       
    }

    public void HienThiLop()
    {
            int khoi = int.Parse(drKhoi.Text);
            KhoiLop kl = new KhoiLop();
            kl.MaKhoi = khoi;
            gridDSHocSinh.DataSource = gvBLL.LayLopHocTheoKhoi(kl);
            gridDSHocSinh.DataBind();
        
    }

    protected void btnLocDSLop_Click(object sender, EventArgs e)
    {
        HienThiLop();
    }
}