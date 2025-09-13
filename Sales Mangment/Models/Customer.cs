namespace Sales_Mangment.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreaditCardNumber { get; set; }


        public List<Sale> Sales { get; set; } = new List<Sale>();
    }
}