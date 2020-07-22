using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=LAPTOP-G0H4BO0U\\SQLEXPRESS2017; database=CoreBooks; integrated security=true;");

        }

        public DbSet<Book> books { get; set; }
    }
}
