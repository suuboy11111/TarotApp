using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarotApp
{
    public partial class ThongTinUser : Form
    {
        public Action OnUserInformationCompleted;  // Delegate để thông báo cho form chính

        private int inputCount = 0; // Biến đếm số lượng TextBox đã nhập
        private frmTarot frmTarot;
        private frmTinhYeu frmTinhYeu;
        private frmSucKhoe frmSucKhoe;
        private frmSuNghiep frmSuNghiep;
        private ThongTinUser frmThongTinUser;

        public ThongTinUser()
        {
            InitializeComponent();
        }

        private void txtHoTen_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputCount++; // Tăng biến đếm sau mỗi lần nhập
                if (inputCount == 3)
                {
                    this.Close(); // Đóng form khi đã nhập đủ 3 dòng
                    OnUserInformationCompleted?.Invoke(); // Gọi hàm thông báo cho form chính
                }
                else
                {
                    // Chuyển focus tới txtNamSinh
                    txtNamSinh.Focus();
                }
            }
        }

        private void txtHoTen_Leave_1(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Text = "Họ và tên";
            }
        }

        private void txtHoTen_Enter_1(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Họ và tên")
            {
                txtHoTen.Text = "";
            }
        }

        private void txtNamSinh_Enter_1(object sender, EventArgs e)
        {
            if (txtNamSinh.Text == "Năm sinh")
            {
                txtNamSinh.Text = "";
            }
        }

        private void txtNamSinh_Leave_1(object sender, EventArgs e)
        {
            if (txtNamSinh.Text == "")
            {
                txtNamSinh.Text = "Năm sinh";
            }
        }

        private void txtCungHoangDao_Enter_1(object sender, EventArgs e)
        {
            if (txtCungHoangDao.Text == "Cung hoàng đạo")
            {
                txtCungHoangDao.Text = "";
            }
        }

        private void txtCungHoangDao_Leave_1(object sender, EventArgs e)
        {
            if (txtCungHoangDao.Text == "")
            {
                txtCungHoangDao.Text = "Cung hoàng đạo";
            }
        }

        private void ThongTinUser_Load(object sender, EventArgs e)
        {
            // Khởi tạo frmTarot nếu nó chưa được khởi tạo
            if (frmTarot == null)
            {
                frmTarot = new frmTarot(); // Tạo đối tượng frmTarot mới
            }

            // Đặt giá trị mặc định cho các ô TextBox
            txtHoTen.Text = "Họ và tên";
     
            txtNamSinh.Text = "Năm sinh";

            txtCungHoangDao.Text = "Cung hoàng đạo";

            // Không cho ô nào được chọn khi form load
            this.ActiveControl = guna2HtmlLabel1;  // Đảm bảo không có ô nào được chọn khi form load
        }


        private void txtNamSinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputCount++; // Tăng biến đếm sau mỗi lần nhập
                if (inputCount == 3)
                {
                    this.Close(); // Đóng form khi đã nhập đủ 3 dòng
                    OnUserInformationCompleted?.Invoke(); // Gọi hàm thông báo cho form chính
                }
                else
                {
                    // Chuyển focus tới txtCungHoangDao
                    txtCungHoangDao.Focus();
                }
            }
        }

        private void txtCungHoangDao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputCount++; // Tăng biến đếm sau mỗi lần nhập
                if (inputCount == 3)
                {
                    this.Close(); // Đóng form khi đã nhập đủ 3 dòng
                    OnUserInformationCompleted?.Invoke(); // Gọi hàm thông báo cho form chính
                }
                else
                {
                    // Đã nhập đủ rồi, không cần chuyển focus nữa
                    // Chỉ cần đóng form nếu nhập đủ ba trường
                }
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCungHoangDao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ThongTinUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        
    }
}
