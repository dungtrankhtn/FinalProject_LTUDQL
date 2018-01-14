using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DegreeDAO
    {
        public static DataTable SelectAllStaff()
        {
            return DataProvider.GetData("SELECT_BANGCAP");
        }
    }
}
