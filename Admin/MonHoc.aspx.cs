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
    MonHocBLL bll = new MonHocBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridView();
        }
    }
    private void FillGridView()
    {
        DataTable table = bll.GetAllMonhoc();
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
}