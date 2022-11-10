namespace WindowsFormsPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Discount
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string Discounttype { get; set; }

        [StringLength(4)]
        public string Stor_id { get; set; }

        public short? Lowqty { get; set; }

        public short? Highqty { get; set; }

        [Key]
        [Column("discount", Order = 1)]
        public decimal Discount1 { get; set; }

        public virtual Store Store { get; set; }
    }
}
