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
    ThongBaoBLL bll = new ThongBaoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillView();
        }

    }
    public void FillView()
    {
        int matb = Convert.ToInt16(Request.QueryString["MaTB"]);
        DataTable dt = bll.GetAThongBao(matb);
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }
}