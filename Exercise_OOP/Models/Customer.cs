namespace Exercise_OOP.Models
{
    public abstract class Customer
    {
        public string Name { get; }
        public string Email { get; }

        protected Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public abstract string GetIdentificationNumber();
    }

}
