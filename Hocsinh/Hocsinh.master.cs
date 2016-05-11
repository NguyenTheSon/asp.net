using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Hocsinh : System.Web.UI.MasterPage
{
    ThongBaoBLL bll = new ThongBaoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillView();
            getTime();
        }
    }
    private void FillView()
    {
        DataTable dt = bll.GetAllThongBao();
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }
    public void getTime()
    {
        string strday = DateTime.Now.ToString("yyyy-MM-dd");
        string strtoday = DateTime.Now.ToString("HH:mm:ss");
        lbltime.Text = "Bây giờ là: " + strtoday.ToString() + " Ngày " + strday.ToString();
    }

}
