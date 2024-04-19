using System;
using System.Windows.Forms;

namespace câu4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi người dùng nhấn nút "Xác nhận"
      

        private void buttonXacnhan_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra từng textbox có dữ liệu không
            if (string.IsNullOrEmpty(txtTenbn.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân!", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(txtTenbs.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bác sĩ!", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(txtSotienthu.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền thu!", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(txtGhichu.Text))
            {
                MessageBox.Show("Vui lòng nhập ghi chú!", "Thông báo");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
