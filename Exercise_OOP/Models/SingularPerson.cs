namespace Exercise_OOP.Models
{
    public class SingularPerson : Customer
    {
        public string NIF { get; }
        public List<Purchase> Purchases { get; }

        public SingularPerson(string name, string email, string nif) : base(name, email)
        {
            NIF = nif;
            Purchases = new List<Purchase>();
        }

        public override string GetIdentificationNumber()
        {
            return NIF;
        }

        public void AddPurchase(Product product, decimal unitaryPrice, int quantity, decimal taxRate, string companyReference)
        {
            Purchases.Add(new Purchase(product, unitaryPrice, quantity, taxRate, companyReference));
        }

        public decimal CalculateTotalPurchases()
        {
            return Purchases.Sum(purchase => purchase.TotalPrice());
        }
    }
}
