using System.Drawing;
using System.Windows.Forms;
using medecine.Properties;

namespace medecine.Common
{
    public partial class BaseForm : Form
    {
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;

        public BaseForm()
        {
            InitializeComponent();
        }
        private void initBusyBox()
        {
            if (transparentPanel1 != null) return;

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transparentPanel1 = new medecine.Common.TransparentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = Resources.ajax_loader;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(182, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Location = new System.Drawing.Point(12, 337);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(373, 26);
            this.transparentPanel1.TabIndex = 4;
            this.transparentPanel1.Visible = false;

            
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.pictureBox1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Refresh();
        }
        public void ShowBusyBox(bool isshow = true)
        {
            if (isshow)
            {
            transparentPanel1.BringToFront();
            transparentPanel1.Dock = DockStyle.Fill;
                transparentPanel1.Visible = true;

           // pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.BringToFront();
            this.pictureBox1.Refresh();
            pictureBox1.Visible = true;

            }
            else
            {
                this.pictureBox1.SendToBack();
                transparentPanel1.SendToBack();
                pictureBox1.Visible = false;
                transparentPanel1.Visible = false;
            }
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {
            initBusyBox();
        }
    }
}
