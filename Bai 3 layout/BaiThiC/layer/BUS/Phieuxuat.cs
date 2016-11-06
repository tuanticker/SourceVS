using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace BaiThiC.layer.BUS
{
    public class Phieuxuat
    {
        public DTO.Object_T_Phieuxuat Select(string Maps)
        {
            DTA.Phieuxuat temp = new DTA.Phieuxuat();
            return temp.Select(Maps);
        }
        public bool Insert(DTO.Object_T_Phieuxuat Temp_ps)
        {
            DTA.Phieuxuat temp = new DTA.Phieuxuat();
            return temp.Insert(Temp_ps);
        }
        public DataTable GetTable()
        {
            DTA.Phieuxuat temp = new DTA.Phieuxuat();
            return temp.GetTable();
        }
    }
}
