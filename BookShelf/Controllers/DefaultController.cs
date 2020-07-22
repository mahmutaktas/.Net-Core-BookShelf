using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookShelf.Models;

namespace BookShelf.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {

            //var bookList = new List<Book>()
            //{
            //    new Book(){ID=1, BookName="Satranc", Author="Zweig"},
            //    new Book(){ID=2, BookName="Alamut", Author="Vladimir"},
            //    new Book(){ID=3, BookName="Sherlock Holmes", Author="Arthur Coyle"},
            //    new Book(){ID=4, BookName="80 Gunde Dunya Devri", Author="Jules Verne"},
            //    new Book(){ID=5, BookName="Lord Of The Rings", Author="J.R.R. Tolkien"}

            //};

            var values = c.books.ToList();

            return View(values);
        }

        public IActionResult StaticTheme()
        {
            return View();
        }
    }
}