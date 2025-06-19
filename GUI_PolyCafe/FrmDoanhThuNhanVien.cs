using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class FrmDoanhThuNhanVien : Form
    {
        public FrmDoanhThuNhanVien()
        {
            InitializeComponent();
        }

        private void FrmDoanhThuNhanVien_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maNV = cbxNhanVien.SelectedValue.ToString();
            DateTime bd = dtpTuNgay.Value.Date;
            DateTime kt = dtpDenNgay.Value.Date;

            BUSThongKe busThongKe = new BUSThongKe();
            List<TKDoanhThuTheoNhanVien> result = busThongKe.getThongKeNhanVien(maNV, bd, kt);
            dgrDanhSachThongKe.DataSource = result;
        }

        private void FrmDoanhThuNhanVien_Load(object sender, EventArgs e)
        {
            // Lấy ngày đầu tháng hiện tại
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            dtpTuNgay.Value = firstDayOfMonth;
            LoadNhanVien();

            btnThongKe_Click(sender, e);
        }
        private void LoadNhanVien()
        {
            try
            {
                BUSNhanVien busNhanVien = new BUSNhanVien();
                List<NhanVien> dsNhanVien = busNhanVien.GetNhanVienList();
                dsNhanVien.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = "--Tất Cả--" });
                cbxNhanVien.DataSource = dsNhanVien;
                cbxNhanVien.ValueMember = "MaNhanVien";
                cbxNhanVien.DisplayMember = "HoTen";

                cbxNhanVien.SelectedIndex = 0; // Đặt mặc định một mục được chọn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
