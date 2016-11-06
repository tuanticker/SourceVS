using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace BaiThiC.layer.BUS
{
    public class Sanpham
    {
        public DTO.Object_T_Sanpham Select(string Masp)
        {
            DTA.Sanpham temp = new DTA.Sanpham();
            return temp.Select(Masp);
        }
        public bool Insert(DTO.Object_T_Sanpham Temp_sp)
        {
            DTA.Sanpham temp = new DTA.Sanpham();
            return temp.Insert(Temp_sp);
        }
        public DataTable GetTable()
        {
            DTA.Sanpham temp = new DTA.Sanpham();
            return temp.GetTable();
        }
    }
}
