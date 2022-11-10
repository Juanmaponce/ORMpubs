namespace WindowsFormsPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PubInfo
    {
        [Key]
        [StringLength(4)]
        public string Pub_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [Column(TypeName = "text")]
        public string Pr_info { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
