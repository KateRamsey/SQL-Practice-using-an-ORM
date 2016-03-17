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
                new SalesPeople(1, "Decon"),
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

            foreach (var v in db.Query<SalesWithPeople>("select * from sales join Salespeople on sales.SalespeopleID = salespeople.id"))
            {
                Console.WriteLine(v);
            }
            // Should write to screen the information for each sale, crashes with unhandled exception
            foreach (var s in db.Query<Sales>("select * from sales"))
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();
        }
    }
}
