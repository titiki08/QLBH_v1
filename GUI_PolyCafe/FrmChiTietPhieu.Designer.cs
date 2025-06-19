namespace GUI_PolyCafe
{
    partial class FrmChiTietPhieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnXoaChiTiet = new Button();
            btnThemChiTiet = new Button();
            dgrSanPham = new DataGridView();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtPhanTram = new TextBox();
            txtThanhTien = new TextBox();
            txtGiamGia = new TextBox();
            txtDichVu = new TextBox();
            txtTong = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgrChiTiet = new DataGridView();
            label4 = new Label();
            lbMaPhieu = new Label();
            label3 = new Label();
            lbChuSoHuu = new Label();
            lbNgayLap = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgrSanPham).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrChiTiet).BeginInit();
            SuspendLayout();
            // 
            // btnXoaChiTiet
            // 
            btnXoaChiTiet.Location = new Point(547, 393);
            btnXoaChiTiet.Name = "btnXoaChiTiet";
            btnXoaChiTiet.Size = new Size(61, 29);
            btnXoaChiTiet.TabIndex = 30;
            btnXoaChiTiet.Text = ">>";
            btnXoaChiTiet.UseVisualStyleBackColor = true;
            btnXoaChiTiet.Click += btnXoaChiTiet_Click;
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.Location = new Point(549, 296);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(61, 29);
            btnThemChiTiet.TabIndex = 31;
            btnThemChiTiet.Text = "<<";
            btnThemChiTiet.UseVisualStyleBackColor = true;
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            // 
            // dgrSanPham
            // 
            dgrSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrSanPham.Location = new Point(622, 156);
            dgrSanPham.Name = "dgrSanPham";
            dgrSanPham.ReadOnly = true;
            dgrSanPham.RowHeadersWidth = 51;
            dgrSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrSanPham.Size = new Size(487, 592);
            dgrSanPham.TabIndex = 29;
            dgrSanPham.CellDoubleClick += dgrSanPham_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPhanTram);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(txtDichVu);
            groupBox1.Controls.Add(txtTong);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(11, 564);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 175);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thanh Toán";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(158, 81);
            label9.Name = "label9";
            label9.Size = new Size(21, 20);
            label9.TabIndex = 3;
            label9.Text = "%";
            // 
            // txtPhanTram
            // 
            txtPhanTram.Location = new Point(98, 80);
            txtPhanTram.Name = "txtPhanTram";
            txtPhanTram.Size = new Size(52, 27);
            txtPhanTram.TabIndex = 2;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(98, 127);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(404, 27);
            txtThanhTien.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(206, 80);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.ReadOnly = true;
            txtGiamGia.Size = new Size(297, 27);
            txtGiamGia.TabIndex = 1;
            // 
            // txtDichVu
            // 
            txtDichVu.Location = new Point(358, 32);
            txtDichVu.Name = "txtDichVu";
            txtDichVu.ReadOnly = true;
            txtDichVu.Size = new Size(145, 27);
            txtDichVu.TabIndex = 1;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(98, 29);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(183, 27);
            txtTong.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 131);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 0;
            label8.Text = "Thành Tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 81);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 0;
            label7.Text = "Giảm Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 33);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 0;
            label6.Text = "Dịch Vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 29);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 0;
            label5.Text = "Tổng :";
            // 
            // dgrChiTiet
            // 
            dgrChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrChiTiet.Location = new Point(11, 156);
            dgrChiTiet.Name = "dgrChiTiet";
            dgrChiTiet.RowHeadersWidth = 51;
            dgrChiTiet.Size = new Size(522, 399);
            dgrChiTiet.TabIndex = 27;
            dgrChiTiet.CellEndEdit += dgrChiTiet_CellEndEdit;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(845, 88);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 21;
            label4.Text = "Ngày Lập:";
            // 
            // lbMaPhieu
            // 
            lbMaPhieu.AutoSize = true;
            lbMaPhieu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbMaPhieu.ForeColor = Color.Maroon;
            lbMaPhieu.Location = new Point(579, 88);
            lbMaPhieu.Name = "lbMaPhieu";
            lbMaPhieu.Size = new Size(27, 25);
            lbMaPhieu.TabIndex = 22;
            lbMaPhieu.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(477, 88);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 23;
            label3.Text = "Mã Phiếu:";
            // 
            // lbChuSoHuu
            // 
            lbChuSoHuu.AutoSize = true;
            lbChuSoHuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbChuSoHuu.ForeColor = Color.Maroon;
            lbChuSoHuu.Location = new Point(175, 88);
            lbChuSoHuu.Name = "lbChuSoHuu";
            lbChuSoHuu.Size = new Size(27, 25);
            lbChuSoHuu.TabIndex = 24;
            lbChuSoHuu.Text = "...";
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbNgayLap.ForeColor = Color.Maroon;
            lbNgayLap.Location = new Point(947, 88);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(27, 25);
            lbNgayLap.TabIndex = 25;
            lbNgayLap.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(53, 88);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 26;
            label2.Text = "Chủ Sở Hữu:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(369, 12);
            label1.Name = "label1";
            label1.Size = new Size(458, 46);
            label1.TabIndex = 20;
            label1.Text = "CHI TIẾT PHIẾU BÁN HÀNG";
            // 
            // FrmChiTietPhieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 760);
            Controls.Add(btnXoaChiTiet);
            Controls.Add(btnThemChiTiet);
            Controls.Add(dgrSanPham);
            Controls.Add(groupBox1);
            Controls.Add(dgrChiTiet);
            Controls.Add(label4);
            Controls.Add(lbMaPhieu);
            Controls.Add(label3);
            Controls.Add(lbChuSoHuu);
            Controls.Add(lbNgayLap);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmChiTietPhieu";
            Text = "FrmChiTietPhieu";
            Load += FrmChiTietPhieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgrSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoaChiTiet;
        private Button btnThemChiTiet;
        private DataGridView dgrSanPham;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtPhanTram;
        private TextBox txtThanhTien;
        private TextBox txtGiamGia;
        private TextBox txtDichVu;
        private TextBox txtTong;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgrChiTiet;
        private Label label4;
        private Label lbMaPhieu;
        private Label label3;
        private Label lbChuSoHuu;
        private Label lbNgayLap;
        private Label label2;
        private Label label1;
    }
}