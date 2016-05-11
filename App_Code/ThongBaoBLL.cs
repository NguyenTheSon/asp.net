using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ThongBaoBLL
/// </summary>
public class ThongBaoBLL
{
    ConnectDAL dl = new ConnectDAL();
    public ThongBaoBLL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable GetAllThongBao()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from ThongBao", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public DataTable GetAThongBao(int matb)
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from ThongBao where MaTB='" + matb + "'", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public void DelThongBao(int matb)
    {
        dl.getConn();
        SqlCommand cmd = new SqlCommand("Delete from ThongBao where MaTB=@matb", ConnectDAL.cnn);
        cmd.Parameters.AddWithValue("@matb", matb);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
    public void SaveThongBao(ThongBaoDTO tb)
    {
        string sql1 = "insert into ThongBao values(@matb,@ngaytb,@tentb,@nd,@taikhoan)";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql1;
        cmd.Parameters.AddWithValue("@matb", tb.MaTB);
        cmd.Parameters.AddWithValue("@ngaytb", tb.NgayTB);
        cmd.Parameters.AddWithValue("@tentb", tb.TenTB);
        cmd.Parameters.AddWithValue("@nd", tb.NoiDung);
        cmd.Parameters.AddWithValue("@taikhoan", tb.TaiKhoan);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
    public void EditThongBao(ThongBaoDTO tb)
    {
        string sql2 = "update ThongBao set NgayTB=@ngaytb, TenTB=@tentb, NoiDung=@nd where MaTB=@matb";
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = ConnectDAL.cnn;
        cmd.CommandText = sql2;
        cmd.Parameters.AddWithValue("@matb", tb.MaTB);
        cmd.Parameters.AddWithValue("@ngaytb", tb.NgayTB);
        cmd.Parameters.AddWithValue("@tentb", tb.TenTB);
        cmd.Parameters.AddWithValue("@nd", tb.NoiDung);
        cmd.ExecuteNonQuery();
        ConnectDAL.cnn.Close();
    }
    public ThongBaoDTO GetATB(int matb)
    {
        dl.getConn();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select * from ThongBao where MaTB=@matb";
        cmd.Connection = ConnectDAL.cnn;
        cmd.Parameters.AddWithValue("@matb", matb);
        SqlDataReader rd = cmd.ExecuteReader();
        ThongBaoDTO tb = new ThongBaoDTO();
        if (rd.Read())
        {
            tb.MaTB = Convert.ToInt16(rd["MaTB"]);
            tb.NgayTB = Convert.ToDateTime(rd["NgayTB"]);
            tb.TenTB = Convert.ToString(rd["TenTB"]);
            tb.NoiDung = Convert.ToString(rd["NoiDung"]);
            tb.TaiKhoan = Convert.ToString(rd["TaiKhoan"]);
        }
        ConnectDAL.cnn.Close();
        return tb;
    }
}