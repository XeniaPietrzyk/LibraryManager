using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookManagerContext _context;
        public BookRepository(BookManagerContext context)
        {
            _context = context;
        }

        public BookModel Get(int bookId)
        => _context.Books.SingleOrDefault(x => x.BookId == bookId);

        //IQueryable<BookModel> IBookRepository.GetAll()
        //{
        //    _context.Books.All();
        //}

        public IQueryable<BookModel> GetAllActive()
        => _context.Books.Where(x => !x.IsAvaliable);

        public void Add(BookModel book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void Update(int bookId, BookModel book)
        {
            var result = _context.Books.FirstOrDefault(x=> x.BookId==bookId);
            if (result != null)
            {
                result.Title = book.Title;
                result.Publisher = book.Publisher;
                result.NumberOfPages = book.NumberOfPages;
                result.Isbn = book.Isbn;
                result.IsAvaliable = book.IsAvaliable;
                result.Author = book.Author;
                result.YearOfPublishment = book.YearOfPublishment;

                _context.SaveChanges();
            }
        }

        public void Delete(int bookId)
        {
            var result = _context.Books.SingleOrDefault(x=> x.BookId==bookId);
            if (result !=null)
            {
                _context.Books.Remove(result);
                _context.SaveChanges();
            }
        }

        public IQueryable<BookModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
