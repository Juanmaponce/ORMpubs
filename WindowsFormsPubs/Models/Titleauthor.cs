namespace WindowsFormsPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("titleauthor")]
    public partial class Titleauthor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string Au_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Title_id { get; set; }

        public byte? Au_ord { get; set; }

        public int? Royaltyper { get; set; }

        public virtual Author Author { get; set; }

        public virtual Title Title { get; set; }
    }
}
