using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gherghelas_Theodora_Lab2.Models;

namespace Gherghelas_Theodora_Lab2.Data
{
    public class Gherghelas_Theodora_Lab2Context : DbContext
    {
        public Gherghelas_Theodora_Lab2Context (DbContextOptions<Gherghelas_Theodora_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Gherghelas_Theodora_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Gherghelas_Theodora_Lab2.Models.Publisher>? Publisher { get; set; }

        internal object Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }

        public DbSet<Gherghelas_Theodora_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Gherghelas_Theodora_Lab2.Models.Category>? Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity < Book > ()
                 .HasOne(b => b.Borrowing)
                 .WithOne(bw => bw.Book)
                 .HasForeignKey<Borrowing>(bw => bw.BookID);
                }

        public DbSet<Gherghelas_Theodora_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Gherghelas_Theodora_Lab2.Models.Borrowing>? Borrowing { get; set; }

    }
}
