using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cau2
{
    public partial class Form1 : Form
    {
      
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private object Email;

        public Form1()
        {

            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
          
            }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            String s = txbHoTen.Text;
            if (txbHoTen.Text == "")
            {
                MessageBox.Show("Hay nhap ho ten ", "Thong bao");
                txbHoTen.Focus();
                return;
            }


            if (txbSDT.Text == "")
            {
                MessageBox.Show("Hay nhap So Dien Thoai ", "Thong bao");
                txbSDT.Focus();
                return;
            }

            if (txbTrieuChung.Text == "")
            {
                MessageBox.Show("Hay nhap Trieu chung ", "Thong bao");
                txbTrieuChung.Focus();
                return;
            }

            if (txbEmail.Text == "")
            {
                MessageBox.Show("Hay nhap Email ", "Thong bao");
                txbEmail.Focus();
                return;
            }
        }
        
      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
    }

}
