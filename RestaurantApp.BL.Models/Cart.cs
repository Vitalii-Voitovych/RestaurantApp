using System.Collections;

namespace RestaurantApp.BL.Models
{
    public class Cart : IEnumerable
    {
        private readonly Dictionary<Dish, int> dishes;
        public int Count => dishes.Count;
        public decimal Price => GetAll().Sum(d => d.Price);
        public Cart()
        {
            dishes = new Dictionary<Dish, int>();
        }

        public void Clear() => dishes.Clear();

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

        public IEnumerator GetEnumerator()
        {
            foreach (var dish in dishes.Keys)
            {
                for (int i = 0; i < dishes[dish]; i++)
                {
                    yield return dish;
                }
            }
        }
        public List<Dish> GetAll()
        {
            var list = new List<Dish>();
            foreach (Dish dish in this)
            {
                list.Add(dish);
            }
            return list;
        }

    }
}
