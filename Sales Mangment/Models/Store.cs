namespace Sales_Mangment.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        public string Name { get; set; }

        public List<Sale> Sales { get; set; } = new List<Sale>();
    }
}