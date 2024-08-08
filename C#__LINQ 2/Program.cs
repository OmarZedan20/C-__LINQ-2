using Day_01_G03;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C___LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-- Get first Product out of Stock
            // var products = ListGenerator.GetProductsList();

            //var FirstOfUnitOfStock = (from p in products
            //                       where p.UnitsInStock == 0
            //                       select p).FirstOrDefault();
            // if (FirstOfUnitOfStock != null)
            // {
            //     Console.WriteLine($"The first product out of stock ---> {FirstOfUnitOfStock.ProductName}");
            // }
            #endregion

            #region 2-- Return the first product whose Price > 1000,
           // var products = ListGenerator.GetProductsList();

           //var FirstProduct = (from p in products
           //                       where p.UnitPrice > 1000
           //                       select p).FirstOrDefault();
           // if (FirstProduct != null)
           // {
           //     Console.WriteLine($"the first product whose Price > 1000 ---> {FirstProduct.ProductName}");
           // }
           // else
           // {
           //     Console.WriteLine($"there is no Product");
           // }
            #endregion

            #region 3--  Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var SecondNumberGreaterThan5 = (from n in Arr where n> 5 select n).Skip(1).FirstOrDefault();

            //if (SecondNumberGreaterThan5 != null)
            //{
            //    Console.WriteLine($" the second number greater than 5 ---> {SecondNumberGreaterThan5}");
            //}

            #endregion

        }
    }
}
