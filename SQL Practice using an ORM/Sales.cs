using System;
using System.Runtime.InteropServices;

namespace SQL_Practice_using_an_ORM
{
    public class Sales
    {
        public Sales()
        {
            
        }
        public Sales(int id, int salespersonid, decimal pretaxamount, DateTime saledate)
        {
            SaleID = id;
            SalespeopleID = salespersonid;
            PreTaxAmount = pretaxamount;
            SaleDate = saledate;
        }
        public int SaleID { get; set; }
        public int SalespeopleID { get; set; }
        public decimal PreTaxAmount { get; set; }
        public DateTime SaleDate { get; set; }

        public override string ToString()
        {
            return $"Sale ID:{SaleID}, PreTax Amount: {PreTaxAmount:C}, Date:{SaleDate:d}";
        }
    }
}