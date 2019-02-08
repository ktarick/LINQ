using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProdsGT200 = Linq.Products.Where(p => p.Price > 200)
                                          .OrderByDescending(q => q.Price)
                                          .ToArray();
            foreach (var pg in ProdsGT200)
            {
                pg.Print();
            }
            //var product = Linq.Products[0];
            //product.Print();
            //var productsWithVendors = from p in Linq.Products
            //                          join v in Linq.Vendors
            //                          on p.VendorId equals v.Id
            //                          select new
            //                          {
            //                              VendorName = v.Name,
            //                              ProductName = p.Name,
            //                              ProductPrice = p.Price
            //                          };
            //foreach (var pv in productsWithVendors)
            //{
            //    Console.WriteLine($"{pv.VendorName} {pv.ProductName} {pv.ProductPrice}");
            //}

            //var products = from p in Linq.Products
            //               where p.Price > 200
            //               orderby p.Name
            //               select p;
            //foreach(var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            //var vendors = from v in Linq.Vendors
            //              where v.Discount >= 0.1M
            //              orderby v.Name descending
            //              select v;
            //foreach(var vendor in vendors)
            //{
            //    Console.WriteLine(vendor.Name);
            //}

            //foreach (var vendor in Linq.Vendors)
            //{
            //    if (vendor.Discount >= 0.1m)
            //    {
            //        Console.WriteLine($"Vendors with discounts >= 0.1 {vendor}");
            //    }
            //}

            //Console.Write(Linq.About);

            Console.ReadKey();
        }
    }
}
