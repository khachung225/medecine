using System;
using medecine.Common;

namespace medecine.winForm
{
    public partial class frmAddUnits : BaseForm
    {
        public frmAddUnits()
        {
            InitializeComponent();
        }
        

        //lưu.
        private void button3_Click(object sender, System.EventArgs e)
        {
            var units = new DatabaseDAL.Entities.Unit
                {
                    ActorChanged = 0,
                    TimeChanged = DateTime.Now,
                    UnitName = textBox1.Text.Trim(),
                    UnitShortName = textBox2.Text.Trim()
                };

            new DatabaseDAL.DAO.UnitDao().Insert(units);
        }
    }
}
