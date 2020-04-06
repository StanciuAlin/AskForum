using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ApplicationLogic.DataModel;

namespace DataAccess
{
    public class AskForumDbContext : DbContext
    {
        public AskForumDbContext(DbContextOptions<AskForumDbContext> options) : base(options)
        {
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactMe> ContactMes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
