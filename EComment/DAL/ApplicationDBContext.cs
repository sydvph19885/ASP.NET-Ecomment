using EComment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EComment.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("MyConnectStrings") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}