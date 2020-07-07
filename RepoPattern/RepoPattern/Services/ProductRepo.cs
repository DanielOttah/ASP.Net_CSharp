using RepoPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepoPattern.Data;

namespace RepoPattern.Services
{
    public class ProductRepo : IProducts
    {
        private ProductsDbContext productsDbContext;

        public ProductRepo(ProductsDbContext _productsDbContext)
        {
            productsDbContext = _productsDbContext;
        }
        void IProducts.AddProducts(Products products)
        {
            productsDbContext.Products.Add(products);
            productsDbContext.SaveChanges(true);
        }

        void IProducts.DeleteProducts(int Id)
        {
            var product = productsDbContext.Products.Find(Id);
              productsDbContext.Products.Remove(product);
            productsDbContext.SaveChanges(true);
        }

        IEnumerable<Products> IProducts.GetProducts()
        {
            return productsDbContext.Products;
        }

        Products IProducts.GetProducts(int id)
        {
            var product = productsDbContext.Products.Find(id);
            return product;
        }

        void IProducts.UpdateProducts(Products products)
        {
            productsDbContext.Products.Update(products);
            productsDbContext.SaveChanges(true);
        }
    }
}
