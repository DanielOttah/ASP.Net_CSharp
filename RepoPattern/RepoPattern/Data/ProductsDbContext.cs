using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepoPattern.Models;

namespace RepoPattern.Data
{
    public class ProductsDbContext:DbContext
    {
            public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
            {

            }
            public DbSet<Products> Products { get; set; }
        
    }
}
