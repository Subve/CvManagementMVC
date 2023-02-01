using CvManagementMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Cv> Cvs { get; set; }
        public DbSet<Adress> CandidateAdresses { get; set; }
        public DbSet<CandidateContact> CandidateContacts { get; set; }
        public DbSet<EducationHistory> EducationHistories { get; set; }
        public DbSet<EmploymentHistory> EmploymentHistories { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cv>()
                .HasOne(a => a.Candidate).WithOne(b => b.Cv).HasForeignKey<Cv>(c => c.CandidateId);
            builder.Entity<Cv>()
                .HasMany(a => a.Skill).WithOne(b => b.Cv).HasForeignKey(c => c.CvId);
            builder.Entity<Cv>()
                .HasMany(a => a.EducationHistory).WithOne(b => b.Cv).HasForeignKey(c => c.CvId);
            builder.Entity<Cv>()
                .HasMany(a => a.EmploymentHistory).WithOne(b => b.Cv).HasForeignKey(c => c.CvId);
            builder.Entity<CandidateContact>()
                .HasOne(a => a.Candidate).WithOne(b => b.CandidateContact).HasForeignKey<CandidateContact>(c => c.CandidateId);
            builder.Entity<Adress>()
                .HasOne(a => a.Candidate).WithOne(b => b.CandidateAdress).HasForeignKey<Adress>(c => c.CandidateId);

        }
    }
}
