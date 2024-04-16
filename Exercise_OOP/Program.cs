using Exercise_OOP.Models;

class Program
{
    static void Main(string[] args)
    {
        // customers
        var customer1 = new SingularPerson("John Doe", "john.doe@example.com", "123456789");
        var customer2 = new Company("Acme Inc.", "acme@example.com", "987654321");

        // Add purchases for the individual
        customer1.AddPurchase(new Product("1", "Product 1", 10), 10, 1, 0.2m, "Acme Inc.");
        customer1.AddPurchase(new Product("2", "Product 2", 20), 20, 2, 0.15m, "Acme Inc.");

        // Add sales to the company
        customer2.AddSelling(new Product("1", "Product 1", 10), 10, 1, 0.2m, "John Doe");
        customer2.AddSelling(new Product("2", "Product 2", 20), 20, 2, 0.15m, "John Doe");

        // Calculate totals
        decimal totalPurchases = customer1.Purchases.Sum(purchase => purchase.TotalPrice());
        decimal totalSales = customer2.Sellings.Sum(selling => selling.TotalPrice());

        // data consistency
        bool consistent = totalPurchases == totalSales;

        // results
        Console.WriteLine($"Total de compras para {customer1.Name}: {totalPurchases}");
        Console.WriteLine($"Total de vendas para {customer2.Name}: {totalSales}");
        Console.WriteLine($"Consistência dos dados: {(consistent ? "Consistente" : "Inconsistente")}");
    }
}
