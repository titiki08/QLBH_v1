namespace GUI_PolyCafe
{
    partial class FrmDoanhThuLoaiSP
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
            dgrDanhSachThongKe = new DataGridView();
            panel1 = new Panel();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            label4 = new Label();
            dtpTuNgay = new DateTimePicker();
            label3 = new Label();
            cbxLoaiSanPham = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachThongKe).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgrDanhSachThongKe
            // 
            dgrDanhSachThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrDanhSachThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachThongKe.Location = new Point(8, 136);
            dgrDanhSachThongKe.Name = "dgrDanhSachThongKe";
            dgrDanhSachThongKe.ReadOnly = true;
            dgrDanhSachThongKe.RowHeadersWidth = 51;
            dgrDanhSachThongKe.Size = new Size(1155, 489);
            dgrDanhSachThongKe.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbxLoaiSanPham);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 61);
            panel1.TabIndex = 8;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.White;
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.Maroon;
            btnThongKe.Location = new Point(973, 11);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(119, 39);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 10F);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(739, 18);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(161, 25);
            dtpDenNgay.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(674, 22);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Đến Ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 10F);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(427, 18);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(171, 25);
            dtpTuNgay.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(370, 22);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Từ Ngày";
            // 
            // cbxLoaiSanPham
            // 
            cbxLoaiSanPham.Font = new Font("Segoe UI", 10F);
            cbxLoaiSanPham.FormattingEnabled = true;
            cbxLoaiSanPham.Location = new Point(104, 20);
            cbxLoaiSanPham.Name = "cbxLoaiSanPham";
            cbxLoaiSanPham.Size = new Size(212, 25);
            cbxLoaiSanPham.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(13, 24);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Loại Sản Phẩm";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(310, 4);
            label1.Name = "label1";
            label1.Size = new Size(623, 37);
            label1.TabIndex = 7;
            label1.Text = "THỐNG KÊ DOANH THU THEO LOẠI SẢN PHẨM";
            // 
            // FrmDoanhThuLoaiSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 645);
            Controls.Add(dgrDanhSachThongKe);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FrmDoanhThuLoaiSP";
            Text = "FrmDoanhThuLoaiSP";
            Load += FrmDoanhThuLoaiSP_Load;
            Resize += FrmDoanhThuLoaiSP_Resize;
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachThongKe).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgrDanhSachThongKe;
        private Panel panel1;
        private Button btnThongKe;
        private DateTimePicker dtpDenNgay;
        private Label label4;
        private DateTimePicker dtpTuNgay;
        private Label label3;
        private ComboBox cbxLoaiSanPham;
        private Label label2;
        private Label label1;
    }
}