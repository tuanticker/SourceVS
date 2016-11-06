using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace BaiThiC.layer.BUS
{
    public class Khachhang
    {
        public DTO.Object_T_Khachhang Select(string Makh)
        {
            DTA.Khachhang temp = new DTA.Khachhang();
            return temp.Select(Makh);
        }
        public bool Insert(DTO.Object_T_Khachhang Temp_kh)
        {
            DTA.Khachhang temp = new DTA.Khachhang();
            return temp.Insert(Temp_kh);
        }
        public DataTable GetTable()
        {
            DTA.Khachhang temp = new DTA.Khachhang();
            return temp.GetTable();
        }
    }
}
