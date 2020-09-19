using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Repositories
{
    public class BookRepository : IBookRepository
    {
        public BookModel Get(int bookId)
        {
            throw new NotImplementedException();
        }
        public IQueryable<BookModel> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public void Add(BookModel book)
        {
            throw new NotImplementedException();
        }
        public void Update(int bookId, BookModel book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int bookId)
        {
            throw new NotImplementedException();
        }
       
    }
}
