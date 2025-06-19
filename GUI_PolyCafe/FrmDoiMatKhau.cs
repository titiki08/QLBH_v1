using BLL_PolyCafe;
using DAL_PolyCafe;
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
    public partial class FrmDoiMatKhau : Form
    {
        BUSNhanVien BUSNhanVien = new BUSNhanVien();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật khẩu cũ chưa đúng!!!");
            }
            else
            {
                if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
                {
                    MessageBox.Show(this, "Mật khẩu cũ chưa đúng!!!");
                }
                else
                {
                    if (!txtMatKhauMoi.Text.Equals(txtXacNhanMatKhau.Text))
                    {
                        MessageBox.Show(this, "Xác nhận mật khẩu mới chưa trùng khớp!!!");
                    }
                    else
                    {
                        AuthUtil.user.MatKhau = txtMatKhauMoi.Text;

                        if (BUSNhanVien.ResetMatKhau(AuthUtil.user.Email, txtMatKhauMoi.Text))
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công!!!");
                            //FrmLogin login = new FrmLogin();
                            //login.Show();
                            //this.Hide();
                        }
                        else MessageBox.Show("Đổi mật khẩu thất bại, vui lòng kiểm tra lại!!!");
                    }
                }
            }
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            if (AuthUtil.user != null)
            {
                txtMaNV.Text = AuthUtil.user.MaNhanVien;
                txtTenNV.Text = AuthUtil.user.HoTen;
            }
        }

        private void chkHienThi1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = chkHienThi1.Checked ? '\0' : '*';
        }

        private void chkHienThi2_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = chkHienThi2.Checked ? '\0' : '*';
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMatKhau.PasswordChar = chkHienThi.Checked ? '\0' : '*';
        }
    }
}
