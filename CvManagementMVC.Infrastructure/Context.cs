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
        public DbSet<Address> CandidateAddresses { get; set; }
        public DbSet<CandidateContact> CandidateContacts { get; set; }
        public DbSet<EducationHistory> EducationHistories { get; set; }
        public DbSet<EmploymentHistory> EmploymentHistories { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CvSkill> CvSkills { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cv>()
                .HasOne(a => a.Candidate).WithOne(b => b.Cv).HasForeignKey<Cv>(c => c.CandidateId);

            builder.Entity<CvSkill>()
                .HasKey(it => new { it.CvId, it.SkillId });
            builder.Entity<CvSkill>()
                .HasOne<Cv>(a=>a.Cv)
                .WithMany(b => b.CvSkills)
                .HasForeignKey(c => c.CvId);
            builder.Entity<CvSkill>()
                .HasOne<Skill>(a => a.Skill)
                .WithMany(b => b.CvSkills)
                .HasForeignKey(c => c.SkillId);
            builder.Entity<Cv>()
                .HasMany(a => a.EducationHistory).WithOne(b => b.Cv).HasForeignKey(c => c.CvId);
            builder.Entity<Cv>()
                .HasMany(a => a.EmploymentHistory).WithOne(b => b.Cv).HasForeignKey(c => c.CvId);
            builder.Entity<CandidateContact>()
                .HasOne(a => a.Candidate).WithOne(b => b.CandidateContact).HasForeignKey<CandidateContact>(c => c.CandidateId);
            builder.Entity<Address>()
                .HasOne(a => a.Candidate).WithOne(b => b.Address).HasForeignKey<Address>(c => c.CandidateId);

        }
    }
}
