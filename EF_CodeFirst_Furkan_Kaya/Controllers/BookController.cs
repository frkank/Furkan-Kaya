using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst_Furkan_Kaya.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryContext _context;
        public BookController(LibraryContext context)
        {
            _context=context;
        }
         public IActionResult Index()
        {
            var books = _context.Books.Where(x=>x.IsDeleted==false).ToList();
            return View(books);
        }
        public IActionResult Detail(int id)
        {
            var book = _context.Books
                        .Include(d => d.Category).Include(d => d.Author).Include(d => d.Publisher).First(x => x.BookId == id);
            return View(book);
        }
        public IActionResult Edit(int id)
        {
            var book=_context.Books.Find(id);
            ViewData["CategoryId"]=new SelectList(_context.Categories.Where(b=>b.IsDeleted==false),"CategoryId","CategoryName",book.CategoryId);
            ViewData["AuthorId"]=new SelectList(_context.Authors.Where(b=>b.IsDeleted==false),"AuthorId","AuthorFullName",book.AuthorId);
            ViewData["PublisherId"]=new SelectList(_context.Publishers.Where(b=>b.IsDeleted==false),"PublisherId","PublisherName",book.PublisherId);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetDeletedBooks()
        {
            var books=_context.Books.Where(x=>x.IsDeleted==true).ToList();
            return View("Index",books);
        }
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _context.Books.Find(id);
            book.IsDeleted=true;
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Create(){
            ViewData["CategoryId"]= new SelectList(_context.Categories.Where(q=>q.IsDeleted==false),"CategoryId","CategoryName");
            ViewData["AuthorId"]= new SelectList(_context.Authors.Where(q=>q.IsDeleted==false),"AuthorId","AuthorFullName");
            ViewData["PublisherId"]= new SelectList(_context.Publishers.Where(q=>q.IsDeleted==false),"PublisherId","PublisherName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}