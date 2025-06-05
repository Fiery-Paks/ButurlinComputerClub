namespace WindowsFormsAppComputerClub.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Computers> Computers { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computers>()
                .Property(e => e.cost_hour)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Computers>()
                .HasMany(e => e.Sessions)
                .WithOptional(e => e.Computers)
                .HasForeignKey(e => e.computer_id);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Roles)
                .HasForeignKey(e => e.role_id);

            modelBuilder.Entity<Sessions>()
                .Property(e => e.total_cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Users>()
                .Property(e => e.balance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Sessions)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.user_id);
        }
    }
}
