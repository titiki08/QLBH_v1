﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DAL_PolyCafe;
using DTO_PolyCafe;
using UTIL_PolyCafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_PolyCafe
{
    public partial class FrmPhieuBanHang : Form
    {
        private bool isLoadingTheLuuDongData = true;
        public FrmPhieuBanHang()
        {
            InitializeComponent();
        }
        private void ClearForm(string msThe)
        {
            btnThemPhieu.Enabled = true;
            btnSuaPhieu.Enabled = false;
            btnXoaPhieu.Enabled = true;
            txtMaPhieu.Clear();
            cboNhanVienBH.Enabled = true;
            dtpNgayTao.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdbConfirmation.Enabled = true;
            rdbPaid.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdbConfirmation.Checked = true;
        }

        private void LoadNhanVien()
        {
            try
            {
                BUSNhanVien busNhanVien = new BUSNhanVien();
                List<NhanVien> dsLoai = busNhanVien.GetNhanVienList();
                if (AuthUtil.user == null)
                {
                    dsLoai.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = string.Format("--Vui lòng chọn nhân viên--") });
                }
                else
                {
                    dsLoai = dsLoai.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                    cboNhanVienBH.Enabled = false;
                }
                cboNhanVienBH.DataSource = dsLoai;
                cboNhanVienBH.ValueMember = "MaNhanVien";
                cboNhanVienBH.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTheLuuDong()
        {
            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            List<TheLuuDong> lst = busTheLuuDong.GetTheLuuDongList();
            lst.Insert(0, new TheLuuDong() { MaThe = string.Empty, ChuSoHuu = string.Format("--Tất Cả--") });
            cboMaTheLuuDong.DataSource = lst;
            cboMaTheLuuDong.ValueMember = "MaThe";
            cboMaTheLuuDong.DisplayMember = "ChuSoHuu";
            isLoadingTheLuuDongData = false;
        }

        private void LoadDanhSachPhieu(string maThe)
        {
            BUSPhieuBanHang busPhieuBanHang = new BUSPhieuBanHang();
            List<PhieuBanHang> lst = busPhieuBanHang.GetListPhieuBanHang(maThe);

            if (AuthUtil.user?.VaiTro == false)
            {
                lst = lst.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                cboNhanVienBH.Enabled = false;
            }

            dgrDanhSachPhieu.DataSource = lst;

            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn
            {
                Name = "ThanhToan",
                HeaderText = "Thanh Toán",
                Image = Properties.Resources.pay,
                DefaultCellStyle =
        {
            BackColor = Color.LightBlue,
            ForeColor = Color.DarkBlue,
            Font = new Font("Arial", 10, FontStyle.Bold)
        }
            };

            if (!dgrDanhSachPhieu.Columns.Contains("ThanhToan"))
            {
                dgrDanhSachPhieu.Columns.Add(buttonColumn);
            }

            dgrDanhSachPhieu.Columns["ThanhToan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgrDanhSachPhieu.RowTemplate.Height = 50;
            dgrDanhSachPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgrDanhSachPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieu = dgrDanhSachPhieu.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            string maThe = dgrDanhSachPhieu.Rows[e.RowIndex].Cells["MaThe"].Value.ToString();
            string maNV = dgrDanhSachPhieu.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
            PhieuBanHang phieu = (PhieuBanHang)dgrDanhSachPhieu.CurrentRow.DataBoundItem;
            TheLuuDong the = new TheLuuDong();
            NhanVien nv = new NhanVien();
            foreach (TheLuuDong item in cboMaTheLuuDong.Items)
            {
                if (item.MaThe == maThe)
                {
                    the = item;
                    break;
                }
            }

            foreach (NhanVien item in cboNhanVienBH.Items)
            {
                if (item.MaNhanVien == maNV)
                {
                    nv = item;
                    break;
                }
            }
            FrmChiTietPhieu frmChiTiet = new FrmChiTietPhieu(the, phieu, nv);
            frmChiTiet.ShowDialog();
        }

        private void dgrDanhSachPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isLoadingTheLuuDongData = true;
            DataGridViewRow row = dgrDanhSachPhieu.Rows[e.RowIndex];
            cboMaTheLuuDong.SelectedValue = row.Cells["MaThe"].Value.ToString();
            cboNhanVienBH.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
            dtpNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
            txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdbPaid.Checked = true;
                rdbPaid.Enabled = false;
                rdbConfirmation.Enabled = false;
                cboNhanVienBH.Enabled = false;
                dtpNgayTao.Enabled = false;
                btnThemPhieu.Enabled = false;
                btnSuaPhieu.Enabled = false;
                btnXoaPhieu.Enabled = false;

            }
            else
            {
                rdbPaid.Checked = false;
                rdbPaid.Enabled = true;
                rdbConfirmation.Enabled = true;
                cboNhanVienBH.Enabled = true;
                rdbConfirmation.Checked = true;
                rdbConfirmation.Enabled = true;
                dtpNgayTao.Enabled = true;
                // Bật nút "Sửa"
                btnThemPhieu.Enabled = false;
                btnSuaPhieu.Enabled = true;
                btnXoaPhieu.Enabled = true;
            }

        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string maNhanVien = cboNhanVienBH.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai;
            if (rdbConfirmation.Checked)
            {
                trangThai = false;
            }
            else
            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUSPhieuBanHang bus = new BUSPhieuBanHang();
            string result = bus.InsertPhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cboMaTheLuuDong.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string maPhieu = txtMaPhieu.Text;
            string maNhanVien = cboNhanVienBH.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai;
            if (rdbConfirmation.Checked)
            {
                trangThai = false;
            }
            else


            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaPhieu = maPhieu,
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUSPhieuBanHang bus = new BUSPhieuBanHang();
            string result = bus.UpdatePhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cboMaTheLuuDong.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maThe = cboMaTheLuuDong.SelectedValue?.ToString();
            string chuSoHuu = cboMaTheLuuDong.Text;
            if (string.IsNullOrEmpty(maPhieu))
            {
                if (dgrDanhSachPhieu.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgrDanhSachPhieu.SelectedRows[0];
                    maPhieu = selectedRow.Cells["MaPhieu"].Value.ToString();
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin phiếu bán hàng cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu bán hàng {maPhieu} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSPhieuBanHang bus = new BUSPhieuBanHang();
                string kq = bus.DeletePhieuBanHang(maPhieu);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin phiếu bán hàng {maPhieu} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(maThe);
                    LoadTheLuuDong();
                    LoadNhanVien();
                    LoadDanhSachPhieu("");

                    cboMaTheLuuDong.SelectedValue = maThe;
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnMoiPhieu_Click(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }

        private void FrmPhieuBanHang_Load(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
