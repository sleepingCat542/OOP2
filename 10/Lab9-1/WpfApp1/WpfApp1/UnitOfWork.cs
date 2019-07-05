using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

        public class UnitOfWork : IDisposable
        {
            private Model1 db = new Model1();
            private BookRepository bookRepository;
            private ReaderRepository readerRepository;

            public ReaderRepository Readers
            {
                get
                {
                    if (readerRepository == null)
                    readerRepository = new ReaderRepository(db);
                    return readerRepository;
                }
            }

            public BookRepository Books
            {
                get
                {
                    if (bookRepository == null)
                    bookRepository = new BookRepository(db);
                    return bookRepository;
                }
            }

            public void Save()
            {
                db.SaveChanges();
            }

            private bool disposed = false;

            public virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        db.Dispose();
                    }
                    this.disposed = true;
                }
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
}

