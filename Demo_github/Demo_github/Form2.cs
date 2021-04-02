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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formdang.Close();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNgDung frm = new frmNgDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhomNgDung frm = new frmNhomNgDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSManHinh frm = new frmDSManHinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNgDungNhomNgDung frm = new frmNgDungNhomNgDung();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
