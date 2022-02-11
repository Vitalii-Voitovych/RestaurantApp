namespace RestaurantApp.BL.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public DateTime PaymentDate { get; set; }
        public override string ToString()
        {
            return PaymentDate.ToString("HH:mm dd.MM.yyyy");
        }
    }
}
