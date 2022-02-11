using RestaurantApp.BL.Models;
using RestaurantApp.BL.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.UI
{
    public partial class MainForm : Form
    {
        private RestaurantAppContext context;
        public MainForm()
        {
            InitializeComponent();
            context = new RestaurantAppContext();
        }

        private void DishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.DataGridForm<Dish>(context);
            form.Show();
        }

        private void TypeDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Forms.DataGridForm<TypeDish>(context);
            form.Show();
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
                    comboBoxTypeDish.DataSource = context.TypeDishes.ToArray();
                });
                listBoxMenu.Invoke(() =>
                {
                    listBoxMenu.Items.AddRange(context.Dishes.ToArray());
                });
            });
        }

        // TODO: Вибір по категоріям
    }
}
