using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class AskForumDBContext : DbContext
    {
        public AskForumDBContext(DbContextOptions<AskForumDBContext> options) : base(options)
        {
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseGrade> CourseGrades { get; set; }
        public DbSet<CoursePresence> CoursePresences { get; set; }
    }
}
