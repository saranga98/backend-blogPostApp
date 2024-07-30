using BackendBlogPostSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace BackendBlogPostSite.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        //user**
        public DbSet<User> Users => Set<User>();

        //post
        public DbSet<Post> Posts { get; set; }

        //contact message
        public DbSet<Contact> Contacts { get; set; }

        //comments
        public DbSet<Comment> Comments { get; set; }





    }
}
