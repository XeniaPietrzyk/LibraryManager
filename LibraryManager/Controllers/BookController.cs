using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Controllers
{
    public class BookController : Controller
    {
        private static IList<BookModel> books = new List<BookModel>()        
        {
            new BookModel(){BookId=1, Title="Zaczarowany ogród", Author = "Rosa Rozalska", NumberOfPages=60, Isbn="122345678198", Publisher="Dobra Książka", YearOfPublishment=2020, IsAvaliable=true}
        };

        // GET: Book
        public ActionResult Index()
        {
            return View(books.Where(x => x.IsAvaliable == true));
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View(books.FirstOrDefault(x=> x.BookId == id));
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
            bookModel.BookId = books.Count + 1;
            bookModel.IsAvaliable = true;
            books.Add(bookModel);
            return RedirectToAction(nameof(Index));            
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View(books.FirstOrDefault(x=> x.BookId == id));
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BookModel bookModel)
        {
            BookModel book = books.FirstOrDefault(x => x.BookId == id);
            book.IsAvaliable = bookModel.IsAvaliable;
            book.Isbn = bookModel.Isbn;
            book.NumberOfPages = bookModel.NumberOfPages;
            book.Publisher = bookModel.Publisher;
            book.Title = bookModel.Title;
            book.YearOfPublishment = bookModel.YearOfPublishment;
            book.Author = bookModel.Author;
            return RedirectToAction(nameof(Index));           
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View(books.FirstOrDefault(x=> x.BookId == id));
        }

        // POST: Book/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BookModel bookModel)
        {
            BookModel book = books.FirstOrDefault(x => x.BookId == id);
            books.Remove(book);
            return RedirectToAction(nameof(Index));            
        }

        //GET: Book/IsAvaliable
        public ActionResult Avaliable(int id)
        {
            BookModel book = books.FirstOrDefault(x => x.BookId == id);
            book.IsAvaliable = false;
            return RedirectToAction(nameof(Index));
        }
    }
}
