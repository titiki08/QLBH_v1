namespace GUI_PolyCafe
{
    partial class FrmPhieuBanHang
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
            dtpNgayTao = new DateTimePicker();
            cboNhanVienBH = new ComboBox();
            cboMaTheLuuDong = new ComboBox();
            rdbPaid = new RadioButton();
            rdbConfirmation = new RadioButton();
            label8 = new Label();
            btnMoiPhieu = new Button();
            btnXoaPhieu = new Button();
            btnSuaPhieu = new Button();
            btnThemPhieu = new Button();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtMaPhieu = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnTimKiemPhieu = new Button();
            dgrDanhSachPhieu = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachPhieu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(cboNhanVienBH);
            groupBox1.Controls.Add(cboMaTheLuuDong);
            groupBox1.Controls.Add(rdbPaid);
            groupBox1.Controls.Add(rdbConfirmation);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnMoiPhieu);
            groupBox1.Controls.Add(btnXoaPhieu);
            groupBox1.Controls.Add(btnSuaPhieu);
            groupBox1.Controls.Add(btnThemPhieu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 110);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(401, 711);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "x`";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CustomFormat = "dd/MM/yyyy";
            dtpNgayTao.Font = new Font("Segoe UI", 10F);
            dtpNgayTao.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.Location = new Point(107, 263);
            dtpNgayTao.Margin = new Padding(3, 4, 3, 4);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(271, 30);
            dtpNgayTao.TabIndex = 4;
            // 
            // cboNhanVienBH
            // 
            cboNhanVienBH.Font = new Font("Segoe UI", 11F);
            cboNhanVienBH.FormattingEnabled = true;
            cboNhanVienBH.Location = new Point(107, 193);
            cboNhanVienBH.Margin = new Padding(3, 4, 3, 4);
            cboNhanVienBH.Name = "cboNhanVienBH";
            cboNhanVienBH.Size = new Size(271, 33);
            cboNhanVienBH.TabIndex = 3;
            // 
            // cboMaTheLuuDong
            // 
            cboMaTheLuuDong.Font = new Font("Segoe UI", 11F);
            cboMaTheLuuDong.FormattingEnabled = true;
            cboMaTheLuuDong.Location = new Point(107, 47);
            cboMaTheLuuDong.Margin = new Padding(3, 4, 3, 4);
            cboMaTheLuuDong.Name = "cboMaTheLuuDong";
            cboMaTheLuuDong.Size = new Size(271, 33);
            cboMaTheLuuDong.TabIndex = 1;
            // 
            // rdbPaid
            // 
            rdbPaid.AutoSize = true;
            rdbPaid.Font = new Font("Segoe UI", 10F);
            rdbPaid.ForeColor = Color.Maroon;
            rdbPaid.Location = new Point(256, 327);
            rdbPaid.Margin = new Padding(3, 4, 3, 4);
            rdbPaid.Name = "rdbPaid";
            rdbPaid.Size = new Size(146, 27);
            rdbPaid.TabIndex = 6;
            rdbPaid.Text = "Đã Thanh Toán";
            rdbPaid.UseVisualStyleBackColor = true;
            // 
            // rdbConfirmation
            // 
            rdbConfirmation.AutoSize = true;
            rdbConfirmation.BackColor = Color.Transparent;
            rdbConfirmation.Checked = true;
            rdbConfirmation.Font = new Font("Segoe UI", 9F);
            rdbConfirmation.ForeColor = Color.Maroon;
            rdbConfirmation.Location = new Point(107, 331);
            rdbConfirmation.Margin = new Padding(3, 4, 3, 4);
            rdbConfirmation.Name = "rdbConfirmation";
            rdbConfirmation.Size = new Size(123, 24);
            rdbConfirmation.TabIndex = 5;
            rdbConfirmation.TabStop = true;
            rdbConfirmation.Text = "Chờ Xác Nhận";
            rdbConfirmation.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(5, 335);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 9;
            label8.Text = "Trạng Thái";
            // 
            // btnMoiPhieu
            // 
            btnMoiPhieu.BackColor = SystemColors.Window;
            btnMoiPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoiPhieu.Image = Properties.Resources.rotate;
            btnMoiPhieu.Location = new Point(298, 559);
            btnMoiPhieu.Margin = new Padding(3, 4, 3, 4);
            btnMoiPhieu.Name = "btnMoiPhieu";
            btnMoiPhieu.Size = new Size(96, 55);
            btnMoiPhieu.TabIndex = 10;
            btnMoiPhieu.Text = "Mới";
            btnMoiPhieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoiPhieu.UseVisualStyleBackColor = false;
            btnMoiPhieu.Click += btnMoiPhieu_Click;
            // 
            // btnXoaPhieu
            // 
            btnXoaPhieu.BackColor = SystemColors.Window;
            btnXoaPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaPhieu.Image = Properties.Resources.remove;
            btnXoaPhieu.Location = new Point(200, 559);
            btnXoaPhieu.Margin = new Padding(3, 4, 3, 4);
            btnXoaPhieu.Name = "btnXoaPhieu";
            btnXoaPhieu.Size = new Size(91, 55);
            btnXoaPhieu.TabIndex = 9;
            btnXoaPhieu.Text = "Xóa";
            btnXoaPhieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaPhieu.UseVisualStyleBackColor = false;
            btnXoaPhieu.Click += btnXoaPhieu_Click;
            // 
            // btnSuaPhieu
            // 
            btnSuaPhieu.BackColor = SystemColors.Window;
            btnSuaPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaPhieu.Image = Properties.Resources.edit;
            btnSuaPhieu.Location = new Point(107, 559);
            btnSuaPhieu.Margin = new Padding(3, 4, 3, 4);
            btnSuaPhieu.Name = "btnSuaPhieu";
            btnSuaPhieu.Size = new Size(86, 55);
            btnSuaPhieu.TabIndex = 8;
            btnSuaPhieu.Text = "Sửa";
            btnSuaPhieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaPhieu.UseVisualStyleBackColor = false;
            btnSuaPhieu.Click += btnSuaPhieu_Click;
            // 
            // btnThemPhieu
            // 
            btnThemPhieu.BackColor = SystemColors.Window;
            btnThemPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemPhieu.Image = Properties.Resources.plus;
            btnThemPhieu.Location = new Point(8, 559);
            btnThemPhieu.Margin = new Padding(3, 4, 3, 4);
            btnThemPhieu.Name = "btnThemPhieu";
            btnThemPhieu.Size = new Size(93, 55);
            btnThemPhieu.TabIndex = 7;
            btnThemPhieu.Text = "Thêm";
            btnThemPhieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemPhieu.UseVisualStyleBackColor = false;
            btnThemPhieu.Click += btnThemPhieu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(3, 271);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 0;
            label4.Text = "Ngày Tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(3, 203);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Nhân Viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(10, 54);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 0;
            label7.Text = "Mã Thẻ";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Font = new Font("Segoe UI", 12F);
            txtMaPhieu.Location = new Point(107, 127);
            txtMaPhieu.Margin = new Padding(3, 4, 3, 4);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(271, 34);
            txtMaPhieu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(10, 137);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Phiếu";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnTimKiemPhieu);
            groupBox2.Controls.Add(dgrDanhSachPhieu);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(422, 143);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(906, 697);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Phiếu";
            // 
            // btnTimKiemPhieu
            // 
            btnTimKiemPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemPhieu.FlatStyle = FlatStyle.Flat;
            btnTimKiemPhieu.Image = Properties.Resources.find;
            btnTimKiemPhieu.Location = new Point(1535, 21);
            btnTimKiemPhieu.Margin = new Padding(3, 4, 3, 4);
            btnTimKiemPhieu.Name = "btnTimKiemPhieu";
            btnTimKiemPhieu.Size = new Size(42, 31);
            btnTimKiemPhieu.TabIndex = 12;
            btnTimKiemPhieu.UseVisualStyleBackColor = true;
            // 
            // dgrDanhSachPhieu
            // 
            dgrDanhSachPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachPhieu.Location = new Point(7, 21);
            dgrDanhSachPhieu.Margin = new Padding(3, 4, 3, 4);
            dgrDanhSachPhieu.Name = "dgrDanhSachPhieu";
            dgrDanhSachPhieu.ReadOnly = true;
            dgrDanhSachPhieu.RowHeadersWidth = 51;
            dgrDanhSachPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachPhieu.Size = new Size(893, 668);
            dgrDanhSachPhieu.TabIndex = 0;
            dgrDanhSachPhieu.CellClick += dgrDanhSachPhieu_CellClick;
            dgrDanhSachPhieu.CellDoubleClick += dgrDanhSachPhieu_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(462, 44);
            label1.Name = "label1";
            label1.Size = new Size(313, 46);
            label1.TabIndex = 21;
            label1.Text = "PHIẾU BÁN HÀNG";
            label1.Click += label1_Click;
            // 
            // FrmPhieuBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 856);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPhieuBanHang";
            Text = "FrmPhieuBanHang";
            Load += FrmPhieuBanHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachPhieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpNgayTao;
        private ComboBox cboNhanVienBH;
        private ComboBox cboMaTheLuuDong;
        private RadioButton rdbPaid;
        private RadioButton rdbConfirmation;
        private Label label8;
        private Button btnMoiPhieu;
        private Button btnXoaPhieu;
        private Button btnSuaPhieu;
        private Button btnThemPhieu;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox txtMaPhieu;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnTimKiemPhieu;
        private DataGridView dgrDanhSachPhieu;
        private Label label1;
    }
}