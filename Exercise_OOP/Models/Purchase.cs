namespace Exercise_OOP.Models
{
    public class Purchase
    {
        public Product Product { get; }
        public decimal UnitaryPrice { get; }
        public int Quantity { get; }
        public decimal TaxRate { get; }
        public string CompanyReference { get; }

        public Purchase(Product product, decimal unitaryPrice, int quantity, decimal taxRate, string companyReference)
        {
            Product = product;
            UnitaryPrice = unitaryPrice;
            Quantity = quantity;
            TaxRate = taxRate;
            CompanyReference = companyReference;
        }

        public decimal TotalPrice()
        {
            decimal subtotal = UnitaryPrice * Quantity;
            decimal total = subtotal * (1 + TaxRate); // Adiciona o valor do imposto
            return total;
        }
    }
}
