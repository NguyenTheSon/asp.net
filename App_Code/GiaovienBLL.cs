using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for GiaovienBLL
/// </summary>
public class GiaovienBLL
{
    ConnectDAL dl = new ConnectDAL();

	public GiaovienBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetAllGiaovien()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from GiaoVien", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public GiaovienDTO GetAGV(int magv)
    {
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select * from GiaoVien where MaGV=@magv";
        cmd.Connection = ConnectDAL.cnn;
        cmd.Parameters.AddWithValue("@magv", magv);
        SqlDataReader rd = cmd.ExecuteReader();
        GiaovienDTO gv = new GiaovienDTO();
        if (rd.Read())
        {
            gv.MaGV = Convert.ToInt16(rd["MaGV"]);
            gv.HotenGV = Convert.ToString(rd["HoTenGV"]);
            gv.Ngaysinh = Convert.ToDateTime(rd["NgaySinh"]);
            gv.Chunhiem = Convert.ToBoolean(rd["ChuNhiem"]);
            gv.Taikhoan = Convert.ToString(rd["TaiKhoan"]);
        }
        ConnectDAL.cnn.Close();
        return gv;
    }
    public void DelGiaoVien(int magv)
    {
        dl.getConn();
        SqlCommand cmd = new SqlCommand("Delete from GiaoVien where MaGV=@magv", ConnectDAL.cnn);
        cmd.Parameters.AddWithValue("@magv", magv);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
    public void SaveGiaovien(GiaovienDTO gv)
    {
        string sql1 = "insert into GiaoVien values(@hoten,@ngaysinh,@cn,@taikhoan)";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql1;
        cmd.Parameters.AddWithValue("@hoten", gv.HotenGV);
        cmd.Parameters.AddWithValue("@ngaysinh", gv.Ngaysinh);
        cmd.Parameters.AddWithValue("@cn", gv.Chunhiem);
        cmd.Parameters.AddWithValue("@taikhoan", gv.Taikhoan);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
    public void EditGiaovien(GiaovienDTO gv)
    {
        string sql2 = "update GiaoVien set HoTenGV=@hotengv, ngaysinh=@ngaysinh where MaGV=@magv";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql2;
        cmd.Parameters.AddWithValue("@magv", gv.MaGV);
        cmd.Parameters.AddWithValue("@hotengv", gv.HotenGV);
        cmd.Parameters.AddWithValue("@ngaysinh", gv.Ngaysinh);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
    
}