using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace TarotApp
{
    public partial class frmResultLove : Form
    {
        private List<Card> selectedCards;  // Danh sách các lá bài được chọn
        private Model1 db = new Model1();  // Đối tượng context của Entity Framework
        private string theme;              // Lưu chủ đề hiện tại

        // Constructor nhận tham số là danh sách các lá bài và chủ đề
        public frmResultLove(List<Card> cards, string themeName)
        {
            InitializeComponent();
            selectedCards = cards;   // Lưu danh sách lá bài
            theme = themeName;       // Lưu tên chủ đề
            this.Text = $"Kết Quả - {theme}"; // Đặt tiêu đề form theo chủ đề
            DisplayCardMeanings();   // Hiển thị ý nghĩa các lá bài
        }

        private void DisplayCardMeanings()
        {
            string resultHtml = "<b>Kết Quả:</b><br><br>"; // Tiêu đề đậm

            if (selectedCards.Count == 0)
            {
                MessageBox.Show("Không có lá bài nào được chọn.");
                return;
            }

            foreach (var card in selectedCards)
            {
                // Truy vấn ý nghĩa từ bảng Meaning theo chủ đề
                var meaningQuery = db.Meanings
                    .Where(m => m.CardID == card.CardID && m.Theme.ThemeName == theme)
                    .FirstOrDefault();

                if (meaningQuery != null)
                {
                    string meaning = card.IsReversed ? meaningQuery.ReversedMeaning : meaningQuery.UprightMeaning;
                    string position = GetCardPositionText(selectedCards.IndexOf(card));
                    string direction = card.IsReversed ? "(Bài Ngược)" : "(Bài Xuôi)";

                    // Tạo kết quả với định dạng HTML
                    resultHtml += $"<b>{position}</b><br>";
                    resultHtml += $"<i>{card.CardName} {direction}</i><br>";
                    resultHtml += $"{meaning}<br><br>";
                }
                else
                {
                    resultHtml += $"<b>{card.CardName}</b>: Không có ý nghĩa cho chủ đề này.<br><br>";
                }
            }

            // Hiển thị kết quả trong Guna2HtmlLabel
            lblResult.Text = resultHtml;
        }

        private string GetCardPositionText(int index)
        {
            // Xác định vị trí của lá bài trong 3 lá bài: Quá khứ, Hiện tại, Tương lai
            switch (index)
            {
                case 0: return "Vị trí 1 (Quá khứ)";
                case 1: return "Vị trí 2 (Hiện tại)";
                case 2: return "Vị trí 3 (Tương lai)";
                default: return "Vị trí không xác định";
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng ứng dụng
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có kết quả trong lblResult
            if (!string.IsNullOrEmpty(lblResult.Text))
            {
                // Định dạng lại nội dung kết quả sao cho dễ đọc
                string resultText = $"Kết Quả - {theme}:\n\n";
                foreach (var card in selectedCards)
                {
                    var meaningQuery = db.Meanings
                        .Where(m => m.CardID == card.CardID && m.Theme.ThemeName == theme)
                        .FirstOrDefault();

                    if (meaningQuery != null)
                    {
                        string meaning = card.IsReversed ? meaningQuery.ReversedMeaning : meaningQuery.UprightMeaning;
                        string position = GetCardPositionText(selectedCards.IndexOf(card));
                        string direction = card.IsReversed ? "(Bài Ngược)" : "(Bài Xuôi)";
                        resultText += $"{position}: {card.CardName} {direction}\n{meaning}\n\n";
                    }
                }

                // Sao chép nội dung vào clipboard
                Clipboard.SetText(resultText);

                // Thông báo cho người dùng rằng kết quả đã được sao chép
                MessageBox.Show("Kết quả đã được sao chép vào clipboard!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có kết quả để chia sẻ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
