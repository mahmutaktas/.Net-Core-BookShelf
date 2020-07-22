using BookShelf.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.ViewComponents
{
    public class NewBooks : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var bookList = new List<Book>
            {
                new Book(){ID=6, BookName="Korku", Author="Zweig"},
                new Book(){ID=7, BookName="Harry Potter", Author="JK Rowling"}
            };

            return View(bookList);
        }


    }
}
