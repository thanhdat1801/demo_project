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
    public partial class Form1 : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public Form1()
        {
           
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txtdn.Text.Trim(), txtmk.Text.Trim());
            if (result == 10)
        {
            MessageBox.Show("Sai " + label1.Text + " Hoặc " +
                label2.Text);
            return;
        }
        // Account had been disabled
            else if (result == 20)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            else
            {
                Form2 frm = new Form2();

                frm.Show();
                this.Hide();
            }
//            if (Program.mainForm == null || Program.mainForm.IsDisposed)
//                {
//Program.mainForm = new frmMain();
//}
//this.Visible = false;
//Program.mainForm.Show();
}
        
        public void ProcessConfig()
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdn.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + label1.Text.ToLower());
                this.txtdn.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtmk.Text))
            {
                MessageBox.Show("Không được bỏ trống" + label2.Text.ToLower());
                this.txtmk.Focus();
                return;
            }
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }
    }
}
