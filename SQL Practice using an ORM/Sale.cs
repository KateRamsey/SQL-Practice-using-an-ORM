using System;
using System.Runtime.InteropServices;

namespace SQL_Practice_using_an_ORM
{
    public class Sale
    {
        public Sale(int id, int salespersonid, decimal pretaxamount, DateTime saledate)
        {
            ID = id;
            SalespeopleID = salespersonid;
            PreTaxAmount = pretaxamount;
            SaleDate = saledate;
        }
        public int ID { get; set; }
        public int SalespeopleID { get; set; }
        public decimal PreTaxAmount { get; set; }
        public DateTime SaleDate { get; set; }
    }
}