using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for GiaoVienDAL
/// </summary>
public class GiaoVienDAL
{
    private SqlConnection conn = new SqlConnection("Data Source=24H-PC;Initial Catalog=SoLienLacDT;Integrated Security=True");

    public DataTable GetKhoi()
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("Select * from KhoiLop", conn);
        da.Fill(dt);
        return dt;
    }

    public DataTable GetLop()
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("Select * from LopHoc", conn);
        da.Fill(dt);
        return dt;
    }

    public DataTable GetMonHoc()
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("Select * from MonHoc", conn);
        da.Fill(dt);
        return dt;
    }

    public DataTable GetLopTheoKhoi_GV(int khoi, int magv)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "DanhSachLopTheoKhoi";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Khoi", khoi);
        cmd.Parameters.AddWithValue("@magv", magv);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public DataTable GetLopTheoKhoi(int khoi)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("Select MaLop, TenLop From LopHoc Where KhoiLop="+"'"+khoi+"'",conn);
        da.Fill(dt);
        return dt;
    }

    public DataTable GetDanhSachLopDay(int magv)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "DanhSachLopDay1";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MaGV", magv);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public DataTable GetDanhSachHSLop(string malop)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "DanhSachHSLop";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MaLop", malop);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public DataTable GetDanhSachHSLopNhapDiem(string malop,int magv, int mamh)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "HienThiBangDiem";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@malop", malop);
        cmd.Parameters.AddWithValue("@magv", magv);
        cmd.Parameters.AddWithValue("@mamh", mamh);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }


   

    public DataTable GetXemDiemThanhPhan(int mahs)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "XemDiemThanhPhan";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@mahs", mahs);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public DataTable GetXemDiemTheoMonHoc(int malop, int mamon)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "XemDiemTheoMonHoc";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@lop", malop);
        cmd.Parameters.AddWithValue("@mamh", mamon);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public int GetMaGiaoVien(string tk)
    {
        
        SqlCommand cmd = new SqlCommand();
        conn.Open();
        cmd.Connection = conn;
        cmd.CommandText = "laymagv";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@taikhoan", tk);
        SqlDataReader da = cmd.ExecuteReader();
        if (da.Read())
        {
            int ma;
            ma = Convert.ToInt16(da["MaGV"]);
            conn.Close();
            return ma;
          
        }
        else
        {
            conn.Close();
            return 0;
        }
    }

    public int GetMaMonHoc(int magv, string malop)
    {

        SqlCommand cmd = new SqlCommand();
        conn.Open();
        cmd.Connection = conn;
        cmd.CommandText = "LayMonHocDayTheoLop_GV";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MaGV", magv);
        cmd.Parameters.AddWithValue("@MaLop", malop);
        SqlDataReader da = cmd.ExecuteReader();
        if (da.Read())
        {
            int ma;
            ma = Convert.ToInt16(da["MaMonHoc"]);
            conn.Close();
            return ma;

        }
        else
        {
            conn.Close();
            return 0;
        }
    }

    public void NhapDiemCuoiKy(Diem d)
    {
        conn.Open();
        string sql = "INSERT INTO Diem VALUES(@MaHS,@MaGV,@MaMonHoc,@HocKy,@namhoc,@MaLoaiDiem,@Diem,null)";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MaHS", d.MaHS);
        cmd.Parameters.AddWithValue("@MaGV", d.MaGV);
        cmd.Parameters.AddWithValue("@MaMonHoc", d.MaMonHoc);
        cmd.Parameters.AddWithValue("@HocKy", d.HocKy);
        cmd.Parameters.AddWithValue("@namhoc", d.NamHoc);        
        cmd.Parameters.AddWithValue("@MaLoaiDiem", d.MaLoaiDiem);
        cmd.Parameters.AddWithValue("@Diem", d.DiemNhap);
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public string LayTenLop(string malop)
    {
        conn.Open();
        string sql = "Select TenLop From LopHoc Where MaLop = @malop";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MaLop", @malop);
        SqlDataReader dr = cmd.ExecuteReader();
        if(dr.Read())
        {
            string tenlop = dr["TenLop"].ToString();
            conn.Close();
            return tenlop;
        }
        conn.Close();
        return null;
    }

    public string LayTenMonHoc(int mamh)
    {
        conn.Open();
        string sql = "Select TenMonHoc From MonHoc Where MaMonHoc = @mamh";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@mamh", @mamh);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string tenlop = dr["TenMonHoc"].ToString();
            conn.Close();
            return tenlop;
        }
        conn.Close();
        return null;
    }

    public DataTable LayMonHocTheoLop_GV(int magv, string malop)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "DanhSachMonDay";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MaGV ", magv);
        cmd.Parameters.AddWithValue("@MaLop", malop);
        DataTable da = new DataTable();
        SqlDataAdapter dt = new SqlDataAdapter(cmd);
        dt.Fill(da);
        return da;
    }
    public GiaoVienDAL()
    {
    }
}