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
    LopBLL bll = new LopBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        FillGridView();
    }
    private void FillGridView()
    {
        DataTable table = bll.GetAllLop();
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
    public void Select_Click(object sender, EventArgs e)
    {
        LinkButton b = (LinkButton)sender;
        if (b.CommandName == "MaLop")
        {
            string malop = Convert.ToString(b.CommandArgument);
            Session["MaLop"] = malop;
        }
        Response.Redirect("~/Admin/DSLop.aspx");
    }
}