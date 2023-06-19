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
    public class MerchandiseConfiguration : IEntityTypeConfiguration<Merchandise>
    {
        public void Configure(EntityTypeBuilder<Merchandise> builder)
        {
            builder.ToTable("MERCHANDISE");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .HasColumnName("ID");

            builder.Property(m => m.Name)
                .HasColumnName("NAME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(m => m.RegisterNumber)
                .HasColumnName("REGISTER_NUMBER")
                .IsRequired();

            builder.Property(m => m.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(m => m.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(m => m.Manufacturer)
                .HasColumnName("MANUFACTURER")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}