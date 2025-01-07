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
    public partial class frmLichSu : Form
    {
        private Model1 db = new Model1();  // Đối tượng context của Entity Framework

        public frmLichSu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLichSu_Load(object sender, EventArgs e)
        {
            // Khi form load, gọi phương thức để lấy lịch sử xem bài và hiển thị vào DataGridView
            LoadReadingHistory();
        }
        private void LoadReadingHistory()
        {
            var historyList = db.Readings
                .Join(db.Cards, r => r.Card1ID, c => c.CardID, (r, c) => new { r, c })
                .Join(db.Cards, rc => rc.r.Card2ID, c2 => c2.CardID, (rc, c2) => new { rc.r, rc.c, c2 })
                .Join(db.Cards, rcc => rcc.r.Card3ID, c3 => c3.CardID, (rcc, c3) => new
                {
                    rcc.r.ReadingID,
                    rcc.r.CreatedAt,
                    rcc.r.Theme.ThemeName,
                    Card1 = rcc.c.CardName,
                    Card2 = rcc.c2.CardName,
                    Card3 = c3.CardName,
                    // Remove the ?. and use a null check instead
                    Card1Reversed = rcc.r.ReadingDetails.Any(rd => rd.CardID == rcc.c.CardID)
                                    ? rcc.r.ReadingDetails.FirstOrDefault(rd => rd.CardID == rcc.c.CardID).IsReversed
                                    : false,
                    Card2Reversed = rcc.r.ReadingDetails.Any(rd => rd.CardID == rcc.c2.CardID)
                                    ? rcc.r.ReadingDetails.FirstOrDefault(rd => rd.CardID == rcc.c2.CardID).IsReversed
                                    : false,
                    Card3Reversed = rcc.r.ReadingDetails.Any(rd => rd.CardID == c3.CardID)
                                    ? rcc.r.ReadingDetails.FirstOrDefault(rd => rd.CardID == c3.CardID).IsReversed
                                    : false
                })
                .Select(h => new
                {
                    h.ReadingID,
                    h.CreatedAt,
                    h.ThemeName,
                    Card1 = h.Card1 + " " + (h.Card1Reversed ? "(Ngược)" : "(Xuôi)"),
                    Card2 = h.Card2 + " " + (h.Card2Reversed ? "(Ngược)" : "(Xuôi)"),
                    Card3 = h.Card3 + " " + (h.Card3Reversed ? "(Ngược)" : "(Xuôi)")
                })
                .ToList();

            dgvLichSu.DataSource = historyList;
        }
        private void LoadReadingHistory(string searchKeyword = "")
        {
            var historyList = db.Readings
                .Join(db.Cards, r => r.Card1ID, c => c.CardID, (r, c) => new { r, c })
                .Join(db.Cards, rc => rc.r.Card2ID, c2 => c2.CardID, (rc, c2) => new { rc.r, rc.c, c2 })
                .Join(db.Cards, rcc => rcc.r.Card3ID, c3 => c3.CardID, (rcc, c3) => new
                {
                    rcc.r.ReadingID,
                    rcc.r.CreatedAt,
                    rcc.r.Theme.ThemeName,
                    Card1 = rcc.c.CardName,
                    Card2 = rcc.c2.CardName,
                    Card3 = c3.CardName,
                    Card1Reversed = rcc.r.ReadingDetails.Any(rd => rd.CardID == rcc.c.CardID)
                                        ? rcc.r.ReadingDetails.FirstOrDefault(rd => rd.CardID == rcc.c.CardID).IsReversed
                                        : false,
                    Card2Reversed = rcc.r.ReadingDetails.Any(rd => rd.CardID == rcc.c2.CardID)
                                        ? rcc.r.ReadingDetails.FirstOrDefault(rd => rd.CardID == rcc.c2.CardID).IsReversed
                                        : false,
                    Card3Reversed = rcc.r.ReadingDetails.Any(rd => rd.CardID == c3.CardID)
                                        ? rcc.r.ReadingDetails.FirstOrDefault(rd => rd.CardID == c3.CardID).IsReversed
                                        : false
                })
                .Where(h => string.IsNullOrEmpty(searchKeyword) || h.ThemeName.Contains(searchKeyword) ||
                            h.Card1.Contains(searchKeyword) || h.Card2.Contains(searchKeyword) || h.Card3.Contains(searchKeyword))
                .Select(h => new
                {
                    h.ReadingID,
                    h.CreatedAt,
                    h.ThemeName,
                    Card1 = h.Card1 + " " + (h.Card1Reversed ? "(Ngược)" : "(Xuôi)"),
                    Card2 = h.Card2 + " " + (h.Card2Reversed ? "(Ngược)" : "(Xuôi)"),
                    Card3 = h.Card3 + " " + (h.Card3Reversed ? "(Ngược)" : "(Xuôi)")
                })
                .ToList();

            dgvLichSu.DataSource = historyList;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtTim.Text.Trim();
            LoadReadingHistory(searchKeyword);  // Gọi lại phương thức với từ khóa tìm kiếm
        }
    }
}
