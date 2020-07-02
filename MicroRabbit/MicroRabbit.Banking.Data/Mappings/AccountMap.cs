using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Mappings
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.AccountType)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(a => a.AccountBalance)
                .IsRequired();
        }
    }
}
