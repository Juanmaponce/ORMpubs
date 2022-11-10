namespace WindowsFormsPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("roysched")]
    public partial class Roysched
    {
        [Key]
        [StringLength(6)]
        public string Title_id { get; set; }

        public int? Lorange { get; set; }

        public int? Hirange { get; set; }

        public int? Royalty { get; set; }

        public virtual Title Title { get; set; }
    }
}
