namespace TarotApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reading
    {
        public int ReadingID { get; set; }

        public int ThemeID { get; set; }

        public int Card1ID { get; set; }

        public int Card2ID { get; set; }

        public int Card3ID { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual Card Card { get; set; }

        public virtual Card Card1 { get; set; }

        public virtual Card Card2 { get; set; }

        public virtual Theme Theme { get; set; }

        public virtual ICollection<ReadingDetail> ReadingDetails { get; set; }
    }
}
