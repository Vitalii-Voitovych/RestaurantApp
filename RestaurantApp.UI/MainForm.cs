using RestaurantApp.BL.Models;
using RestaurantApp.BL.EF;
using System.Data;
using RestaurantApp.UI.Forms;
using RestaurantApp.BL.Controller;

namespace RestaurantApp.UI
{
    public partial class MainForm : Form
    {
        private RestaurantAppContext context;
        private Cart cart;
        private Customer customer;
        private Order order;
        public MainForm()
        {
            InitializeComponent();
            context = new RestaurantAppContext();
            cart = new Cart();
        }

        private void DishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DataGridForm<Dish>(context);
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                if (comboBoxTypeDish.SelectedItem is TypeDish type)
                {
                    listBoxMenu.Items.Clear();
                    listBoxMenu.Items.AddRange(context.Dishes.Where(d => d.TypeDishId == type.TypeDishId).OrderBy(d => d.Name).ToArray());
                }
            }
        }

        private void TypeDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DataGridForm<TypeDish>(context);
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                comboBoxTypeDish.Items.Clear();
                comboBoxTypeDish.Items.AddRange(context.TypeDishes.ToArray());
            }
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DataGridForm<Customer>(context);
            form.Show();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DataGridForm<Order>(context);
            form.Show();
        }

        private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DataGridForm<Payment>(context);
            form.Show();
        }

        private void LoadMenu()
        {
            comboBoxTypeDish.Invoke(() =>
            {
                comboBoxTypeDish.Items.AddRange(context.TypeDishes.ToArray());
            });
            listBoxMenu.Invoke(() =>
            {
                if (comboBoxTypeDish.SelectedItem is not TypeDish)
                {
                    listBoxMenu.Items.AddRange(context.Dishes.OrderBy(d => d.Name).ToArray());
                }
            });
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(context);
            loginForm.ShowDialog();
            await Task.Run(() => LoadMenu());
            if (loginForm.DialogResult == DialogResult.OK)
            {
                if (loginForm.IsLoggedIn)
                {
                    customer = loginForm.GetCustomer();
                    labelCustomer.Text = $"{customer}";

                }
            }
            else
            {
                Close();
            }
        }

        private void ComboBoxTypeDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeDish.SelectedItem is TypeDish type)
            {
                listBoxMenu.Items.Clear();
                listBoxMenu.Items.AddRange(context.Dishes.Where(d => d.TypeDishId == type.TypeDishId).ToArray());
            }
        }

        private void UpdatePrice()
        {
            label2.Text = $"До оплати : ${cart.Price}";
        }

        private void ListBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem is Dish dish)
            {
                if (cart.Count == 0)
                {
                    order = new Order()
                    {
                        CustomerId = customer.CustomerId,
                        TableNumber = new Random().Next(1, 7),
                        OrderDate = DateTime.Now
                    };
                    labelTableNumber.Text = $"Столик №{order.TableNumber}";
                }
                cart.AddDish(dish);
                listBoxCart.Items.Add(dish);
                UpdatePrice();
            }
        }

        private void ListBoxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItem is Dish dish)
            {
                cart.RemoveDish(dish);
                listBoxCart.Items.Remove(dish);
                UpdatePrice();
                if (cart.Count == 0)
                {
                    order = null;
                    labelTableNumber.Text = $"Столик №";
                }
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (order != null)
            {
                var orderController = new EntityController<Order>(context);
                orderController.AddRecord(order);
                var paymentController = new EntityController<Payment>(context);
                foreach (Dish dish in cart)
                {
                    var payment = new Payment()
                    {
                        OrderId = order.OrderId,
                        DishId = dish.DishId,
                        PaymentDate = DateTime.Now,
                    };
                    paymentController.AddRecord(payment);
                }
                cart.Clear();
                listBoxCart.Items.Clear();
                UpdatePrice();
                order = null;
            }
            else
            {
                MessageBox.Show("Ви не вибрали страви!", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
