using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;


namespace EF_CodeFirst.Controllers
{

    public class PublisherController : Controller
    {

//private member
        private readonly LibraryContext _context;
        //ctor
        public PublisherController(LibraryContext context)
        {
            _context = context;
        }
//methods
        public IActionResult Index()
        {
            var publishers = _context.Publishers
            .Where(x=>x.IsDeleted==false).ToList();
            return View(publishers);
        }
        public IActionResult Detail(int id){
            var publisher = _context.Publishers.Find(id);
            return View(publisher);
        }
        public IActionResult Edit(int id){
            var publisher = _context.Publishers.Find(id);

            return View(publisher);
        }
        [HttpPost]
        public IActionResult Edit(Publisher publisher){
            _context.Publishers.Update(publisher);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetDeletePublishers()
        {
            var publishers = _context.Publishers
            .Where(x=>x.IsDeleted==true).ToList();
            return View("Index", publishers);
        }
        public IActionResult Delete(int id)
        {
            var publisher = _context.Publishers.Find(id);
            return View(publisher);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var publisher = _context.Publishers.Find(id);
            publisher.IsDeleted=true;
            _context.Publishers.Update(publisher);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Publisher publisher)
        {
            _context.Add(publisher);
            _context.SaveChanges();
            return RedirectToAction();
        }
    }
}