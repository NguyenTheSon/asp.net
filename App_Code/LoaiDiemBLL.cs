using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LoaiDiemBLL
/// </summary>
public class LoaiDiemBLL
{
    ConnectDAL dl = new ConnectDAL();
	public LoaiDiemBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetAllLoaiDiem()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from Loaidiem", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
}