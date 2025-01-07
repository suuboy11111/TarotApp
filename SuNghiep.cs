using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace TarotApp
{
    public partial class frmSuNghiep : Form
    {
        private Model1 db = new Model1();
        private List<Card> randomCards; // Biến toàn cục để lưu các lá bài ngẫu nhiên
        private frmTarot frmTarot;
        public frmSuNghiep()
        {
            InitializeComponent();
            RandomizeCards(); // Gọi hàm để random các thẻ bài khi form khởi tạo
        }
        private void RandomizeCards()
        {
            List<Card> cards = db.Cards.ToList();
            Random random = new Random();
            randomCards = cards.OrderBy(c => random.Next()).Take(3).ToList();

            foreach (var card in randomCards)
            {
                card.IsReversed = random.Next(0, 2) == 0;
            }
        }
        private void DisplayCard(Guna2Button btn, Card card)
        {
            var img = Image.FromFile(card.ImagePath);
            if (card.IsReversed)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            btn.BackgroundImage = img;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            this.Close();

            if (randomCards.Count > 0)
            {
                // Xác định chủ đề, ví dụ "Tình Yêu"
                string themeName = "Sự Nghiệp";

                frmResultLove resultForm = new frmResultLove(randomCards, themeName);
                resultForm.Show();
                SaveReadingHistory();
            }
        }
        private void SaveReadingHistory()
        {
            try
            {
                // Tìm chủ đề "Tình Yêu"
                var theme = db.Themes.FirstOrDefault(t => t.ThemeName == "Sự Nghiệp");

                // Kiểm tra nếu chủ đề không null và đã chọn đủ 3 lá bài
                if (theme != null && randomCards.Count == 3)
                {
                    // Tạo bản ghi trong bảng Reading
                    var reading = new Reading
                    {
                        ThemeID = theme.ThemeID,  // Lưu ThemeID từ chủ đề "Tình Yêu"
                        Card1ID = randomCards[0].CardID,  // Lưu ID của các lá bài
                        Card2ID = randomCards[1].CardID,
                        Card3ID = randomCards[2].CardID,
                        CreatedAt = DateTime.Now  // Lưu thời gian hiện tại
                    };

                    db.Readings.Add(reading);  // Thêm vào bảng Readings

                    // Tạo danh sách ReadingDetails
                    var readingDetails = new List<ReadingDetail>();
                    foreach (var card in randomCards)
                    {
                        var readingDetail = new ReadingDetail
                        {
                            ReadingID = reading.ReadingID,  // Lấy ReadingID đã lưu
                            CardID = card.CardID,  // Lưu ID của từng lá bài
                            IsReversed = card.IsReversed  // Lưu trạng thái ngược/xuôi của lá bài
                        };
                        readingDetails.Add(readingDetail);  // Thêm vào danh sách
                    }

                    db.ReadingDetails.AddRange(readingDetails);  // Thêm tất cả ReadingDetails vào DbContext

                    db.SaveChanges();  // Lưu vào cơ sở dữ liệu

                    MessageBox.Show("Lịch sử xem bài đã được lưu!");
                }
                else
                {
                    MessageBox.Show("Không thể lưu lịch sử. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu lịch sử: {ex.Message}");
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu lịch sử: {ex.Message}");
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}");
                    if (ex.InnerException.InnerException != null)
                    {
                        MessageBox.Show($"Inner Inner Exception: {ex.InnerException.InnerException.Message}");
                    }
                }
            }
        }

        private void btnCard1_Click(object sender, EventArgs e)
        {
            if (randomCards.Count > 0)
            {
                DisplayCard(btnCard1, randomCards[0]);
            }
        }

        private void frmSuNghiep_Load(object sender, EventArgs e)
        {
            // Thao tác khác khi form được load
            this.BringToFront();  // Đưa frmTinhYeu lên trên
        }

        private void frmSuNghiep_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Khi frmTinhYeu đóng, đưa frmTarot lên trên
            if (frmTarot != null)
            {
                frmTarot.BringToFront();
            }
        }

        private void btnCard2_Click(object sender, EventArgs e)
        {
            if (randomCards.Count > 1)
            {
                DisplayCard(btnCard2, randomCards[1]);
            }
        }

        private void btnCard3_Click(object sender, EventArgs e)
        {
            if (randomCards.Count > 2)
            {
                DisplayCard(btnCard3, randomCards[2]);
            }
        }
    }
}
