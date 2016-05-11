using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GiaoVien_NhapDiemThanhPhan : System.Web.UI.Page
{
    GiaoVienBLL1 gvBLL = new GiaoVienBLL1();
    protected void Page_Load(object sender, EventArgs e)
    {
        HienThiLop();
        

    }

   
    public void HienThiLop()
    {
       
        GiaoVien gv = new GiaoVien();
        int ma = int.Parse(Session["MaGV"].ToString());
        gv.MaGV = ma;
        gridDSHocSinh.DataSource = gvBLL.LayLopHocTheoGV(gv);
        gridDSHocSinh.DataBind();

    }
    

   
}