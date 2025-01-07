using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TarotApp
{
    [Table("ReadingDetail")]  // Sửa tên bảng tại đây để khớp với tên bảng trong CSDL
    public class ReadingDetail
    {
        [Key]
        public int ReadingDetailID { get; set; }

        public int ReadingID { get; set; }
        public int CardID { get; set; }
        public bool IsReversed { get; set; }

        public virtual Reading Reading { get; set; }
        public virtual Card Card { get; set; }
    }
}
