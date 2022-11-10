namespace WindowsFormsPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class Employee
    {
        [Key]
        [StringLength(9)]
        public string Emp_id { get; set; }

        [Required]
        [StringLength(20)]
        public string Fname { get; set; }

        [StringLength(1)]
        public string Minit { get; set; }

        [Required]
        [StringLength(30)]
        public string Lname { get; set; }

        public short Job_id { get; set; }

        public byte? Job_lvl { get; set; }

        [Required]
        [StringLength(4)]
        public string Pub_id { get; set; }

        public DateTime Hire_date { get; set; }

        public virtual Job Job { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
