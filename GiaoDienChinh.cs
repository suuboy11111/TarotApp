using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace TarotApp
{
    public partial class frmTarot : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private Model1 dbContext;
        
        public frmTarot()
        {
            InitializeComponent();
            dbContext = new Model1(); // Khởi tạo DbContext
            // Đường dẫn tới file nhạc
            string musicPath = @"D:\Study\Lap Trinh Windows\DOANCUOIKY\Adventure ｜ Royalty Free Medieval Fantasy Music.mp3";

            try
            {
                audioFile = new AudioFileReader(musicPath);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);

                // Đăng ký sự kiện PlaybackStopped ngay trong hàm khởi tạo
                outputDevice.PlaybackStopped += (sender, e) =>
                {
                    try
                    {
                        // Khi nhạc kết thúc, khởi động lại nhạc từ đầu
                        audioFile.Position = 0;  // Đưa lại vị trí về đầu
                        outputDevice.Play();     // Phát lại nhạc
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi phát lại nhạc: {ex.Message}");
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo âm thanh: {ex.Message}");
            }
        }


        private void btnChucNang_Click(object sender, EventArgs e)
        {
            // Hiển thị menu ngay tại vị trí của nút
            cmsMenu.Show(btnChucNang, new Point(0, btnChucNang.Height));
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Bạn có chắc chắn muốn thoát ứng dụng không?",
             "Xác nhận thoát",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng ứng dụng
            }
            // Nếu chọn No thì không làm gì
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichSu frmLichSu = new frmLichSu();
            frmLichSu.ShowDialog();
        }

        private void cmsMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BoBaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoBai boBaiForm = new frmBoBai();
            boBaiForm.ShowDialog(); // Hiển thị form dưới dạng hộp thoại
        }

        private void frmTarot_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            // Lấy danh sách các chủ đề từ cơ sở dữ liệu
            var themes = dbContext.Themes.ToList();

            // Đặt ComboBox với các chủ đề
            cmbTheme.DisplayMember = "ThemeName";  // Hiển thị tên chủ đề
            cmbTheme.ValueMember = "ThemeID";     // Gán giá trị là ThemeID
            cmbTheme.DataSource = themes;         // Gán dữ liệu vào ComboBox

            // Chọn mặc định là "Tình yêu"
            var loveTheme = themes.FirstOrDefault(t => t.ThemeName == "Tình yêu");
            if (loveTheme != null)
            {
                cmbTheme.SelectedItem = loveTheme; // Chọn "Tình yêu" nếu tìm thấy
            }
            // Phát nhạc khi form mở
            try
            {
                outputDevice?.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi phát nhạc: {ex.Message}");
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (cmbTheme.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một chủ đề.");
                return;
            }

            // Hiển thị form ThongTinUser để nhập thông tin người dùng
            ThongTinUser thongTinUserForm = new ThongTinUser();
            thongTinUserForm.OnUserInformationCompleted = () =>
            {
                // Khi người dùng đã nhập đủ 3 dòng và form đã đóng, mở form theo chủ đề
                Theme selectedTheme = cmbTheme.SelectedItem as Theme;
                if (selectedTheme == null)
                {
                    MessageBox.Show("Chủ đề không hợp lệ.");
                    return;
                }

                string themeName = selectedTheme.ThemeName;  // Lấy tên chủ đề

                if (themeName == "Tình yêu")
                {
                    frmTinhYeu tinhYeuForm = new frmTinhYeu();
                    tinhYeuForm.Show();
                }
                else if (themeName == "Sức khỏe")
                {
                    frmSucKhoe sucKhoeForm = new frmSucKhoe();
                    sucKhoeForm.Show();
                }
                else if (themeName == "Sự nghiệp")
                {
                    frmSuNghiep suNghiepForm = new frmSuNghiep();
                    suNghiepForm.Show();
                }
                else
                {
                    MessageBox.Show("Chủ đề không hợp lệ.");
                }
            };
            thongTinUserForm.ShowDialog(); // Hiển thị form nhập thông tin người dùng
            this.SendToBack();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmTarot_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dừng nhạc khi form đóng
            try
            {
                outputDevice?.Stop();
                audioFile?.Dispose();
                outputDevice?.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi dừng nhạc: {ex.Message}");
            }
        }
    }
}
