using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for HocSinhBLL
/// </summary>
public class HocSinhBLL
{
    ConnectDAL dl = new ConnectDAL();
	public HocSinhBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetALop(string malop)
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from HocSinh where MaLop='" + malop + "'", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public DataTable GetAllHocSinh()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from HocSinh ", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public HocSinhDTO GetAHS(int mahs)
    {
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select * from HocSinh where MaHS=@mahs";
        cmd.Connection = ConnectDAL.cnn;
        cmd.Parameters.AddWithValue("@mahs", mahs);
        SqlDataReader rd = cmd.ExecuteReader();
        HocSinhDTO hs = new HocSinhDTO();
        if (rd.Read())
        {
            hs.MaHS = Convert.ToInt16(rd["MaHS"]);
            hs.HotenHS = Convert.ToString(rd["HoTenHS"]);
            hs.NgaySinh = Convert.ToDateTime(rd["NgaySinh"]);
            hs.DiaChi = Convert.ToString(rd["DiaChi"]);
            hs.MaLop = Convert.ToString(rd["MaLop"]);
            hs.TaiKhoan = Convert.ToString(rd["TaiKhoan"]);
        }
        ConnectDAL.cnn.Close();
        return hs;
    }
    public void SaveHocsinh(HocSinhDTO hs)
    {
        string sql1 = "insert into HocSinh values(@hoten,@ngaysinh,@dc,@malop,@taikhoan)";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql1;
        cmd.Parameters.AddWithValue("@hoten", hs.HotenHS);
        cmd.Parameters.AddWithValue("@ngaysinh", hs.NgaySinh);
        cmd.Parameters.AddWithValue("@dc", hs.DiaChi );
        cmd.Parameters.AddWithValue("@taikhoan", hs.TaiKhoan);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
    public void EditHocSinh(HocSinhDTO hs)
    {
        string sql2 = "update HocSinh set HoTenHS=@hotenhs, NgaySinh=@ngaysinh, DiaChi = @diachi where MaHS=@mahs";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql2;
        cmd.Parameters.AddWithValue("@mahs", hs.MaHS);
        cmd.Parameters.AddWithValue("@hotenhs", hs.HotenHS);
        cmd.Parameters.AddWithValue("@ngaysinh", hs.NgaySinh);
        cmd.Parameters.AddWithValue("@diachi", hs.DiaChi);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
}