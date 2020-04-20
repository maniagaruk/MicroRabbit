using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MIcroRabbit.Banking.Data.Context
{
    public class BankingDbContext: DbContext
    {
        public BankingDbContext(DbContextOptions<BankingDbContext> options): base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
    }

    public class BankingDBContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BankingDbContext>();
            builder.UseSqlServer("Server=WCAPITLON1;Database=BankingDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new BankingDbContext(builder.Options);
        }
    }
}
