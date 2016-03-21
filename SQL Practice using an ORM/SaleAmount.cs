namespace SQL_Practice_using_an_ORM
{
    public class SaleAmount
    {
        public SaleAmount()
        {

        }
        public SaleAmount(decimal pretaxamount)
        {
            PreTaxAmount = pretaxamount;
        }
        public decimal PreTaxAmount { get; set; }

        public override string ToString()
        {
            return $"{PreTaxAmount:C}";
        }
    }
}