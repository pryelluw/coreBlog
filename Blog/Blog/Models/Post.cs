using System;
using Microsoft.EntityFrameworkCore;


namespace Blog.Models
{

    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=app.db");
    }


    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
    }
}
