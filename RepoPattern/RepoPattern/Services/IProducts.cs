using RepoPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPattern.Services
{
    interface IProducts
    {
        IEnumerable<Products> GetProducts();

        Products GetProducts(int id);

        void AddProducts(Products products);
        void UpdateProducts(Products products);
        void DeleteProducts(int Id);


    }
}
