namespace RestaurantApp.BL.Models
{
    public class Cart
    {
        private Dictionary<Dish, int> dishes;

        public Cart()
        {
            dishes = new Dictionary<Dish, int>();
        }

        public void AddDish(Dish dish)
        {
            if (dishes.TryGetValue(dish, out int count))
            {
                dishes[dish] = ++count;
            }
            else
            {
                dishes.Add(dish, 1);
            }
        }

        public void RemoveDish(Dish dish)
        {
            if (dishes.TryGetValue(dish, out int count))
            {
                dishes[dish] = --count;
                if (count == 0)
                {
                    dishes.Remove(dish);
                }
            }
        }
    }
}
