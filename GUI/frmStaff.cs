using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmStaff : DevExpress.XtraEditors.XtraUserControl
    {
        private int currenRowIndex;      //vị trí chọn o trong gridControl
        private readonly StaffDTO staffDTO;
        DataTable staffTable = BUS.StaffBUS.SelectAllStaff();
        bool insert = false;
        bool update = false;
        public frmStaff()
        {
            InitializeComponent();
            staffDTO = new StaffDTO();
        }

        private void frmLibrarian_Load(object sender, EventArgs e)
        {
            LoadTableStaff();
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;

        }
        public void LoadData()
        {
            currenRowIndex = gridView1.FocusedRowHandle;
            if (currenRowIndex < 0) return;
            txt_ID.Text         = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Mã Nhân Viên"]).ToString();
            txt_Name.Text       = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Họ Tên"]).ToString();
            dtp_Birth.EditValue = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Ngày Sinh"]);
            txt_Address.Text    = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Địa Chỉ"]).ToString();
            txt_Phone.Text      = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Số Điện Thoại"]).ToString();
            txt_Level.Text      = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Tên Chức Vụ"]).ToString();
            txt_Department.Text  = gridView1.GetRowCellValue(currenRowIndex, gridView1.Columns["Tên Bộ Phận"]).ToString();
        }

        private void LoadTableStaff()
        {
            gridControl1.DataSource = staffTable;
        }


        private void gridView1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            StaffDTO staff = new StaffDTO();
            staff.ma_nhan_vien = txt_ID.Text;
            staff.ten_nhan_vien = txt_Name.Text;
            staff.ten_bo_phan = txt_Department.Text;
            staff.ten_chuc_vu = txt_Level.Text;
            staff.ngay_sinh = dtp_Birth.Text;
            staff.dia_chi = txt_Address.Text;
            staff.so_dien_thoai = txt_Phone.Text;
            staff.ten_bang_cap = txt_BangCap.Text;
            if (MessageBox.Show("Bạn có muốn cập nhật không ?", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                BUS.StaffBUS.UpdateStaff(staff);
                DialogResult result = MessageBox.Show("Cập nhật thành công!");
                //Load lại table chưa được
            }
            
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            frmAddStaff newStaff = new frmAddStaff();
            newStaff.Show();
        }
    }
}
