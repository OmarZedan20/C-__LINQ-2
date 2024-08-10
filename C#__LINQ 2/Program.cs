

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C___LINQ_2;
using static C___LINQ_2.ListGenerator;
using Orders = C___LINQ_2.Orders;
using Customer = C___LINQ_2.ListGenerator.Customer;
using System.Diagnostics;

namespace C___LINQ_2
{
    internal class Program
    {
        public static void Main()
        {
            var Customers = ListGenerator.GetCustomersList();
            var products = ListGenerator.GetProductsList();
            string filePath = "dictionary_english.txt";
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region 1-- Get first Product out of Stock


            //var FirstOfUnitOfStock = (from p in products
            //                       where p.UnitsInStock == 0
            //                       select p).FirstOrDefault();
            // if (FirstOfUnitOfStock != null)
            // {
            //     Console.WriteLine($"The first product out of stock ---> {FirstOfUnitOfStock.ProductName}");
            // }
            #endregion

            #region 2-- Return the first product whose Price > 1000,

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


            //var SecondNumberGreaterThan5 = (from n in Arr where n> 5 select n).Skip(1).FirstOrDefault();

            //if (SecondNumberGreaterThan5 != null)
            //{
            //    Console.WriteLine($" the second number greater than 5 ---> {SecondNumberGreaterThan5}");
            //}

            #endregion

            #region 4-- Uses Count to get the number of odd numbers in the array

            //var TheOddNumbers =(from n in Arr where n % 2 != 0 select n).Count();
            //if (TheOddNumbers != null)
            //{
            //    Console.WriteLine($" Count of the odd numbers ---> {TheOddNumbers}");
            //}

            #endregion

            #region 5-- Return a list of customers and how many orders each has.
            //var customerOrderCounts = from c in Customer
            //                          join o in Order on c.CustomerId equals o.CustomerId into customerOrders
            //                          select new
            //                          {
            //                              CustomerName = c.Name,
            //                              OrderCount = customerOrders.Count()
            //                          };

            //foreach (var item in customerOrderCounts)
            //{
            //    Console.WriteLine($"Customer: {item.CustomerName}, Number of Orders: {item.OrderCount}");
            //}

            #endregion

            #region 6-- Return a list of categories and how many products each has

            //var categoryProductCounts = from p in products
            //                            group p by p.Category into productGroup
            //            select new{Category = productGroup.Key, ProductCount = productGroup.Count() };

            //foreach (var item in categoryProductCounts)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Number of Products: {item.ProductCount}");
            //}

            #endregion

            #region 7-- Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int TotalOfNumbersINArrat = Arr.Sum();
            //Console.WriteLine(TotalOfNumbersINArrat);
            #endregion

            #region 8--  Get the total number of characters of all words in dictionary_english.txt


            //if (File.Exists(filePath))
            //{
            //    try
            //    {
            //        // Read all lines from the file into an array of strings
            //        string[] words = File.ReadAllLines(filePath);

            //        // Calculate the total number of characters in all words
            //        int totalCharacters = words.Sum(word => word.Length);

            //        // Output the result
            //        Console.WriteLine($"The total number of characters in all words is: {totalCharacters}");
            //    }
            //    catch (Exception ex)
            //    {
            //        // Handle exceptions (e.g., file not found)
            //        Console.WriteLine($"An error occurred: {ex.Message}");
            //    }
            //}


            #endregion

            #region 9-- Get the length of the shortest word in dictionary_english.txt

            //string[] words = File.ReadAllLines(filePath);


            //int LengthOfShortestWord = words
            //    .Where(word => !string.IsNullOrWhiteSpace(word))
            //    .Min(word => word.Length);

            //Console.WriteLine($" length of the shortest word in dictionary_english -->8 {LengthOfShortestWord}");

            #endregion

            #region 10-- Get the length of the longest word in dictionary_english.txt

            //string[] words = File.ReadAllLines(filePath);

            //int LongestWordLength = words.Max(word => word.Length);

            //Console.WriteLine($" length of the londest word in dictionary_english --> {LongestWordLength}");

            #endregion

            #region 11--Get the average length of the words in dictionary_english.txt

            //string[] words = File.ReadAllLines(filePath);

            //double AverageWordLength = words.Average(words => words.Length);

            //Console.WriteLine($" the average length of the words in dictionary_english --> {AverageWordLength}");

            #endregion

            #region 12-- Get the total units in stock for each product category.

            //var totalUnitsInStockByCategory = from p in products
            //                                  group p by p.Category into productGroup
            //                                  select new
            //                                  {
            //                                      Category = productGroup.Key,
            //                                      TotalUnitsInStock = productGroup.Sum(p => p.UnitsInStock)
            //                                  };

            //foreach (var item in totalUnitsInStockByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock--> {item.TotalUnitsInStock}");
            //}

            #endregion

            #region 13&14 -- Get the cheapest price among each category's products

            //var cheapestPriceByCategory = from p in products
            //                              group p by p.Category into productGroup
            //                              select new
            //                              {
            //                                  Category = productGroup.Key,
            //                                  CheapestPrice = productGroup.Min(p => p.UnitPrice)
            //                              };

            //foreach (var item in cheapestPriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.CheapestPrice:C}");
            //}

            //Console.WriteLine("***********************************************************");
            //var cheapestProductsByCategory_Let = from p in products
            //                                     group p by p.Category into productGroup
            //                                     let minPrice = productGroup.Min(p => p.UnitPrice)
            //                                     from p in productGroup
            //                                     where p.UnitPrice == minPrice
            //                                     select new
            //                                     {
            //                                         p.Category,
            //                                         p.ProductName,
            //                                         p.UnitPrice
            //                                     };

            //foreach (var item in cheapestProductsByCategory_Let)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.ProductName}, Price: {item.UnitPrice:C}");
            //}

            #endregion

            #region 15&16 --  Get the most expensive price among each category's products.& Get the products with the most expensive price in each category.


            //var MostExpensivePriceByCategory = from p in products
            //                              group p by p.Category into productGroup
            //                              select new
            //                              {
            //                                  Category = productGroup.Key,
            //                                  MaxPrice = productGroup.Max(p => p.UnitPrice)
            //                              };

            //foreach (var item in MostExpensivePriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.MaxPrice:C}");
            //}
            #endregion

            #region 17 -- Get the average price of each category's products.

            //var A0veragePriceByCategory = from p in products
            //                             group p by p.Category into productGroup
            //                             select new
            //                             {
            //                                 Category = productGroup.Key,
            //                                 AveragePrice = productGroup.Average(p => p.UnitPrice)
            //                             };

            //foreach (var item in A0veragePriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice:C}");
            //}

            #endregion

            #region 18-- Find the unique Category names from Product List

            //var UniqueCategories = (from p in products
            //                        select p.Category).Distinct();

            //Console.WriteLine("Unique Category Products -->");
            //foreach (var category in UniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region 19 -- Produce a Sequence containing the unique first letter from both product and customer names.

            //var customerFirstLetters = Customers.Select(c => c.CustomerName[0]);

            //var productFirstLetters = products.Select(p => p.ProductName[0]);
            //var FirstLetters = customerFirstLetters
            //                .Union(productFirstLetters)
            //                .Distinct()
            //                .OrderBy(letter => letter);

            //Console.WriteLine("Unique Letter from Customer and Product -->");
            //foreach (var letter in FirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region 20&21 -- Create a sequence that contains the common first letter from both product and customer names.

            //var customerFirstLetters = Customers.Select(c => c.CustomerName[0]);

            //// Get the first letters of product names
            //var productFirstLetters = products.Select(p => p.ProductName[0]);

            //// Find common first letters using Intersect
            //var commonFirstLetters = customerFirstLetters
            //                            .Intersect(productFirstLetters)
            //                            .OrderBy(letter => letter);

            //// Output the common first letters
            //Console.WriteLine("Common Letter from Customer and Product -->");
            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region 22 --  Create one sequence that contains the last Three Characters in each name of all customers and products,including any duplicates
            #endregion

            #region 23&24 -- Get the first 2 orders from customers in Washington<>Get all but the first 2 orders from customers in Washington.

            //var first3Orders = Customers
            //        .Where(c => c.City == "Washington")
            //        .SelectMany(c => c.Order)
            //        .OrderBy(o => o.OrderDate)
            //        //.Take(3)
            //        .Skip(2);


            //Console.WriteLine("First 2 orders from customers in Washington-->"); foreach (var order in first3Orders)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

            #region 25-- Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 3, 1, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((number, index) => number >= index);

            //// Output the result
            //Console.WriteLine("Elements until a number is hit that is less than its position-->");
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 26-- Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(number => number % 3 != 0);
            //Console.WriteLine("Elements divisible by 3-->");
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //    Console.WriteLine("*****");
            //}

            #endregion

            #region 28-- Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words = File.ReadAllLines(filePath);

            //bool containsEi = words.Any(word => word.Contains("ei"));

            //if (containsEi)
            //{
            //    Console.WriteLine(" the dictionary contains the substring 'ei'.");
            //}
            //else
            //{
            //    Console.WriteLine("the dictionary dosen’t contain the substring 'ei'.");
            //}

            #endregion

            #region 29--  Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var groupedProducts = products
            //                     .GroupBy(p => p.Category)
            //                     .Where(g => g.Any(p => p.UnitsInStock == 0))
            //                     .Select(g => new
            //                     {
            //                         Category = g.Key,
            //                         Products = g
            //                      });

            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("*******"); 
            //}

            #endregion

            #region 30-- Use group by to partition a list of numbers by their remainder when divided by 5

            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var groupedByRemainder = numbers
               .GroupBy(n => n % 5)
               .Select(g => new
               {
                   Remainder = g.Key,
                   Numbers = g.ToList()
               });

            foreach (var group in groupedByRemainder)
            {
                Console.WriteLine($"Numbers With a remainder of {group.Remainder}  when divided by 5 :");
                foreach (var number in group.Numbers)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine();
            }


            #endregion
        }
    }
}
