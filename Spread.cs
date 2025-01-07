namespace TarotApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Spread
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Position { get; set; }

        [Required]
        [StringLength(50)]
        public string PositionName { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
