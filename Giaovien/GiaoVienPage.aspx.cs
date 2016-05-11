using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GiaoVien_Default : System.Web.UI.Page
{
    GiaoVienDAL gvDAL = new GiaoVienDAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        int ma;
        string tk = Session["idlogin"].ToString();
        ma = gvDAL.GetMaGiaoVien(tk);
        Session["MaGV"] = ma;
    }
}