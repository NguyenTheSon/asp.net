using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GiaoVien_DiemThanhPhanChiTiet : System.Web.UI.Page
{
    GiaoVienBLL1 gvBLL = new GiaoVienBLL1();
    string lophoc;
    protected void Page_Load(object sender, EventArgs e)
    {
        LopHoc lh = new LopHoc();
        if (Request.QueryString["action"] == "nhapdiem")
        {
            string action = Request.QueryString["nhapdiem"];
            string malop = Request.QueryString["malop"];
            Session["malop"] = malop;
            
            lh.MaLop = Session["malop"].ToString();
            
        }

        if (Request.QueryString["action"] == "nhapdiem1")
        {
            string action = Request.QueryString["nhapdiem1"];
            string mahs = Request.QueryString["mahs"];
            Session["mahs"] = mahs;
            lophoc = Session["malop"].ToString();
            lbMaHS.Text = mahs;
        }
        Session["malop"] = lophoc;
        lh.MaLop = Session["malop"].ToString();
        GiaoVien gv = new GiaoVien();
        int magv = int.Parse(Session["MaGV"].ToString());
        gv.MaGV = magv;
      
        DSHocSinh.DataBind();
       
    }
    
}