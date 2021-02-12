using DB_System.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB_System.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<DefenseOfThesis> DefenseOfThesis { get; set; }
        public DbSet<DiplomaThesis> DiplomaThesis { get; set; }
        public DbSet<FieldOfStudies> FieldOfStudies { get; set; }
        public DbSet<KeyWord> KeyWord { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Student> Student{ get; set; }
        public DbSet<UniwersityEmployee> UniwersityEmployee { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DiplomaThesis>()
                .HasMany(x => x.Reviews)
                .WithOne(y => y.DiplomaThesis)
                .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(builder);
        }

    }
}
