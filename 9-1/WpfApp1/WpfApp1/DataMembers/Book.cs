namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public Book()
        {
            Reader = new HashSet<Reader>();
        }

        [Key] 
        public int IDbook { get; set; }

        [Column("Book")]
        [StringLength(40)]
        public string Book1 { get; set; }

        [StringLength(40)]
        public string Author { get; set; }
        
        public virtual ICollection<Reader> Reader { get; set; }
    }
}
