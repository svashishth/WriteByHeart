using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using _1_KavitaDilSe.Entities.Models;
using _1_KavitaDilSe.Entities.Mapping;

namespace _2_KavitaDilSe.Repository
{
    public class KavitaDilSeDbContext : DbContext, IKavitaDilSeDbContext
    {
        public DbSet<UserMasterModel> UserMaster { get; set; }

        public DbSet<CreationTypeMasterModel> CreationTypeMaster { get; set; }

        public DbSet<CreationsStoreModel> CreationStore { get; set; }

        //public DbSet<CreationEditHistoryModel> CreationEditHistory { get; set; }

        public KavitaDilSeDbContext() : base("Name=DbConnectionString")
        {
        }

        public KavitaDilSeDbContext(string connectionString) : base(connectionString)
        {
        }

        static KavitaDilSeDbContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CreationTypeMapping());
            modelBuilder.Configurations.Add(new UserMasterMapping());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
