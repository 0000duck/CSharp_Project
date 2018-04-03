using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public static class GetTableFromDtoU
    {
        public static DataTable getTable(string TableName)
        {
            return ConnHELPer.GetDatatable("select * from  "+TableName+" ;");
        }
    }
}
