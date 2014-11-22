using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class TMSContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public TMSContext()
            : base("name=TMSEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //PK
            modelBuilder.Entity<UserModel>().HasKey(c => c.Id);
            modelBuilder.Entity<UserModel>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<UserModel>().Property(c => c.UserName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<UserModel>().Property(c => c.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<UserModel>().Property(c => c.Address).HasMaxLength(null);
            modelBuilder.Entity<UserModel>().Property(c => c.PhoneNo).HasMaxLength(20);
            modelBuilder.Entity<UserModel>().Property(c => c.District).IsOptional();
            modelBuilder.Entity<UserModel>().Property(c => c.State).IsOptional();
            



        }
    }
}
