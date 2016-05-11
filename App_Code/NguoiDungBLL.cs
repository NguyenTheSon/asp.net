using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for NguoiDungBLL
/// </summary>
public class NguoiDungBLL
{
    ConnectDAL dl = new ConnectDAL();

    public string getQuyen(string taikhoan)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = dl.getConn();
        cmd.CommandText = "kiemtraquyen";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
        string check = (string)cmd.ExecuteScalar();
        return check;
    }
    public string getCauHoiBM(string taikhoan)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = dl.getConn();
        cmd.CommandText = "kiemtracauhoi";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
        string check = (string)cmd.ExecuteScalar();
        return check;
    }
    public string getXacNhan(string taikhoan)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = dl.getConn();
        cmd.CommandText = "xacnhan";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
        string check = (string)cmd.ExecuteScalar();
        return check;
    }
    public NguoiDungDTO login(string taikhoan, string matkhau)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = "login_form";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
        cmd.Parameters.AddWithValue("@matkhau", matkhau);
        SqlDataReader rd = cmd.ExecuteReader();
        NguoiDungDTO kl = new NguoiDungDTO();
        if (rd.Read())
        {
            kl.Taikhoan = Convert.ToString(rd["TaiKhoan"]);
            kl.Matkhau = Convert.ToString(rd["MatKhau"]);
            kl.CauhoiBM = Convert.ToString(rd["CauHoiBM"]);
            kl.Traloi = Convert.ToString(rd["TraLoi"]);
            kl.Quyen = Convert.ToString(rd["Quyen"]);
        }
        dl.getConn().Close();
        return kl;
    }

    public DataTable GetAllNguoiDung()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from NguoiDung", dl.getConn());
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }

    public void UpdateNguoidung(NguoiDungDTO nd)
    {
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = "UpdateNguoiDung";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@taikhoan", nd.Taikhoan);
        cmd.Parameters.AddWithValue("@matkhau", nd.Matkhau);
        cmd.ExecuteNonQuery();
        dl.getConn().Close();
    }
    public NguoiDungBLL()
	{
		
	}
    public void SaveNguoidung(NguoiDungDTO nd)
    {
        string sql1 = "insert into NguoiDung values(@taikhoan,@matkhau,@cauhoi,@traloi,@quyen)";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql1;
        cmd.Parameters.AddWithValue("@taikhoan", nd.Taikhoan);
        cmd.Parameters.AddWithValue("@matkhau", nd.Matkhau);
        cmd.Parameters.AddWithValue("@cauhoi", nd.CauhoiBM);
        cmd.Parameters.AddWithValue("@traloi", nd.Traloi);
        cmd.Parameters.AddWithValue("@quyen", nd.Quyen);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
}