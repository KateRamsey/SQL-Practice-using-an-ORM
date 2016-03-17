using System;

namespace SQL_Practice_using_an_ORM
{
    internal class SalesWithPeople
    {
        public SalesWithPeople()
        {
            
        }
        public SalesWithPeople(int saleid, int salespeopleid, decimal pretaxamount, DateTime saledate, string name)
        {
            SaleId = saleid;
            SalespeopleID = salespeopleid;
            PreTaxAmount = pretaxamount;
            SaleDate = saledate;
            Name = name;
        }
        public int SaleId { get; set; }
        public int SalespeopleID { get; set; }
        public decimal PreTaxAmount { get; set; }
        public DateTime SaleDate { get; set; }
        public string Name { get; set; }


    }
}