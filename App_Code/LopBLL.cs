using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LopBLL
/// </summary>
public class LopBLL
{
    ConnectDAL dl = new ConnectDAL();
	public LopBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetAllLop()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from LopHoc", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public LopDTO GetALop(string malop)
    {
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select * from LopHoc where MaLop=@malop";
        cmd.Connection = ConnectDAL.cnn;
        cmd.Parameters.AddWithValue("@malop", malop);
        SqlDataReader rd = cmd.ExecuteReader();
        LopDTO lop = new LopDTO();
        if (rd.Read())
        {
            lop.MaLop = Convert.ToString(rd["MaLop"]);
            lop.TenLop = Convert.ToString(rd["TenLop"]);
            lop.KhoiLop = Convert.ToString(rd["KhoiLop"]);
        }
        ConnectDAL.cnn.Close();
        return lop;
    }
    public void SaveLop(LopDTO lp)
    {
        string sql1 = "insert into LopHoc values(@malop,@tenlop,@khoilop)";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql1;
        cmd.Parameters.AddWithValue("@malop", lp.MaLop);
        cmd.Parameters.AddWithValue("@tenlop", lp.TenLop);
        cmd.Parameters.AddWithValue("@khoilop", lp.KhoiLop);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
    public void EditLop(LopDTO lp)
    {
        string sql2 = "update LopHoc set TenLop=@tenlop, KhoiLop=@khoilop where MaLop=@malop";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql2;
        cmd.Parameters.AddWithValue("@malop", lp.MaLop);
        cmd.Parameters.AddWithValue("@tenlop", lp.TenLop);
        cmd.Parameters.AddWithValue("@khoilop", lp.KhoiLop);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
}