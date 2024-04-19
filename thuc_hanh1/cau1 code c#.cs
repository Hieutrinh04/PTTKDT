using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuc_hanh1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> employeePasswords = new Dictionary<string, string>()
        {
            {"luomvv1", "password1"},
            {"Lê Thị B", "password2"},
            {"Trần Minh C", "password3"},
            {"Đỗ Nhật M", "password4"}
            // Thêm các nhân viên khác vào đây với tên và mật khẩu tương ứng
        };
        private int loginAttempts = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (employeePasswords.ContainsKey(username) && employeePasswords[username] == password)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Tên hoặc mật khẩu không chính xác. Vui lòng thử lại.");
                loginAttempts++;

                if (loginAttempts >= 3)
                {
                    loginAttempts = 0;
                    MessageBox.Show("Bạn đã nhập sai quá 3 lần. Chương trình sẽ tự động thoát.");
                    this.Close();
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (employeePasswords.ContainsKey(username) && employeePasswords[username] == password)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Tên hoặc mật khẩu không chính xác. Vui lòng thử lại.");
                loginAttempts++;

                if (loginAttempts >= 3)
                {
                    loginAttempts = 0;
                    MessageBox.Show("Bạn đã nhập sai quá 3 lần. Chương trình sẽ tự động thoát.");
                    this.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
    }



