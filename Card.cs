namespace TarotApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Card()
        {
            Meanings = new HashSet<Meaning>();
            Readings = new HashSet<Reading>();
            Readings1 = new HashSet<Reading>();
            Readings2 = new HashSet<Reading>();
        }

        public int CardID { get; set; }

        [Required]
        [StringLength(50)]
        public string CardName { get; set; }

        [Required]
        public string UprightMeaning { get; set; }

        [Required]
        public string ReversedMeaning { get; set; }

        [NotMapped]  // Đánh dấu thuộc tính này không ánh xạ vào cơ sở dữ liệu
        public bool IsReversed { get; set; }  // Thuộc tính lật ngược bài

        // Thêm thuộc tính ImagePath để lưu đường dẫn ảnh
        [Required]
        [StringLength(200)]  // Đặt độ dài phù hợp với độ dài của đường dẫn
        public string ImagePath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meaning> Meanings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reading> Readings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reading> Readings1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reading> Readings2 { get; set; }
    }
}
