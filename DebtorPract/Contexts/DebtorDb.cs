using DebtorPract.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DebtorPract.Contexts
{
    internal class DebtorDb : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConStr = "Initial Catalog=DebtorDb;Data Source=DESKTOP-R8Q6LD3\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(ConStr);
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Debtor>? Debtors { get; set; }
    }
}
