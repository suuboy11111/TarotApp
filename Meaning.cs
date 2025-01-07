namespace TarotApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Meaning
    {
        public int MeaningID { get; set; }

        public int CardID { get; set; }

        public int ThemeID { get; set; }

        [Required]
        public string UprightMeaning { get; set; }

        [Required]
        public string ReversedMeaning { get; set; }

        public virtual Card Card { get; set; }

        public virtual Theme Theme { get; set; }
    }
}
