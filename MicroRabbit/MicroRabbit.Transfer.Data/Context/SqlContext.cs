using MicroRabbit.Transfer.Data.Mapping;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options) { }

        public DbSet<TransferLog> TransferLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TransferLogMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
