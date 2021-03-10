﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemeoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);

            }

        }

      
    }
}