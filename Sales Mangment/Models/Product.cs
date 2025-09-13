namespace Sales_Mangment.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TotalSales { get; set; }
        public string Description { get; set; } = "No description";
        public List<Sale> Sales { get; set; } = new List<Sale>();
    }
}