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
    NguoiDungBLL bllnd = new NguoiDungBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridView();
            if (Request.QueryString["action"] != null)
            {
                string action = Request.QueryString["action"];
                int mahs = Convert.ToInt16(Request.QueryString["MaHS"]);
                HocSinhDTO hs = bll.GetAHS(mahs);
                txtmahs.Text = Convert.ToString(hs.MaHS);
                txthotenhs.Text = hs.HotenHS.ToString();
                txtns.Text = Convert.ToString(hs.NgaySinh);
                txtdc.Text = Convert.ToString(hs.DiaChi);
                txtmalop.Text = Convert.ToString(hs.MaLop);
                txttaikhoan.Text = hs.TaiKhoan.ToString();
            }
        }
    }
    private void FillGridView()
    {
        DataTable table = bll.GetAllHocSinh();
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ClearTextbox();
    }
    public void ClearTextbox()
    {
        txtmahs.Text = "";
        txthotenhs.Text = "";
        txtns.Text = "";
        txtdc.Text = "";
        txtmalop.Text = "";
        txtmahs.Focus();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        NguoiDungDTO nd = new NguoiDungDTO();
        nd.Taikhoan = txttaikhoan.Text;
        nd.Matkhau = "123456".ToString();
        nd.Quyen = "hocsinh".ToString();
        nd.CauhoiBM = "";
        nd.Traloi = "";
        bllnd.SaveNguoidung(nd);
        HocSinhDTO hs = new HocSinhDTO();
        hs.HotenHS = txthotenhs.Text;
        hs.NgaySinh = Convert.ToDateTime(txtns.Text);
        hs.DiaChi = txtdc.Text;
        hs.TaiKhoan = txttaikhoan.Text;
        bll.SaveHocsinh(hs);
        ClearTextbox();
        FillGridView();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        HocSinhDTO hs = new HocSinhDTO();
        hs.HotenHS = txthotenhs.Text;
        hs.NgaySinh = Convert.ToDateTime(txtns.Text);
        hs.DiaChi = txtdc.Text;
        hs.TaiKhoan = txttaikhoan.Text;
        bll.EditHocSinh(hs);
        ClearTextbox();
        FillGridView();
    }
    protected void btnHuy_Click(object sender, EventArgs e)
    {
        ClearTextbox();
    }
}