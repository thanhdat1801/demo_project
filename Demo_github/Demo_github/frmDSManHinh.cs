using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_github
{
    public partial class frmDSManHinh : Form
    {
        public frmDSManHinh()
        {
            InitializeComponent();
        }

        private void dM_ManHinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dM_ManHinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MessageBox.Show("Lưu Thành Công");

        }

        private void frmDSManHinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DM_ManHinh' table. You can move, or remove it, as needed.
            this.dM_ManHinhTableAdapter.Fill(this.dataSet1.DM_ManHinh);

        }
    }
}
