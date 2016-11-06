using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace BaiThiC.layer.DTA
{
    public class Phieuxuat : Collection
    {
        public DTO.Object_T_Phieuxuat Select(string Maphieu)
        {
            SqlDataReader SqlRead = SqlReadAll_Line_ExecuteReader("Select * From Phieuxuat Where Maphieu='" + Maphieu + "'");
            CloseConnection();
            return new DTO.Object_T_Phieuxuat(SqlRead[0].ToString(), SqlRead[1].ToString(), SqlRead[2].ToString(), DateTime.Parse(SqlRead[3].ToString()),Int32.Parse(SqlRead[4].ToString()),float.Parse(SqlRead[5].ToString()));
        }
        public bool Insert(DTO.Object_T_Phieuxuat Temp_Makh)
        {
            bool Result = Execute_Non_Querry("Insert into Phieuxuat values('" + Temp_Makh.Maphieu + "','" + Temp_Makh.Masp + "','" + Temp_Makh.Makh + "','" + Temp_Makh.Ngayxuat + "','" + Temp_Makh.Soluong + "','" + Temp_Makh.Dongia + "')");
            CloseConnection();
            return Result;
        }
        public DataTable GetTable()
        {
            return UsingDataTable_Get("Select * From Phieuxuat");
        }
    }
}
