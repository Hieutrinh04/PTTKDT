using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace câu3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        
        }

        private void RegisterPatient()
        {
            if (IsValidPatientInfo())
            {
                // Thực hiện lưu thông tin bệnh nhân vào cơ sở dữ liệu hoặc xử lý khác
                MessageBox.Show("Đã đăng ký thông tin bệnh nhân thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin bệnh nhân!", "Thông báo");
            }
        }

        private void SearchPatient()
        {
            // Thực hiện tìm kiếm thông tin bệnh nhân từ cơ sở dữ liệu và hiển thị kết quả
        }

        private void EditPatient()
        {
            // Cho phép người dùng chỉnh sửa thông tin bệnh nhân và cập nhật vào cơ sở dữ liệu
        }

        private void DeletePatient()
        {
            // Cho phép người dùng xóa thông tin bệnh nhân khỏi cơ sở dữ liệu
        }

        private void GeneratePatientReport()
        {
            // Tạo các báo cáo hoặc biểu đồ dựa trên dữ liệu bệnh nhân từ cơ sở dữ liệu
        }

        private bool IsValidPatientInfo()
        {
           
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPatient();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchPatient();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditPatient();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GeneratePatientReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
