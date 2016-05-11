using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GiaoVien_Default : System.Web.UI.Page
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
        DrKhoiLop.DataSource = gvBLL.LayKhoiLop();
        DrKhoiLop.DataTextField = "TenKhoi";
        DrKhoiLop.DataValueField = "MaKhoi";
        DrKhoiLop.DataBind();
    }
   
    public void HienThiLop()
    {
        int khoi = int.Parse(DrKhoiLop.Text);
        KhoiLop kl = new KhoiLop();
        GiaoVien gv = new GiaoVien();
        kl.MaKhoi = khoi;
        int magv = int.Parse(Session["MaGV"].ToString());
        gv.MaGV = magv;
        GridDSLop.DataSource = gvBLL.LayLopHocTheoKhoi_GV(kl,gv);
        GridDSLop.DataBind();
    }

    protected void btnTimLop_Click(object sender, EventArgs e)
    {
        HienThiLop();
    }
}