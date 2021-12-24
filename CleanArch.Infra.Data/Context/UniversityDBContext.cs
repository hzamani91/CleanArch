using System;
using Microsoft.EntityFrameworkCore;
using CleanArch.Domain.Models;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
