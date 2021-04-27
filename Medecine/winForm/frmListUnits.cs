using System.Data;
using medecine.Common;

namespace medecine.winForm
{
    public partial class frmListUnits : BaseForm
    {
        private DatabaseDAL.DAO.UnitDao unitdao = new DatabaseDAL.DAO.UnitDao();
        public frmListUnits()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, System.EventArgs e)
        {
            var addunit = new frmAddUnits();
            addunit.ShowDialog();
        }

        #region load
        private void LoadData()
        {
           var listData = unitdao.GetAll();
            
            if (listData.Count > 0)
            {
                bindingSource1.DataSource = listData;
            }
        }
        #endregion

        private void frmListUnits_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }
    }
}
