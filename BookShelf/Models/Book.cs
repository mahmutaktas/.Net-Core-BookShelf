using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {

        [Key]
        public int ID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
    }
}
