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
    public partial class frmHome : DevExpress.XtraEditors.XtraForm
    {
        QLThuVien.AddTabControl.TabAdd clsAddTab = new QLThuVien.AddTabControl.TabAdd();

        public frmHome()
        {
            InitializeComponent();
        }
        #region"Kiểm tra tab mở"
        public void TestTab(string nametab, UserControl frm)
        {

            int t = 0;

            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == nametab)
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)//tab có thì chuyển đến tab
            {

            }
            else//nếu chưa có thì mở tab mới
            {
                clsAddTab.AddTab(xtraTabControl1, "", nametab, frm);

            }
        }
        #endregion
        #region "Code cho nut Close xtraTabControl" 
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {// Đóng tab đang focus trên TAb Cha
            if (MessageBox.Show("Bạn có muốn thoát hay không", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }
        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {// Khi add vào thì Focus tới ngay Tab vừa Add
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }
        #endregion
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TestTab("Thông tin nhân viên", new GUI.frmStaff());
        }
    }
}
