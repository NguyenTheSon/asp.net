using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Dangnhap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["idlogin"] = null;
            txttaikhoan.Focus();
        }
    }
    protected void btnDangnhap_Click(object sender, EventArgs e)
    {
        string taikhoan = txttaikhoan.Text.Trim();
        string matkhau = txtmatkhau.Text.Trim();
        NguoiDungBLL bll = new NguoiDungBLL();
        string check = bll.getQuyen(taikhoan);
        NguoiDungDTO dto = bll.login(taikhoan, matkhau);
        if (dto.Taikhoan == taikhoan && dto.Matkhau == matkhau)
        {
            switch (check)
            {
                case "admin": //Truong hop la admin
                    Session["idlogin"] = taikhoan;
                    Response.Write("<script>alert('Đăng nhập thành công!')</script>");
                    Response.Redirect("~/Admin/Default.aspx");
                    break;
                case "giaovien": //Truong hop la giao vien
                    Session["idlogin"] = taikhoan;
                    Response.Write("<script>alert('Đăng nhập thành công!')</script>");
                    Response.Redirect("~/Giaovien/GiaoVienPage.aspx");
                    break;
                case "hocsinh": //Truong hop la hoc sinh
                    Session["idlogin"] = taikhoan;
                    Response.Write("<script>alert('Đăng nhập thành công!')</script>");
                    Response.Redirect("~/Hocsinh/Default.aspx");
                    break;
            }
        }
        else
        {
            Response.Write("<script>alert('Đăng nhập không thành công!')</script>");
        }
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        txttaikhoan.Text = "";
        txtmatkhau.Text = "";
        txttaikhoan.Focus();
    }
}