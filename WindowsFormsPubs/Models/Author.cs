namespace WindowsFormsPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Author
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Author()
        {
            Titleauthors = new HashSet<Titleauthor>();
        }

        [Key]
        [StringLength(11)]
        public string Au_id { get; set; }

        [Required]
        [StringLength(40)]
        public string Au_lname { get; set; }

        [Required]
        [StringLength(20)]
        public string Au_fname { get; set; }

        [Required]
        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Address { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(5)]
        public string Zip { get; set; }

        public bool Contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Titleauthor> Titleauthors { get; set; }
    }
}
