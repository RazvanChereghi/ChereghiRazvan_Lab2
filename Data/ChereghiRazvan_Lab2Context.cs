using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChereghiRazvan_Lab2.Models;

namespace ChereghiRazvan_Lab2.Data
{
    public class ChereghiRazvan_Lab2Context : DbContext
    {
        public ChereghiRazvan_Lab2Context (DbContextOptions<ChereghiRazvan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<ChereghiRazvan_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<ChereghiRazvan_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<ChereghiRazvan_Lab2.Models.Author>? Author { get; set; }
    }
}
