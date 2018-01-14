using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        
        public int CheckValid()
        {
            txt_pass.UseSystemPasswordChar = true;
            string user_name = txt_user.Text;
            string pass_word = txt_pass.Text;
            if (user_name == "")
            {
                lbl_TTlogin.Text = "Chưa nhập tên đăng nhập";
                return 0;
            }
            else if (pass_word == "")
            {
                lbl_TTlogin.Text = "Chưa nhập mật khẩu";
                return 0;
            }
            return 1;
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            if (CheckValid() == 0)
                return;
            DTO.AccoutDTO accout = new DTO.AccoutDTO();
            accout.name_account = txt_user.Text;
            accout.pass_word = txt_pass.Text;


        }
    }
}
