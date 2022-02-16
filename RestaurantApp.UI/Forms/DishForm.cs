using Microsoft.EntityFrameworkCore;
using RestaurantApp.BL.Models;

namespace RestaurantApp.UI.Forms
{
    public partial class DishForm : Form
    {
        public Dish Dish { get; private set; }
        public DishForm(DbSet<TypeDish> typeDishes)
        {
            InitializeComponent();
            comboBoxTypeDish.DataSource = typeDishes.ToList();
        }

        public DishForm(Dish dish, DbSet<TypeDish> typeDishes) : this(typeDishes)
        {
            Dish = dish;
            textBoxName.Text = Dish.Name;
            comboBoxTypeDish.SelectedItem = typeDishes.Single(t => t.TypeDishId == Dish.TypeDishId);
            numericUpDownKilocalories.Value = Convert.ToDecimal(Dish.Kilocalories);
            numericUpDownWeight.Value = Convert.ToDecimal(Dish.Weight);
            numericUpDownPrice.Value = Dish.Price;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Dish ??= new Dish();
            Dish.Name = textBoxName.Text;
            if (comboBoxTypeDish.SelectedItem is TypeDish type)
            {
                Dish.TypeDishId = type.TypeDishId;
            }
            Dish.Kilocalories = Convert.ToDouble(numericUpDownKilocalories.Value);
            Dish.Weight = Convert.ToDouble(numericUpDownWeight.Value);
            Dish.Price = numericUpDownPrice.Value;
            Close();
        }
    }
}
