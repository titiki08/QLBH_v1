namespace GUI_PolyCafe
{
    public partial class FrmManHinhChao : Form
    {
        public FrmManHinhChao()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            Task.Delay(3000).ContinueWith(t =>
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Dispose();
                    }));
                }
            });
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void FrmManHinhChao_Load(object sender, EventArgs e)
        {

        }

        private void FrmManHinhChao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
