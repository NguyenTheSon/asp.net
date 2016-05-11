using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Hocsinh_Default : System.Web.UI.Page
{
    MonHocBLL bmh = new MonHocBLL();
    GiaoVienDAL gvDAL = new GiaoVienDAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            drLop.DataSource = gvDAL.GetLop();
            drLop.DataTextField = "TenLop";
            drLop.DataValueField = "MaLop";
            DataBind();

            ddlmonhoc.DataSource = gvDAL.GetMonHoc();
            ddlmonhoc.DataTextField = "TenMonHoc";
            ddlmonhoc.DataValueField = "MaMonHoc";
            DataBind();
        }
    }
    protected void btnkq_Click(object sender, EventArgs e)
    {
        Session["mamh"] = ddlmonhoc.SelectedValue;
        Session["tenlop"] = drLop.SelectedValue;
        Response.Redirect("~/Hocsinh/KetQuaHocTap.aspx");
    }

    protected void btnketqua_Click(object sender, EventArgs e)
    {
        Session["MaHS"] = txths.Text;
        Response.Redirect("~/Hocsinh/Ketquahoctaptheoma.aspx");
    }
}