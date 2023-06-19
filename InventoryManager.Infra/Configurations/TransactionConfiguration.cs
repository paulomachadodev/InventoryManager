using InventoryManager.Core.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Infra.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("TRANSACTION");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .HasColumnName("ID");

            builder.Property(m => m.Quantity)
                .HasColumnName("QUANTITY")
                .IsRequired();

            builder.Property(m => m.DateTime)
                .HasColumnName("DATETIME")
                .IsRequired();

            builder.Property(m => m.Local)
                .HasColumnName("LOCAL")
                .IsRequired();

            builder.Property(m => m.MerchandiseId)
                .HasColumnName("MERCHANDISE_ID")
                .IsRequired();

            builder.Property(m => m.TransactionType)
                .HasColumnName("TYPE")
                .IsRequired();

            builder.HasOne(m => m.Merchandise) 
                .WithMany(m => m.Transactions) 
                .HasForeignKey(m => m.MerchandiseId) 
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
