using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NguoiDungDTO
/// </summary>
public class NguoiDungDTO
{
    public string Taikhoan { get; set; }
    public string Matkhau { get; set; }
    public string CauhoiBM { get; set; }
    public string Traloi { get; set; }
    public string Quyen { get; set; }
	public NguoiDungDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public NguoiDungDTO(string tk, string mk,string cauhoibm, string traloi, string quyen)
    {
        this.Taikhoan = tk;
        this.Matkhau = mk;
        this.CauhoiBM = cauhoibm;
        this.Traloi = traloi;
        this.Quyen = quyen;
    }
}