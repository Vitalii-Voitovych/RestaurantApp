using RestaurantApp.BL.Models;
using RestaurantApp.BL.EF;
using System.Data;
using RestaurantApp.UI.Forms;

namespace RestaurantApp.UI
{
    public partial class MainForm : Form
    {
        private RestaurantAppContext context;
        private Cart cart;
        public MainForm()
        {
            InitializeComponent();
            context = new RestaurantAppContext();
        }

        private void DishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.DataGridForm<Dish>(context);
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                if (comboBoxTypeDish.SelectedItem is TypeDish type)
                {
                    listBoxMenu.DataSource =
                        context.Dishes.Where(d => d.TypeDishId == type.TypeDishId).OrderBy(d => d.Name).ToList();
                }
            }
        }

        private void TypeDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.DataGridForm<TypeDish>(context);
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                comboBoxTypeDish.DataSource = context.TypeDishes.ToList();
            }
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.DataGridForm<Customer>(context);
            form.Show();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.DataGridForm<Order>(context);
            form.Show();
        }

        private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.DataGridForm<Payment>(context);
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                comboBoxTypeDish.Invoke(() =>
                {
                    comboBoxTypeDish.DataSource = context.TypeDishes.ToList();
                });
                listBoxMenu.Invoke(() =>
                {
                    if (comboBoxTypeDish.SelectedItem is TypeDish type)
                    {
                        listBoxMenu.DataSource =
                            context.Dishes.Where(d => d.TypeDishId == type.TypeDishId).OrderBy(d => d.Name).ToList();
                    }
                });
            });
            var customerForm = new LoginForm(context);
            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                if (customerForm.IsLoggedIn)
                {
                    labelCustomer.Text = $"{customerForm.GetCustomer()}";
                }
                else
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
            cart = new Cart();
        }

        private void ComboBoxTypeDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeDish.SelectedItem is TypeDish type)
            {
                listBoxMenu.DataSource =
                    context.Dishes.Where(d => d.TypeDishId == type.TypeDishId).ToList();
            }
        }

        // TODO: Додавання у кошик
        private void ListBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // TODO: Видалення з кошика
    }
}
