namespace RestaurantApp.BL.Models
{
    public class TypeProduct
    {
        public int TypeProductId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
