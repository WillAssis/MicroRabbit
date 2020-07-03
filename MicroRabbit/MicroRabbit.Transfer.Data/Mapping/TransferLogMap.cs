using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Mapping
{
    public class TransferLogMap : IEntityTypeConfiguration<TransferLog>
    {
        public void Configure(EntityTypeBuilder<TransferLog> builder)
        {
            builder.ToTable("TransferLog");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.FromAccount)
                .IsRequired();

            builder.Property(t => t.ToAccount)
                .IsRequired();

            builder.Property(t => t.TransferAmount)
               .IsRequired();
        }
    }
}
