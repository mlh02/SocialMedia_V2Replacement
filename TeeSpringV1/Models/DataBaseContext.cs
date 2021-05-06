using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TeeSpringV1.Models;

namespace TeeSpringV1.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public ISet<User> Users { get; set; }
        public DbSet<TeeSpringV1.Models.User> User { get; set; }
        public DbSet<TeeSpringV1.Models.Product> Product { get; set; }
    }

}
