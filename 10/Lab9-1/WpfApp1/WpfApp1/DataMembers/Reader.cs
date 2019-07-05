namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reader")]
    public partial class Reader
    {
        [Key]
        public int IDReader { get; set; }

        [StringLength(45)]
        public string Surname { get; set; }

        [StringLength(45)]
        public string Address { get; set; }

        public int? BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
