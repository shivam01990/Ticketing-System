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
            //***********User Table**********//
            //PK
            modelBuilder.Entity<UserModel>().HasKey(c => c.Id);
            modelBuilder.Entity<UserModel>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<UserModel>().Property(c => c.UserName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<UserModel>().Property(c => c.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<UserModel>().Property(c => c.Address).HasMaxLength(null);
            modelBuilder.Entity<UserModel>().Property(c => c.PhoneNo).HasMaxLength(20);
            modelBuilder.Entity<UserModel>().Property(c => c.DistrictId).IsOptional();
            modelBuilder.Entity<UserModel>().Property(c => c.StateId).IsRequired();   
            //FK
            modelBuilder.Entity<UserModel>().HasRequired(c=>c.State).WithMany().HasForeignKey(c=>c.StateId);
            //FK
            modelBuilder.Entity<UserModel>().HasRequired(c=>c.District).WithMany().HasForeignKey(c=>c.DistrictId);
            //***********End Table Changes***********//

            //***********State Table*********//
            //PK
            modelBuilder.Entity<StateModel>().HasKey(c => c.StateId);
            modelBuilder.Entity<StateModel>().Property(c=>c.StateId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<StateModel>().Property(c=>c.StateName).HasMaxLength(150).IsRequired();
            //********End Table Changes*********//

             //***********District Table*********//
            //PK
            modelBuilder.Entity<DistrictModel>().HasKey(c => c.DisrictId);
            modelBuilder.Entity<DistrictModel>().Property(c=>c.DisrictId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<DistrictModel>().Property(c=>c.DistrictName).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<DistrictModel>().Property(c=>c.StateId).IsRequired();            
            //********End Table Changes*********//


        }
    }
}
