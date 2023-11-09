using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coptil_Mihaela_Roxana_Lab2.Models;

namespace Coptil_Mihaela_Roxana_Lab2.Data
{
    public class Coptil_Mihaela_Roxana_Lab2Context : DbContext
    {
        public Coptil_Mihaela_Roxana_Lab2Context (DbContextOptions<Coptil_Mihaela_Roxana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Coptil_Mihaela_Roxana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Coptil_Mihaela_Roxana_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Coptil_Mihaela_Roxana_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Coptil_Mihaela_Roxana_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Coptil_Mihaela_Roxana_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Coptil_Mihaela_Roxana_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
