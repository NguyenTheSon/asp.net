using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for PhanCongCNBLL
/// </summary>
public class PhanCongCNBLL
{
    ConnectDAL dl = new ConnectDAL();
	public PhanCongCNBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetAllPhanCong()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from PhanCongChuNhiem", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public DataTable GetAllLopHoc()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from LopHoc", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public DataTable GetAllGV()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from GiaoVien", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public void SavePCGV(PhanCongCNDTO pc)
    {
        string sql1 = "insert into PhanCongChuNhiem values(@malop,@namhoc,@hocky,@magv)";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql1;
        cmd.Parameters.AddWithValue("@malop", pc.MaLop);
        cmd.Parameters.AddWithValue("@namhoc", pc.NamHoc);
        cmd.Parameters.AddWithValue("@hocky", pc.HocKy);
        cmd.Parameters.AddWithValue("@magv", pc.MaGV);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
}