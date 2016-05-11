using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Hocsinh_Default2 : System.Web.UI.Page
{
    GiaoVienDAL gvDAL = new GiaoVienDAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        int mamon = int.Parse(Session["mamh"].ToString());
        int malop = int.Parse(Session["tenlop"].ToString());
        gridBangDiem.DataSource = gvDAL.GetXemDiemTheoMonHoc(malop, mamon);
        gridBangDiem.DataBind();
        lblmonhoc.Text = malop.ToString();
    }
}