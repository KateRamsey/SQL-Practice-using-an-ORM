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




            var db = new PetaPoco.Database("dbstring");
            foreach (var s in SalesPeople)
            {
                db.Insert(s);
            }


        }
    }
}
