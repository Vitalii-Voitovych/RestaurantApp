using RestaurantApp.BL.Controller;
using RestaurantApp.BL.EF;
using RestaurantApp.BL.Models;

namespace RestaurantApp.UI.Forms
{
    public partial class DataGridForm<T> : Form
        where T : class
    {
        private readonly EntityController<T> controller;

        public DataGridForm(RestaurantAppContext context)
        {
            InitializeComponent();
            controller = new EntityController<T>(context);
            dataGridView1.DataSource = controller.GetAll();
        }
        // TODO: Рефакторинг
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            switch (typeof(T).Name)
            {
                case "TypeDish":
                    var typeDishForm = new TypeDishForm();
                    if (typeDishForm.ShowDialog() == DialogResult.OK)
                    {
                        controller.AddRecord(typeDishForm.TypeDish as T);
                        dataGridView1.Update();
                    }
                    break;
                case "Dish":
                    var dishForm = new DishForm(controller.Db.TypeDishes);
                    if (dishForm.ShowDialog() == DialogResult.OK)
                    {
                        controller.AddRecord(dishForm.Dish as T);
                        dataGridView1.Update();
                    }
                    break;
                default:
                    MessageBox.Show("Не можна додавати до цієї таблиці",
                                    "Попередження",
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                    break;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            switch (typeof(T).Name)
            {
                case "Customer":
                    var customer = controller.GetOne(id);
                    controller.RemoveRecord(customer);
                    dataGridView1.Update();
                    break;
                case "TypeDish":
                    var typeDish = controller.GetOne(id);
                    controller.RemoveRecord(typeDish);
                    dataGridView1.Update();
                    break;
                case "Dish":
                    var dish = controller.GetOne(id);
                    controller.RemoveRecord(dish);
                    dataGridView1.Update();
                    break;
                default:
                    MessageBox.Show("Не можна додавати до цієї таблиці",
                                    "Попередження",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    break;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            switch (typeof(T).Name)
            {
                case "Customer":
                    var customer = controller.GetOne(id);
                    var customerForm = new CustomerForm(customer as Customer);
                    if (customerForm.ShowDialog() == DialogResult.OK)
                    {
                        controller.Update();
                        dataGridView1.Update();
                    }
                    break;
                case "TypeDish":
                    var typeDish = controller.GetOne(id);
                    var typeDishForm = new TypeDishForm(typeDish as TypeDish);
                    if (typeDishForm.ShowDialog() == DialogResult.OK)
                    {
                        controller.Update();
                        dataGridView1.Update();
                    }
                    break;
                case "Dish":
                    var dish = controller.GetOne(id);
                    var dishForm = new DishForm(dish as Dish, controller.Db.TypeDishes);
                    if (dishForm.ShowDialog() == DialogResult.OK)
                    {
                        controller.Update();
                        dataGridView1.Update();
                    }
                    break;
                default:
                    MessageBox.Show("Не можна додавати до цієї таблиці",
                                    "Попередження",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
