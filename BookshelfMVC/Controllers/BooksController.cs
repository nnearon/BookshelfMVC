using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookshelfMVC.Controllers
{
    public class BookController : Controller
    {
        private static List<string> books = new List<string>()
        {
            "Atomic Habits",
            "The Fourth Child",
            "The Distance Home"
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(books);
        }

        [HttpPost]
        public IActionResult AddBook(string bookName)
        {
            books.Add(bookName);
            return RedirectToAction("Index");
        }
    }
}
