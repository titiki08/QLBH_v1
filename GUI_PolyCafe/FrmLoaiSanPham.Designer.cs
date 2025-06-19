namespace GUI_PolyCafe
{
    partial class FrmLoaiSanPham
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnTimKiemLoaiSP = new Button();
            btnTimKiemThe = new Button();
            txtTimKiemLoaiSP = new TextBox();
            dgrDanhSachLoaiSP = new DataGridView();
            groupBox1 = new GroupBox();
            btnMoiLoaiSP = new Button();
            btnXoaLoaiSP = new Button();
            btnSuaLoaiSP = new Button();
            btnThemLoaiSP = new Button();
            txtGhiChuSP = new TextBox();
            label4 = new Label();
            txtTenLoaiSP = new TextBox();
            label3 = new Label();
            txtMaLoaiSP = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachLoaiSP).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(591, 7);
            label1.Name = "label1";
            label1.Size = new Size(289, 46);
            label1.TabIndex = 9;
            label1.Text = "LOẠI SẢN PHẨM";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(btnTimKiemLoaiSP);
            groupBox2.Controls.Add(btnTimKiemThe);
            groupBox2.Controls.Add(txtTimKiemLoaiSP);
            groupBox2.Controls.Add(dgrDanhSachLoaiSP);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(422, 96);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(906, 711);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 31);
            label5.Name = "label5";
            label5.Size = new Size(203, 20);
            label5.TabIndex = 13;
            label5.Text = "Tìm sản phẩm theo Mã Loại";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.Window;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(702, 21);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 41);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTimKiem.Location = new Point(444, 28);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(243, 27);
            txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiemLoaiSP
            // 
            btnTimKiemLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemLoaiSP.FlatStyle = FlatStyle.Flat;
            btnTimKiemLoaiSP.Image = Properties.Resources.find;
            btnTimKiemLoaiSP.Location = new Point(1509, 28);
            btnTimKiemLoaiSP.Margin = new Padding(3, 4, 3, 4);
            btnTimKiemLoaiSP.Name = "btnTimKiemLoaiSP";
            btnTimKiemLoaiSP.Size = new Size(42, 31);
            btnTimKiemLoaiSP.TabIndex = 5;
            btnTimKiemLoaiSP.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemThe
            // 
            btnTimKiemThe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemThe.FlatStyle = FlatStyle.Flat;
            btnTimKiemThe.Image = Properties.Resources.find;
            btnTimKiemThe.Location = new Point(2186, 28);
            btnTimKiemThe.Margin = new Padding(3, 4, 3, 4);
            btnTimKiemThe.Name = "btnTimKiemThe";
            btnTimKiemThe.Size = new Size(42, 32);
            btnTimKiemThe.TabIndex = 4;
            btnTimKiemThe.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemLoaiSP
            // 
            txtTimKiemLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTimKiemLoaiSP.Location = new Point(1264, 28);
            txtTimKiemLoaiSP.Margin = new Padding(3, 4, 3, 4);
            txtTimKiemLoaiSP.Name = "txtTimKiemLoaiSP";
            txtTimKiemLoaiSP.Size = new Size(243, 27);
            txtTimKiemLoaiSP.TabIndex = 3;
            // 
            // dgrDanhSachLoaiSP
            // 
            dgrDanhSachLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachLoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachLoaiSP.Location = new Point(7, 67);
            dgrDanhSachLoaiSP.Margin = new Padding(3, 4, 3, 4);
            dgrDanhSachLoaiSP.Name = "dgrDanhSachLoaiSP";
            dgrDanhSachLoaiSP.ReadOnly = true;
            dgrDanhSachLoaiSP.RowHeadersWidth = 51;
            dgrDanhSachLoaiSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachLoaiSP.Size = new Size(893, 636);
            dgrDanhSachLoaiSP.TabIndex = 0;
            dgrDanhSachLoaiSP.CellDoubleClick += dgrDanhSachLoaiSP_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnMoiLoaiSP);
            groupBox1.Controls.Add(btnXoaLoaiSP);
            groupBox1.Controls.Add(btnSuaLoaiSP);
            groupBox1.Controls.Add(btnThemLoaiSP);
            groupBox1.Controls.Add(txtGhiChuSP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenLoaiSP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaLoaiSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(14, 96);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(401, 645);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Loại ";
            // 
            // btnMoiLoaiSP
            // 
            btnMoiLoaiSP.BackColor = SystemColors.Window;
            btnMoiLoaiSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoiLoaiSP.Image = Properties.Resources.rotate;
            btnMoiLoaiSP.Location = new Point(296, 501);
            btnMoiLoaiSP.Margin = new Padding(3, 4, 3, 4);
            btnMoiLoaiSP.Name = "btnMoiLoaiSP";
            btnMoiLoaiSP.Size = new Size(96, 55);
            btnMoiLoaiSP.TabIndex = 7;
            btnMoiLoaiSP.Text = "Mới";
            btnMoiLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoiLoaiSP.UseVisualStyleBackColor = false;
            btnMoiLoaiSP.Click += btnMoiLoaiSP_Click;
            // 
            // btnXoaLoaiSP
            // 
            btnXoaLoaiSP.BackColor = SystemColors.Window;
            btnXoaLoaiSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLoaiSP.Image = Properties.Resources.remove;
            btnXoaLoaiSP.Location = new Point(198, 501);
            btnXoaLoaiSP.Margin = new Padding(3, 4, 3, 4);
            btnXoaLoaiSP.Name = "btnXoaLoaiSP";
            btnXoaLoaiSP.Size = new Size(91, 55);
            btnXoaLoaiSP.TabIndex = 6;
            btnXoaLoaiSP.Text = "Xóa";
            btnXoaLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaLoaiSP.UseVisualStyleBackColor = false;
            btnXoaLoaiSP.Click += btnXoaLoaiSP_Click;
            // 
            // btnSuaLoaiSP
            // 
            btnSuaLoaiSP.BackColor = SystemColors.Window;
            btnSuaLoaiSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaLoaiSP.Image = Properties.Resources.edit;
            btnSuaLoaiSP.Location = new Point(105, 501);
            btnSuaLoaiSP.Margin = new Padding(3, 4, 3, 4);
            btnSuaLoaiSP.Name = "btnSuaLoaiSP";
            btnSuaLoaiSP.Size = new Size(86, 55);
            btnSuaLoaiSP.TabIndex = 5;
            btnSuaLoaiSP.Text = "Sửa";
            btnSuaLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaLoaiSP.UseVisualStyleBackColor = false;
            btnSuaLoaiSP.Click += btnSuaLoaiSP_Click;
            // 
            // btnThemLoaiSP
            // 
            btnThemLoaiSP.BackColor = SystemColors.Window;
            btnThemLoaiSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemLoaiSP.Image = Properties.Resources.plus;
            btnThemLoaiSP.Location = new Point(6, 501);
            btnThemLoaiSP.Margin = new Padding(3, 4, 3, 4);
            btnThemLoaiSP.Name = "btnThemLoaiSP";
            btnThemLoaiSP.Size = new Size(93, 55);
            btnThemLoaiSP.TabIndex = 4;
            btnThemLoaiSP.Text = "Thêm";
            btnThemLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemLoaiSP.UseVisualStyleBackColor = false;
            btnThemLoaiSP.Click += btnThemLoaiSP_Click;
            // 
            // txtGhiChuSP
            // 
            txtGhiChuSP.Font = new Font("Segoe UI", 12F);
            txtGhiChuSP.Location = new Point(142, 239);
            txtGhiChuSP.Margin = new Padding(3, 4, 3, 4);
            txtGhiChuSP.Multiline = true;
            txtGhiChuSP.Name = "txtGhiChuSP";
            txtGhiChuSP.Size = new Size(241, 185);
            txtGhiChuSP.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(7, 249);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 0;
            label4.Text = "Ghi Chú";
            // 
            // txtTenLoaiSP
            // 
            txtTenLoaiSP.Font = new Font("Segoe UI", 12F);
            txtTenLoaiSP.Location = new Point(142, 168);
            txtTenLoaiSP.Margin = new Padding(3, 4, 3, 4);
            txtTenLoaiSP.Name = "txtTenLoaiSP";
            txtTenLoaiSP.Size = new Size(241, 34);
            txtTenLoaiSP.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(7, 179);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên Loại";
            // 
            // txtMaLoaiSP
            // 
            txtMaLoaiSP.Font = new Font("Segoe UI", 12F);
            txtMaLoaiSP.Location = new Point(142, 103);
            txtMaLoaiSP.Margin = new Padding(3, 4, 3, 4);
            txtMaLoaiSP.Name = "txtMaLoaiSP";
            txtMaLoaiSP.ReadOnly = true;
            txtMaLoaiSP.Size = new Size(241, 34);
            txtMaLoaiSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(7, 107);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Loại";
            // 
            // FrmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 856);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLoaiSanPham";
            Text = "FrmLoaiSanPham";
            Load += FrmLoaiSanPham_Load;
            Resize += FrmLoaiSanPham_Resize;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachLoaiSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Button btnTimKiemLoaiSP;
        private Button btnTimKiemThe;
        private TextBox txtTimKiemLoaiSP;
        private DataGridView dgrDanhSachLoaiSP;
        private GroupBox groupBox1;
        private Button btnMoiLoaiSP;
        private Button btnXoaLoaiSP;
        private Button btnSuaLoaiSP;
        private Button btnThemLoaiSP;
        private TextBox txtGhiChuSP;
        private Label label4;
        private TextBox txtTenLoaiSP;
        private Label label3;
        private TextBox txtMaLoaiSP;
        private Label label2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label5;
    }
}