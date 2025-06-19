namespace GUI_PolyCafe
{
    partial class FrmDoiMatKhau
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
            chkHienThi = new CheckBox();
            chkHienThi2 = new CheckBox();
            chkHienThi1 = new CheckBox();
            btnDoiMatKhau = new Button();
            txtXacNhanMatKhau = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtMatKhauCu = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            lblXacNhanMatKhau = new Label();
            lblMatKhauMoi = new Label();
            lblMatKhauCu = new Label();
            lblTenNV = new Label();
            lblMaNV = new Label();
            lblDoiMatKhau = new Label();
            SuspendLayout();
            // 
            // chkHienThi
            // 
            chkHienThi.AutoSize = true;
            chkHienThi.Location = new Point(695, 288);
            chkHienThi.Name = "chkHienThi";
            chkHienThi.Size = new Size(68, 19);
            chkHienThi.TabIndex = 29;
            chkHienThi.Text = "Hiển thị";
            chkHienThi.UseVisualStyleBackColor = true;
            chkHienThi.CheckedChanged += chkHienThi_CheckedChanged;
            // 
            // chkHienThi2
            // 
            chkHienThi2.AutoSize = true;
            chkHienThi2.Location = new Point(695, 237);
            chkHienThi2.Name = "chkHienThi2";
            chkHienThi2.Size = new Size(68, 19);
            chkHienThi2.TabIndex = 28;
            chkHienThi2.Text = "Hiển thị";
            chkHienThi2.UseVisualStyleBackColor = true;
            chkHienThi2.CheckedChanged += chkHienThi2_CheckedChanged;
            // 
            // chkHienThi1
            // 
            chkHienThi1.AutoSize = true;
            chkHienThi1.Location = new Point(695, 183);
            chkHienThi1.Name = "chkHienThi1";
            chkHienThi1.Size = new Size(68, 19);
            chkHienThi1.TabIndex = 27;
            chkHienThi1.Text = "Hiển thị";
            chkHienThi1.UseVisualStyleBackColor = true;
            chkHienThi1.CheckedChanged += chkHienThi1_CheckedChanged;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Font = new Font("Segoe UI", 13F);
            btnDoiMatKhau.Location = new Point(294, 339);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(148, 46);
            btnDoiMatKhau.TabIndex = 26;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F);
            txtXacNhanMatKhau.Location = new Point(294, 281);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(395, 29);
            txtXacNhanMatKhau.TabIndex = 25;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F);
            txtMatKhauMoi.Location = new Point(294, 230);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(395, 29);
            txtMatKhauMoi.TabIndex = 24;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Font = new Font("Segoe UI", 12F);
            txtMatKhauCu.Location = new Point(295, 176);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(394, 29);
            txtMatKhauCu.TabIndex = 23;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Segoe UI", 12F);
            txtTenNV.Location = new Point(295, 123);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(394, 29);
            txtTenNV.TabIndex = 22;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 12F);
            txtMaNV.Location = new Point(294, 72);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(395, 29);
            txtMaNV.TabIndex = 21;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 12F);
            lblXacNhanMatKhau.Location = new Point(135, 284);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(142, 21);
            lblXacNhanMatKhau.TabIndex = 20;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI", 12F);
            lblMatKhauMoi.Location = new Point(135, 233);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(107, 21);
            lblMatKhauMoi.TabIndex = 19;
            lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.AutoSize = true;
            lblMatKhauCu.Font = new Font("Segoe UI", 12F);
            lblMatKhauCu.Location = new Point(138, 179);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new Size(95, 21);
            lblMatKhauCu.TabIndex = 18;
            lblMatKhauCu.Text = "Mật khẩu cũ";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Font = new Font("Segoe UI", 12F);
            lblTenNV.Location = new Point(138, 126);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(105, 21);
            lblTenNV.TabIndex = 17;
            lblTenNV.Text = "Tên nhân viên";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 12F);
            lblMaNV.Location = new Point(138, 75);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(104, 21);
            lblMaNV.TabIndex = 16;
            lblMaNV.Text = "Mã nhân viên";
            // 
            // lblDoiMatKhau
            // 
            lblDoiMatKhau.AutoSize = true;
            lblDoiMatKhau.Font = new Font("Segoe UI", 20F);
            lblDoiMatKhau.ForeColor = Color.Navy;
            lblDoiMatKhau.Location = new Point(12, 9);
            lblDoiMatKhau.Name = "lblDoiMatKhau";
            lblDoiMatKhau.Size = new Size(176, 37);
            lblDoiMatKhau.TabIndex = 15;
            lblDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // FrmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 402);
            Controls.Add(chkHienThi);
            Controls.Add(chkHienThi2);
            Controls.Add(chkHienThi1);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(lblMatKhauCu);
            Controls.Add(lblTenNV);
            Controls.Add(lblMaNV);
            Controls.Add(lblDoiMatKhau);
            Name = "FrmDoiMatKhau";
            Text = "FrmDoiMatKhau";
            Load += FrmDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkHienThi;
        private CheckBox chkHienThi2;
        private CheckBox chkHienThi1;
        private Button btnDoiMatKhau;
        private TextBox txtXacNhanMatKhau;
        private TextBox txtMatKhauMoi;
        private TextBox txtMatKhauCu;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private Label lblXacNhanMatKhau;
        private Label lblMatKhauMoi;
        private Label lblMatKhauCu;
        private Label lblTenNV;
        private Label lblMaNV;
        private Label lblDoiMatKhau;
    }
}