using System;

namespace SQL_Practice_using_an_ORM
{
    public class Sale
    {
        public int ID { get; set; }
        public int SalespeopleID { get; set; }
        public decimal PreTaxAmount { get; set; }
        public DateTime SaleDate { get; set; }
    }
}