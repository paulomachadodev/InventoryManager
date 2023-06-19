using InventoryManager.Infra.Data.Configurations;
using InventoryManager.Core.DomainEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Infra.Data.Contexts
{
    //Regra 1: Herdar a classe DbContext
    public class SqlServerContext : DbContext
    {

        //Regra 2: Sobrescrever o método OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //definindo o tipo de banco de dados do projeto
            optionsBuilder.UseSqlServer(@"Data Source=SQL8005.site4now.net;User ID=db_a9b209_dbinventorymanager_admin;Password=@lbatroz2009;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        //Regra 3: Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de configuração criada no projeto
            modelBuilder.ApplyConfiguration(new MerchandiseConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        }

        //Regra 4: Mapear cada entidade do projeto através do DbSet
        public DbSet<Merchandise>? Merchandise { get; set; }
        public DbSet<Transaction>? Transaction { get; set; }
    }
}

