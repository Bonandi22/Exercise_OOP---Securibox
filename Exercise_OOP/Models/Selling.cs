namespace Exercise_OOP.Models
{
    public class Selling
    {
        public Product? Product { get; }
        public decimal UnitaryPrice { get; }
        public int Quantity { get; }
        public decimal TaxRate { get; }
        public string? CustomerReference { get; }

        public Selling(Product product, decimal unitaryPrice, int quantity, decimal taxRate, string customerReference)
        {
            Product = product;
            UnitaryPrice = unitaryPrice;
            Quantity = quantity;
            TaxRate = taxRate;
            CustomerReference = customerReference;
        }

        public decimal TotalPrice()
        {
            decimal subtotal = UnitaryPrice * Quantity;
            decimal total = subtotal * (1 + TaxRate); 
            return total;
        }
    }
}
   


