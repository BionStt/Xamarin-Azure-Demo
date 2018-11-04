﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EShope.Services.Data.Models;
using EShope.Services.Infra;

namespace EShope.Services.Data.Imp
{
    public class ProductService : IProductService
    {
        public ProductService(IAPIConsumer api)
        {
        }
        public async Task<List<Product>> GetProducts()
        {
            return await Task.Run(() => new List<Product> {
                new Product{
                    Id=1,
                    Name ="TV",
                    Description ="1 Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                    Price= 30},
                new Product{
                    Id=2,
                    Name ="Mobile",
                    Description ="2 Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                    Price= 50},
            });
        }
    }
}