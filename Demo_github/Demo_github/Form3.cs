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
    public partial class Form3 : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cbosever.Text, txttk.Text, txtmk.Text,cbodatabase.Text);
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void cbosever_DropDown(object sender, EventArgs e)
        {
            cbosever.DataSource = CauHinh.GetServerName();
            cbosever.DisplayMember = "ServerName";
        }

        private void cbodatabase_DropDown_1(object sender, EventArgs e)
        {
            cbodatabase.DataSource = CauHinh.GetDBName(cbosever.Text, txttk.Text, txtmk.Text);
            cbodatabase.DisplayMember = "name";
        }

        
    }
}
