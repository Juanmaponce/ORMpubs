namespace WindowsFormsPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string Stor_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Ord_num { get; set; }

        public DateTime Ord_date { get; set; }

        public short Qty { get; set; }

        [Required]
        [StringLength(12)]
        public string Payterms { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string Title_id { get; set; }

        public virtual Store Store { get; set; }

        public virtual Title Title { get; set; }
    }
}
