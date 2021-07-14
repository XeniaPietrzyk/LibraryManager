using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManager.Models;
using LibraryManager.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }

        // GET: Book
        public ActionResult Index()
        {
            return View(_bookRepository.GetAllActive());
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View(_bookRepository.Get(id));
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View(new BookModel());
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookModel bookModel)
        {
            _bookRepository.Add(bookModel);

            //bookModel.BookId = books.Count + 1;
            //bookModel.IsAvaliable = true;
            //books.Add(bookModel);

            return RedirectToAction(nameof(Index));            
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_bookRepository.Get(id));
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BookModel bookModel)
        {
            _bookRepository.Update(id, bookModel);

            //BookModel book = books.FirstOrDefault(x => x.BookId == id);
            //book.IsAvaliable = bookModel.IsAvaliable;
            //book.Isbn = bookModel.Isbn;
            //book.NumberOfPages = bookModel.NumberOfPages;
            //book.Publisher = bookModel.Publisher;
            //book.Title = bookModel.Title;
            //book.YearOfPublishment = bookModel.YearOfPublishment;
            //book.Author = bookModel.Author;

            return RedirectToAction(nameof(Index));           
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_bookRepository.Get(id));
        }

        // POST: Book/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BookModel bookModel)
        {
            _bookRepository.Delete(id);

            //BookModel book = books.FirstOrDefault(x => x.BookId == id);
            //books.Remove(book);

            return RedirectToAction(nameof(Index));            
        }

        //GET: Book/IsAvaliable
        public ActionResult Avaliable(int id)
        {
            BookModel book = _bookRepository.Get(id);
            book.IsAvaliable = true;
            _bookRepository.Update(id, book);
            
            //BookModel book = books.FirstOrDefault(x => x.BookId == id);
            //book.IsAvaliable = false;

            return RedirectToAction(nameof(Index));
        }
    }
}
