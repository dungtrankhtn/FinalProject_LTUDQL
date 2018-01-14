using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        public string Login(DTO.AccoutDTO accout)
        {
            return AccountDAO.Login(accout);
        }
    }
}
