using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class StaffBUS
    {
        public static DataTable SelectAllStaff()
        {
            return DAO.StaffDAO.SelectAllStaff();
        }

        public static void UpdateStaff(StaffDTO staff)
        {
            DAO.StaffDAO.UpdateStaff(staff);
        }
    }
}
