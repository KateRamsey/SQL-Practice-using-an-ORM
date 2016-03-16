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

            List<SalesPerson> SalesPeople = new List<SalesPerson>();
            SalesPeople.Add(new SalesPerson(1, "Decon"));
            SalesPeople.Add(new SalesPerson(2, "Edan"));
            SalesPeople.Add(new SalesPerson(3, "Yardley"));
            SalesPeople.Add(new SalesPerson(4, "Farrah"));
            SalesPeople.Add(new SalesPerson(5, "Jessamine"));
            SalesPeople.Add(new SalesPerson(6, "Isabelle"));
            SalesPeople.Add(new SalesPerson(7, "Judah"));

            var db = new PetaPoco.Database("dbstring");


            var article = new SalesPerson();
            {


            }
        }
    }
}
