namespace Exercise_OOP.Models
{
    public class Company : Customer
    {
        public string NIPC { get; }
        public List<Selling> Sellings { get; }

        public Company(string name, string email, string nipc) : base(name, email)
        {
            NIPC = nipc;
            Sellings = new List<Selling>();
        }

        public override string GetIdentificationNumber()
        {
            return NIPC;
        }

        public void AddSelling(Product product, decimal unitaryPrice, int quantity, decimal taxRate, string customerReference)
        {
            Sellings.Add(new Selling(product, unitaryPrice, quantity, taxRate, customerReference));
        }

        public decimal CalculateTotalSales()
        {
            return Sellings.Sum(selling => selling.TotalPrice());
        }
    }
}
