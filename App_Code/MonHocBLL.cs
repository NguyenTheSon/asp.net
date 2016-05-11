using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MonHocBLL
/// </summary>
public class MonHocBLL
{
    ConnectDAL dl = new ConnectDAL();
	public MonHocBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetAllMonhoc()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from MonHoc", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
}