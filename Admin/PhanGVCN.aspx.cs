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
    PhanCongCNBLL bll = new PhanCongCNBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridView();
            DataTable table = bll.GetAllLopHoc();
            ddlmalop.DataSource = table;
            ddlmalop.DataTextField = "TenLop";
            ddlmalop.DataValueField = "MaLop";
            ddlmalop.DataBind();

            DataTable table1 = bll.GetAllGV();
            ddlmagv.DataSource = table1;
            ddlmagv.DataTextField = "HoTenGV";
            ddlmagv.DataValueField = "MaGV";
            ddlmagv.DataBind();
        }
    }
    private void FillGridView()
    {
        DataTable table = bll.GetAllPhanCong();
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
    protected void btnHuy_Click(object sender, EventArgs e)
    {
        Clear();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Clear();
    }
    public void Clear()
    {
        txtnamhoc.Text = "";
        txthk.Text = "";
        txtnamhoc.Focus();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        PhanCongCNDTO dto = new PhanCongCNDTO();
        dto.MaGV = Convert.ToInt16(ddlmagv.Text);
        dto.MaLop = ddlmalop.Text;
        dto.NamHoc = txtnamhoc.Text;
        dto.HocKy = Convert.ToInt16(txthk.Text);
        bll.SavePCGV(dto);
        Clear();
        FillGridView();
    }
}