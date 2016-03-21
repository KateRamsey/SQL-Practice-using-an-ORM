using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using PetaPoco.Providers;

namespace SQL_Practice_using_an_ORM
{
    class Program
    {
        static void Main(string[] args)
        {

            List<SalesPeople> SalesPeople = new List<SalesPeople>
            {
                new SalesPeople(1, "Deacon"),
                new SalesPeople(2, "Edan"),
                new SalesPeople(3, "Yardley"),
                new SalesPeople(4, "Farrah"),
                new SalesPeople(5, "Jessamine"),
                new SalesPeople(6, "Isabelle"),
                new SalesPeople(7, "Judah")
            };

            List<Sales> sales = new List<Sales>()
            {
                new Sales(1, 1, 2846, new DateTime(2015, 10, 15)),
                new Sales(2, 1, 8852, new DateTime(2015, 09, 21)),
                new Sales(3, 2, 5255, new DateTime(2015, 12, 07)),
                new Sales(4, 2, 5259, new DateTime(2016, 02, 27)),
                new Sales(5, 3, 7244, new DateTime(2015, 10, 15)),
                new Sales(6, 4, 8711, new DateTime(2015, 12, 21)),
                new Sales(7, 1, 746, new DateTime(2015, 10, 02)),
                new Sales(8, 5, 9970, new DateTime(2015, 04, 02)),
                new Sales(9, 6, 6009, new DateTime(2015, 12, 25)),
                new Sales(10, 7, 9703, new DateTime(2014, 07, 03))
            };

            var db = new PetaPoco.Database("dbstring");

            foreach (var s in SalesPeople)
            {
                db.Insert(s);
            }
            foreach (var s in sales)
            {
                db.Insert(s);
            }

            Console.WriteLine("Sales Information:");
            foreach (var v in db.Query<SalesWithPeople>("select * from sales join Salespeople on sales.SalespeopleID = salespeople.id"))
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();

            Console.WriteLine("Active Sales People:");
            foreach (var s in db.Query<SalesPeople>("select name from salesPeople"))
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();


            foreach (var s in db.Query<SaleAmount>("Select min(PreTaxAmount) as PreTaxAmount from Sales"))
            {
                Console.WriteLine($"Min Pre-tax sale amount is {s.PreTaxAmount:C}");
            }

            foreach (var s in db.Query<SaleAmount>("Select max(PreTaxAmount) as PreTaxAmount from Sales"))
            {
                Console.WriteLine($"Max Pre-tax sale amount is {s.PreTaxAmount:C}");
            }
            Console.WriteLine();

            Console.WriteLine("Sale People Total Sales Report:");
            foreach (var s in db.Query<SalesWithPeople>("Select sum(PreTaxAmount) as PreTaxAmount, Salespeople.Name as Name from Sales join Salespeople on Salespeople.ID = Sales.SalesPeopleID group by Salespeople.name"))
            {
                Console.WriteLine($"{s.Name} has sold {s.PreTaxAmount:C}");
            }
            Console.WriteLine();


            foreach (var s in db.Query<SalesWithPeople>("select datediff(DAY, Min(saledate),Max(saledate)) as Days from sales"))
            {
                Console.WriteLine($"Difference in first and last sale is {s.Days} days");
            }
            Console.WriteLine();

            Console.WriteLine("Sales per month report:");
            foreach (var s in db.Query<MonthAndSales>("select month(saledate) as Month, count(*) as NumOfSales from sales group by month(SaleDate)"))
            {
                if (s.NumOfSales > 1)
                {
                    Console.WriteLine($"{s.MonthName()} had {s.NumOfSales} sales");
                }
                else
                {
                    Console.WriteLine($"{s.MonthName()} had {s.NumOfSales} sale");
                }
            }
            Console.WriteLine();

            Console.Write("Total Sales tax (at 6%):");
            decimal totalSalesTax = 0m;
            foreach (var s in db.Query<Sales>("select * from sales"))
            {
                s.SalesTax = decimal.Multiply(s.PreTaxAmount, 0.06m);
                totalSalesTax += s.SalesTax;
            }
            Console.WriteLine($" {totalSalesTax:C}");






            Console.ReadLine();
        }
    }
}
