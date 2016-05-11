using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DiemBLL
/// </summary>
public class DiemBLL
{
    ConnectDAL dl = new ConnectDAL();
	public DiemBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetAllDiem()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("select MaHS,DiemMieng1,DiemMieng2,DiemMieng3,Diem15p1,Diem15p2,Diem15p3,Diem45p1,Diem45p2,Diem45p3 from Diem", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
}