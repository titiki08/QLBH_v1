using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_PolyCafe;
namespace GUI_PolyCafe
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();


        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau reset = new FrmDoiMatKhau();
            reset.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            danhMucToolStripMenuItem.Visible = false;
            banHangToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;

            //this.Hide();
            //AuthUtil.user = null;
            //FrmLogin login = new FrmLogin();
            //login.Show();
        }

        private void theLuuDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTheLuuDong());
        }
        private void VaiTroNhanVien()
        {
            danhMucToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;
        }

        private void phieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmPhieuBanHang());
        }

        private void loaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmLoaiSanPham());
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSanPham());
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmNhanVien());
        }

        private void loaiHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDoanhThuLoaiSP());
        }

        private void tkNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDoanhThuNhanVien());
        }

        private void heThongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hdSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {

        }
    }

}
