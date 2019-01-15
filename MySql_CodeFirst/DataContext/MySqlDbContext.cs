using MySql_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_CodeFirst.DataContext
{
    class MySqlDbContext : DbContext
    {
        public MySqlDbContext() : base("name=MySQLConnection") { }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(x => x.ClientId);
            modelBuilder.Entity<Client>().Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
