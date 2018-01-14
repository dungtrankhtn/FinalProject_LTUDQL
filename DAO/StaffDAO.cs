using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class StaffDAO
    {
        public static DataTable SelectAllStaff()
        {
            return DataProvider.GetData("SELECT_NV");
        }

        public static void UpdateStaff(StaffDTO staff)
        {
            string strSql = "update NHANVIEN set ho_ten = N'" + staff.ten_nhan_vien + "' ,ngay_sinh = '"+ staff.ngay_sinh +
                "', dia_chi = N'" + staff.dia_chi +"', dien_thoai = '"+staff.so_dien_thoai+"' where ma_nhan_vien = '"+
                staff.ma_nhan_vien+"'";
            DataProvider.ExecNonQuery(strSql);
        }
    }
}
