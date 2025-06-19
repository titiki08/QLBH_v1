namespace GUI_PolyCafe
{
    partial class FrmSanPham
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
            groupBox1 = new GroupBox();
            txtDonGia = new MaskedTextBox();
            pbHinhAnh = new PictureBox();
            cboLoaiSanPham = new ComboBox();
            rdbDeActive = new RadioButton();
            rdbActive = new RadioButton();
            label8 = new Label();
            btnMoiSanPham = new Button();
            btnXoaSanPham = new Button();
            btnSuaSanPham = new Button();
            btnUploadSanPham = new Button();
            btnThemSanPham = new Button();
            label5 = new Label();
            label4 = new Label();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            txtMaSanPham = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            btnTimKiem = new Button();
            btnTimKiemSP = new Button();
            txtTimKiemSP = new TextBox();
            dgrDanhSachSP = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachSP).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(pbHinhAnh);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(rdbDeActive);
            groupBox1.Controls.Add(rdbActive);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnMoiSanPham);
            groupBox1.Controls.Add(btnXoaSanPham);
            groupBox1.Controls.Add(btnSuaSanPham);
            groupBox1.Controls.Add(btnUploadSanPham);
            groupBox1.Controls.Add(btnThemSanPham);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(14, 96);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(401, 723);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 12F);
            txtDonGia.Location = new Point(142, 196);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(241, 34);
            txtDonGia.TabIndex = 6;
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            pbHinhAnh.Location = new Point(67, 395);
            pbHinhAnh.Margin = new Padding(3, 4, 3, 4);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(263, 186);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinhAnh.TabIndex = 10;
            pbHinhAnh.TabStop = false;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Font = new Font("Segoe UI", 11F);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(142, 273);
            cboLoaiSanPham.Margin = new Padding(3, 4, 3, 4);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(241, 33);
            cboLoaiSanPham.TabIndex = 9;
            // 
            // rdbDeActive
            // 
            rdbDeActive.AutoSize = true;
            rdbDeActive.Font = new Font("Segoe UI", 10F);
            rdbDeActive.ForeColor = Color.Maroon;
            rdbDeActive.Location = new Point(291, 344);
            rdbDeActive.Margin = new Padding(3, 4, 3, 4);
            rdbDeActive.Name = "rdbDeActive";
            rdbDeActive.Size = new Size(118, 27);
            rdbDeActive.TabIndex = 8;
            rdbDeActive.Text = "Ngừng Bán";
            rdbDeActive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            rdbActive.AutoSize = true;
            rdbActive.BackColor = Color.Transparent;
            rdbActive.Checked = true;
            rdbActive.Font = new Font("Segoe UI", 9F);
            rdbActive.ForeColor = Color.Maroon;
            rdbActive.Location = new Point(142, 345);
            rdbActive.Margin = new Padding(3, 4, 3, 4);
            rdbActive.Name = "rdbActive";
            rdbActive.Size = new Size(104, 24);
            rdbActive.TabIndex = 7;
            rdbActive.TabStop = true;
            rdbActive.Text = "Hoạt Động";
            rdbActive.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(7, 349);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 6;
            label8.Text = "Trạng Thái";
            // 
            // btnMoiSanPham
            // 
            btnMoiSanPham.BackColor = SystemColors.Window;
            btnMoiSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoiSanPham.Location = new Point(298, 657);
            btnMoiSanPham.Margin = new Padding(3, 4, 3, 4);
            btnMoiSanPham.Name = "btnMoiSanPham";
            btnMoiSanPham.Size = new Size(96, 55);
            btnMoiSanPham.TabIndex = 3;
            btnMoiSanPham.Text = "Mới";
            btnMoiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoiSanPham.UseVisualStyleBackColor = false;
            btnMoiSanPham.Click += btnMoiSanPham_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.BackColor = SystemColors.Window;
            btnXoaSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaSanPham.Location = new Point(200, 657);
            btnXoaSanPham.Margin = new Padding(3, 4, 3, 4);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(91, 55);
            btnXoaSanPham.TabIndex = 3;
            btnXoaSanPham.Text = "Xóa";
            btnXoaSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaSanPham.UseVisualStyleBackColor = false;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // btnSuaSanPham
            // 
            btnSuaSanPham.BackColor = SystemColors.Window;
            btnSuaSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaSanPham.Location = new Point(107, 657);
            btnSuaSanPham.Margin = new Padding(3, 4, 3, 4);
            btnSuaSanPham.Name = "btnSuaSanPham";
            btnSuaSanPham.Size = new Size(86, 55);
            btnSuaSanPham.TabIndex = 3;
            btnSuaSanPham.Text = "Sửa";
            btnSuaSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaSanPham.UseVisualStyleBackColor = false;
            btnSuaSanPham.Click += btnSuaSanPham_Click;
            // 
            // btnUploadSanPham
            // 
            btnUploadSanPham.BackColor = SystemColors.Window;
            btnUploadSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUploadSanPham.Location = new Point(142, 589);
            btnUploadSanPham.Margin = new Padding(3, 4, 3, 4);
            btnUploadSanPham.Name = "btnUploadSanPham";
            btnUploadSanPham.Size = new Size(93, 35);
            btnUploadSanPham.TabIndex = 3;
            btnUploadSanPham.Text = "Chọn ảnh";
            btnUploadSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUploadSanPham.UseVisualStyleBackColor = false;
            btnUploadSanPham.Click += btnUploadSanPham_Click;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.BackColor = SystemColors.Window;
            btnThemSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemSanPham.Location = new Point(8, 657);
            btnThemSanPham.Margin = new Padding(3, 4, 3, 4);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(93, 55);
            btnThemSanPham.TabIndex = 3;
            btnThemSanPham.Text = "Thêm";
            btnThemSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemSanPham.UseVisualStyleBackColor = false;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(8, 277);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 0;
            label5.Text = "Loại Sản Phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(7, 207);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 0;
            label4.Text = "Đơn Gía";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Segoe UI", 12F);
            txtTenSanPham.Location = new Point(142, 128);
            txtTenSanPham.Margin = new Padding(3, 4, 3, 4);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(241, 34);
            txtTenSanPham.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(7, 139);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên Sản Phẩm";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Segoe UI", 12F);
            txtMaSanPham.Location = new Point(142, 63);
            txtMaSanPham.Margin = new Padding(3, 4, 3, 4);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(241, 34);
            txtMaSanPham.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(7, 67);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Sản Phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(btnTimKiemSP);
            groupBox2.Controls.Add(txtTimKiemSP);
            groupBox2.Controls.Add(dgrDanhSachSP);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(422, 96);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(906, 723);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 49);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 12;
            label6.Text = "Tìm sản phẩm theo mã SP";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.Window;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(649, 28);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(96, 55);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnTimKiemSP
            // 
            btnTimKiemSP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemSP.FlatStyle = FlatStyle.Flat;
            btnTimKiemSP.Location = new Point(1501, 28);
            btnTimKiemSP.Margin = new Padding(3, 4, 3, 4);
            btnTimKiemSP.Name = "btnTimKiemSP";
            btnTimKiemSP.Size = new Size(42, 32);
            btnTimKiemSP.TabIndex = 7;
            btnTimKiemSP.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiemSP.Location = new Point(403, 42);
            txtTimKiemSP.Margin = new Padding(3, 4, 3, 4);
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.Size = new Size(217, 27);
            txtTimKiemSP.TabIndex = 6;
            // 
            // dgrDanhSachSP
            // 
            dgrDanhSachSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachSP.Location = new Point(7, 100);
            dgrDanhSachSP.Margin = new Padding(3, 4, 3, 4);
            dgrDanhSachSP.Name = "dgrDanhSachSP";
            dgrDanhSachSP.ReadOnly = true;
            dgrDanhSachSP.RowHeadersWidth = 51;
            dgrDanhSachSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachSP.Size = new Size(893, 612);
            dgrDanhSachSP.TabIndex = 0;
            dgrDanhSachSP.CellClick += dgrDanhSachSP_CellClick;
            dgrDanhSachSP.CellDoubleClick += dgrDanhSachSP_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(591, 7);
            label1.Name = "label1";
            label1.Size = new Size(203, 46);
            label1.TabIndex = 6;
            label1.Text = "SẢN PHẨM";
            // 
            // FrmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 853);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmSanPham";
            Text = "FrmSanPham";
            Load += FrmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox txtDonGia;
        private PictureBox pbHinhAnh;
        private ComboBox cboLoaiSanPham;
        private RadioButton rdbDeActive;
        private RadioButton rdbActive;
        private Label label8;
        private Button btnMoiSanPham;
        private Button btnXoaSanPham;
        private Button btnSuaSanPham;
        private Button btnUploadSanPham;
        private Button btnThemSanPham;
        private Label label5;
        private Label label4;
        private TextBox txtTenSanPham;
        private Label label3;
        private TextBox txtMaSanPham;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private Button btnTimKiemSP;
        private TextBox txtTimKiemSP;
        private DataGridView dgrDanhSachSP;
        private Label label1;
        private Label label6;
    }
}