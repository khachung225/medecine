using System;
using System.Windows.Forms;
using medecine.winForm;


namespace medecine
{
    public partial class FrmMain : System.Windows.Forms.Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatusTime.Text = DateTime.Now.ToShortDateString() + @" " + DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var units = new frmListUnits();
            units.Show();
        }
    }
}
