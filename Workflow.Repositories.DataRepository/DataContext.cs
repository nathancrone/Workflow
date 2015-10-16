using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

using Workflow.Contracts.Models;

//using Workflow.Models;

namespace Workflow.Repositories.DataRepository
{
    class DataContext : DbContext
    {
        public virtual DbSet<IProcess> Processes { get; set; }
        public virtual DbSet<IUser> Users { get; set; }
        public virtual DbSet<IRequest> Requests { get; set; }

        //using fluent api instead of attributes (avoids decorating POCO class with EF-specific attributes)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //On each entity, we need to define a key column.
            modelBuilder.Entity<IProcess>().HasKey(x => x.ProcessId);
            modelBuilder.Entity<IUser>().HasKey(x => x.UserId);
            modelBuilder.Entity<IRequest>().HasKey(x => x.RequestId);

            //specify that the keys IDENTITY are columns
            modelBuilder.Entity<IProcess>()
                .Property(x => x.ProcessId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<IUser>()
                .Property(x => x.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<IRequest>()
                .Property(x => x.RequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //for each property in an entity, define the attributes of the corresponding column (string length, nullable, etc).
            //process
            modelBuilder.Entity<IProcess>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            //user
            modelBuilder.Entity<IUser>()
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<IUser>()
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100);

            //request
            modelBuilder.Entity<IRequest>()
                .Property(x => x.DateRequested)
                .IsRequired();
            modelBuilder.Entity<IRequest>()
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}

