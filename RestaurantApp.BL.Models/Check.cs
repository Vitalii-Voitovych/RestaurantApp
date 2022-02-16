using System.Text;

namespace RestaurantApp.BL.Models
{
    public class Check
    {
        private readonly string text;
        public Check(Order order, Customer customer, Cart cart, DateTime paymentDate)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Чек");
            sb.AppendLine("============================");
            sb.AppendLine($"Столик №{order.TableNumber}");
            sb.AppendLine($"{customer}");
            sb.AppendLine("============================");
            foreach (var dish in cart.GetAll())
            {
                sb.AppendLine($"{dish.Name} : ${dish.Price}");
            }
            sb.AppendLine("============================");
            sb.AppendLine($"Сума : ${cart.Price}");
            sb.AppendLine($"Дата оплати: " + paymentDate.ToString("HH:mm dd:MM:yyyy"));
            text = sb.ToString();
        }
        public override string ToString()
        {
            return text;
        }
    }
}
