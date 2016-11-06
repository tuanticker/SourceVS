using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace BaiThiC.layer.DTA
{
    public class Sanpham : Collection
    {
        public DTO.Object_T_Sanpham Select(string Masp)
        {
            SqlDataReader SqlRead = SqlReadAll_Line_ExecuteReader("Select * From Sanpham Where Makh='" + Masp + "'");
            CloseConnection();
            return new DTO.Object_T_Sanpham(SqlRead[0].ToString(), SqlRead[1].ToString(), Int32.Parse(SqlRead[2].ToString()), float.Parse(SqlRead[3].ToString()));
        }
        public bool Insert(DTO.Object_T_Sanpham Temp_Makh)
        {
            bool Result = Execute_Non_Querry("Insert into Sanpham values('" + Temp_Makh.Masp + "','" + Temp_Makh.Tensp + "','" + Temp_Makh.Soluong + "','" + Temp_Makh.Dongia + "')");
            CloseConnection();
            return Result;
        }
        public DataTable GetTable()
        {
            return UsingDataTable_Get("Select * From Sanpham");
        }
    }
}
