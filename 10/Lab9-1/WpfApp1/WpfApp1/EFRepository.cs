using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ReaderRepository : IRepository<Reader>
    {
        DbContext _context;//ссылка на контекст набор DbSet
        DbSet<Reader> _dbSet;

        public ReaderRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Reader>();
        }

        public void Create(Reader item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public Reader FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<Reader> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Reader> Get(Func<Reader, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(Reader item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public void Update(Reader item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public DbContextTransaction Transaction()
        {
            return _context.Database.BeginTransaction();
        }
    }

    public class BookRepository : IRepository<Book>
    {
        DbContext _context;
        DbSet<Book> _dbSet;

        public BookRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Book>();
        }

        public void Create(Book item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public Book FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<Book> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Book> Get(Func<Book, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(Book item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public void Update(Book item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public DbContextTransaction Transaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
