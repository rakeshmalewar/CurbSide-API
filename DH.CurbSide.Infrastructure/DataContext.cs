using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DH.CurbSide.Domain;
using System.Data.Entity.SqlServer;

namespace DH.CurbSide.Infrastructure
{
    public class DataContext : DbContext
    {
        private static SqlProviderServices instance = SqlProviderServices.Instance;
        public DataContext() : base(@"data source = RMALEWAR\SSEXPRESS2014; initial catalog = DHCurbside; Trusted_Connection=Yes")
        {
            Database.SetInitializer<DataContext>(null); //disable intializer
        }
        public virtual DbSet<Provider> ProvidersList { get; set; }
        public virtual DbSet<Whitelist> Whitelists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Provider>()
                .HasMany(e => e.ProviderId)
                .WithRequired(e => e.EmailAddress)
                .WillCascadeOnDelete(false);
            */
        }
    }
}
