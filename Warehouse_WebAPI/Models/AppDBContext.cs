using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Warehouse_WebAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
 
        public DbSet<vendor> Vendors { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Expense> Expenses { get; set; }

    }
}