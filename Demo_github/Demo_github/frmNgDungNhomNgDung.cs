using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Demo_github
{
    public partial class frmNgDungNhomNgDung : Form
    {
        public frmNgDungNhomNgDung()
        {
            InitializeComponent();
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmNgDungNhomNgDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.QL_NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSet1.QL_NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSet1.QL_NhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.Fill(this.dataSet1.QL_NguoiDung);

        }

        private void fillDKToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void qL_NguoiDungNhomNguoiDungDKDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDT()
        {
            try
            {
                this.qL_NguoiDungNhomNguoiDungDKTableAdapter.FillDK(this.dataSet1.QL_NguoiDungNhomNguoiDungDK, qL_NhomNguoiDungComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void qL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TenDN = qL_NguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            string MaNhomNgDung = qL_NhomNguoiDungComboBox.SelectedValue.ToString();

            int? kq = qL_NguoiDungNhomNguoiDungTableAdapter.KTKC(TenDN,MaNhomNgDung);
            if (kq.Value == 0)
            {
                qL_NguoiDungNhomNguoiDungTableAdapter.Insert(TenDN, MaNhomNgDung, "");
                LoadDT();
                MessageBox.Show("them thanh cong");
            }
            else
            {
                MessageBox.Show("trung khoa chinh");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           int kq = qL_NguoiDungNhomNguoiDungTableAdapter.Delete2(qL_NguoiDungNhomNguoiDungDKDataGridView.CurrentRow.Cells[0].Value.ToString(),qL_NguoiDungNhomNguoiDungDKDataGridView.CurrentRow.Cells[1].Value.ToString());
           if (kq == 1)
           {
               LoadDT();
               MessageBox.Show("xoa thanh cong");
           }
           else
           {
               MessageBox.Show("xoa khong thanh cong");
           }
        }
    }
}
