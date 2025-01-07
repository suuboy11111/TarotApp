using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TarotApp
{
    public partial class frmBoBai : Form
    {
        private Model1 dbContext;

        // Constructor
        public frmBoBai()
        {
            InitializeComponent();
            dbContext = new Model1();
            LoadData();
        }

        // Tải dữ liệu từ database
        private void LoadData()
        {
            try
            {
                var data = dbContext.Cards.ToList();
                if (data.Any())
                {
                    dgvBoBai.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý tìm kiếm
        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchText = txtTim.Text.Trim().ToLower();

            try
            {
                if (!string.IsNullOrEmpty(searchText))
                {
                    var filteredData = dbContext.Cards
                        .Where(c => c.CardName.ToLower().Contains(searchText) || // Đổi tên cột đúng với DB
                                    c.UprightMeaning.ToLower().Contains(searchText) ||
                                    c.ReversedMeaning.ToLower().Contains(searchText))
                        .ToList();

                    dgvBoBai.DataSource = filteredData;

                    if (!filteredData.Any())
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    LoadData(); // Hiển thị tất cả dữ liệu nếu ô tìm kiếm rỗng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện không sử dụng - nên xóa hoặc bổ sung code
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void picBackground_Click(object sender, EventArgs e) { }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
