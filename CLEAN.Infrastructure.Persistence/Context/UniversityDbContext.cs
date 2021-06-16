using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CLEAN.Infrastructure.Persistence.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}
