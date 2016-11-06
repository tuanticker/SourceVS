using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace BaiThiC.layer.DTA
{
    public class Khachhang : Collection
    {
        public DTO.Object_T_Khachhang Select(string Makh)
        {
            SqlDataReader SqlRead = SqlReadAll_Line_ExecuteReader("Select * From Khachhang Where Makh='" + Makh + "'");
            CloseConnection();
            return new DTO.Object_T_Khachhang(SqlRead[0].ToString(), SqlRead[1].ToString(), SqlRead[2].ToString(), SqlRead[3].ToString(), SqlRead[4].ToString());
        }
        public bool Insert(DTO.Object_T_Khachhang Temp_Makh)
        {
            bool Result = Execute_Non_Querry("Insert into Khachhang values('" + Temp_Makh.Makh + "','" + Temp_Makh.Hoten + "','" + Temp_Makh.Gioitinh + "','" + Temp_Makh.Diachi + "','" + Temp_Makh.Dienthoai + "')");
            CloseConnection();
            return Result;
        }
        public DataTable GetTable()
        {
            return UsingDataTable_Get("Select * From Khachhang");
        }
    }
}
