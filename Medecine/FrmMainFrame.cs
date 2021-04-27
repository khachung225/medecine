using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medecine
{
    public partial class FrmMainFrame : Telerik.WinControls.UI.RadRibbonForm
    {
        private static Size ChildSize = new Size(580, 200); 
        public FrmMainFrame()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.AllowAero = false; 
            this.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = this.radRibbonBar1.RibbonBarElement.TabStripElement.Items[0];
            //this.radRibbonBar1.StartButtonImage = ResFinder.MenuIcon; 
            this.radRibbonBar1.QuickAccessToolBar.InnerItem.ContentLayout.Margin = new Padding(2, 0, 2, 0); 
            this.IsMdiContainer = true; 
            this.MinimumSize = new Size(210, 140);

            this.radRibbonBar1.RibbonBarElement.MDIbutton.MaximizeButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radRibbonBar1.RibbonBarElement.MDIbutton.MinimizeButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radRibbonBar1.RibbonBarElement.MDIbutton.CloseButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            var dsthuoc = new DanhSachThuoc();
            //dsthuoc.MdiParent = this;
           // dsthuoc.Size = ChildSize; 


            dsthuoc.RibbonBar.Visible = false;
            dsthuoc.MdiParent = this;
            //dsthuoc.Dock = DockStyle.Fill;
            //dsthuoc.WindowState = FormWindowState.Normal;
            dsthuoc.Show();
            
        }
    }
}
