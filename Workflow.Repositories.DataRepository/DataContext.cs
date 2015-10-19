using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

using Workflow.Common.Models;

namespace Workflow.Repositories.DataRepository
{
    class DataContext : DbContext
    {
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestNote> RequestNotes { get; set; }
        public virtual DbSet<RequestData> RequestData { get; set; }

        //using fluent api instead of attributes (avoids decorating POCO class with EF-specific attributes)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //On each entity, we need to define a key column.
            modelBuilder.Entity<Process>().HasKey(x => x.ProcessId);
            modelBuilder.Entity<User>().HasKey(x => x.UserId);
            modelBuilder.Entity<Request>().HasKey(x => x.RequestId);
            modelBuilder.Entity<RequestNote>().HasKey(x => x.RequestNoteId);
            modelBuilder.Entity<RequestData>().HasKey(x => x.RequestDataId);

            //specify that the keys are IDENTITY columns
            modelBuilder.Entity<Process>()
                .Property(x => x.ProcessId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<User>()
                .Property(x => x.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Request>()
                .Property(x => x.RequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<RequestNote>()
                .Property(x => x.RequestNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<RequestData>()
                .Property(x => x.RequestDataId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //for each property in an entity, define the attributes of the corresponding column (string length, nullable, etc).
            //process
            modelBuilder.Entity<Process>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            //user
            modelBuilder.Entity<User>()
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<User>()
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100);

            //request
            modelBuilder.Entity<Request>()
                .Property(x => x.DateRequested)
                .IsRequired();
            modelBuilder.Entity<Request>()
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            //request note
            modelBuilder.Entity<RequestNote>()
                .Property(x => x.Note)
                .IsRequired()
                .HasMaxLength(500);

            //request data
            modelBuilder.Entity<RequestData>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<RequestData>()
                .Property(x => x.Value)
                .IsRequired()
                .HasMaxLength(100);



            //For each relationship, define the multiplicity on each side 
            modelBuilder.Entity<Process>()
                .HasMany(x => x.ProcessAdmins)
                .WithMany(x => x.AdministeredProcesses)
                .Map(c => c.MapLeftKey("UserId")
                .MapRightKey("ProcessId")
                .ToTable("ProcessAdmin"));

            modelBuilder.Entity<Request>()
                .HasMany(x => x.Stakeholders)
                .WithMany(x => x.StakeRequests)
                .Map(c => c.MapLeftKey("UserId")
                .MapRightKey("RequestId")
                .ToTable("RequestStakeholder"));

            modelBuilder.Entity<Request>()
                .HasMany(x => x.RequestNotes)
                .WithRequired(x => x.Request);

            modelBuilder.Entity<Request>()
                .HasMany(x => x.RequestData)
                .WithRequired(x => x.Request);

            modelBuilder.Entity<User>()
                .HasMany(x => x.RequestNotes)
                .WithRequired(x => x.User);
        }
    }
}

