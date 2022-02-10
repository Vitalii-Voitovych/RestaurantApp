namespace RestaurantApp.BL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int TypeProductId { get; set; }
        public TypeProduct TypeProduct { get; set; }
        public double Calories { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
