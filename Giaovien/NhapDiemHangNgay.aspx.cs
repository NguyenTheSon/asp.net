using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GiaoVien_NhapDiem : System.Web.UI.Page
{
    GiaoVienBLL1 gvBLL = new GiaoVienBLL1();
    GiaoVienDAL gvDAL = new GiaoVienDAL();
    string lophoc;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["action"] == "nhapdiem")
        {
            string action = Request.QueryString["nhapdiem"];
            string mahs = Request.QueryString["mahs"];
            Session["mahs"] = mahs;
            lophoc= Session["malop"].ToString();
            lbMaHS.Text = mahs;
        }
        Session["malop"] = lophoc;
    }
    protected void btnLuuDiem_Click(object sender, EventArgs e)
    {
       
       
    }
}