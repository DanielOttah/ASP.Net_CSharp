﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module2.Models;

namespace Module2.Data
{
    public class ProductsDbContext:DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext>options):base(options)
        {

        }
        public DbSet<Products> Products { get; set; }
    }
}
