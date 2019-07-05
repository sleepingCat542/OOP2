namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(e => e.Reader)
                .WithOptional(e => e.Book)
                .HasForeignKey(e => e.BookId);
        }
    }
}
