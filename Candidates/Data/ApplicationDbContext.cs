using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Candidates.Models;

namespace Candidates.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Candidates.Models.Candidate> Candidate { get; set; }
        public DbSet<Candidates.Models.Skill> Skill { get; set; }
        public DbSet<Candidates.Models.CandidateSkill> CandidateSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Skill>().HasOne<Candidate>(c => c.Candidate).WithMany(c => c.Skills).HasForeignKey(c => c.Idc);
            //builder.Entity<Candidate>().HasMany<Skill>(c => c.Skills).WithOne(c => c.Candidate).HasForeignKey(c => c.Idc);
            builder.Entity<CandidateSkill>().HasKey(cs => new { cs.Idc, cs.Ids });
            builder.Entity<CandidateSkill>().HasOne(cs => cs.Candidate).WithMany(c => c.CandidateSkills).HasForeignKey(cs => cs.Idc);
            builder.Entity<CandidateSkill>().HasOne(cs => cs.Skill).WithMany(s => s.CandidateSkills).HasForeignKey(cs => cs.Ids);
        }

    }
}
