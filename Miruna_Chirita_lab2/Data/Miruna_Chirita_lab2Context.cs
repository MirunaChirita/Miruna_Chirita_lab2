using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Miruna_Chirita_lab2.Models;

namespace Miruna_Chirita_lab2.Data
{
    public class Miruna_Chirita_lab2Context : DbContext
    {
        public Miruna_Chirita_lab2Context (DbContextOptions<Miruna_Chirita_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Miruna_Chirita_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Miruna_Chirita_lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Miruna_Chirita_lab2.Models.Author> Author { get; set; }
    }
}
