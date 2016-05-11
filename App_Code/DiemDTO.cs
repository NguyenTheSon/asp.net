using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DiemDTO
/// </summary>
public class DiemDTO
{
    public int MaHS { get; set; }
    public int MaGV { get; set; }
    public int MaMon { get; set; }
    public int HocKy { get; set; }
    public string NamHoc { get; set; }
    public int DiemMieng1 { get; set; }
    public int DiemMieng2 { get; set; }
    public int DiemMieng3 { get; set; }
    public int Diem15p1 { get; set; }
    public int Diem15p2 { get; set; }
    public int Diem15p3 { get; set; }
    public int Diem45p1 { get; set; }
    public int Diem45p2 { get; set; }
    public int Diem45p3 { get; set; }
	public DiemDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DiemDTO(int mahs, int magv, int mamon, int hk, string namh, int maloaid, int mahsd, int diem)
    {
        this.MaHS = mahs;
        this.MaGV = magv;
        this.MaMon = mamon;
        this.HocKy = hk;
    }
}