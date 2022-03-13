namespace Customer1.Model
{
    public class Customer
    {
        public  long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string cellphone { get; set; } = string.Empty;
        public double? totalAmount { get; set; }

    }
}
