using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Lop
    {    
        DAL_Data da = new DAL_Data();
        DTO_Lop L = new DTO_Lop();
        public DataTable showLop()
        {
            string sql = "select *form lop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertLop(string ml, string tl, string ssv)
        {
            
        }
    }
}
