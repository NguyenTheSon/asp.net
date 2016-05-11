using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Default2 : System.Web.UI.Page
{
    HocSinhBLL bll = new HocSinhBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        FillGridView();
    }
    private void FillGridView()
    {
        string malop = Session["MaLop"].ToString();
        DataTable table = bll.GetALop(malop);
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
}