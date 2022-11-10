namespace WindowsFormsPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Title
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Title()
        {
            Sales = new HashSet<Sale>();
            Titleauthors = new HashSet<Titleauthor>();
        }

        [Key]
        [StringLength(6)]
        public string Title_id { get; set; }

        [Column("title")]
        [Required]
        [StringLength(80)]
        public string Title1 { get; set; }

        [Required]
        [StringLength(12)]
        public string Type { get; set; }

        [StringLength(4)]
        public string Pub_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Advance { get; set; }

        public int? Royalty { get; set; }

        public int? Ytd_sales { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }

        public DateTime Pubdate { get; set; }

        public virtual Publisher Publisher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Titleauthor> Titleauthors { get; set; }

        public virtual Roysched Roysched { get; set; }
    }
}
