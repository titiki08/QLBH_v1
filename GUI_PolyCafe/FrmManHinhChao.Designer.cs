namespace GUI_PolyCafe
{
    partial class FrmManHinhChao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 473);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(887, 105);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click_1;
            // 
            // FrmManHinhChao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(914, 600);
            Controls.Add(progressBar1);
            DoubleBuffered = true;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "FrmManHinhChao";
            Text = "FrmManHinhChao";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
    }
}
