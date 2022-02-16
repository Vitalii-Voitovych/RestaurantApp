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

        private void Add(T entity)
        {
            controller.AddRecord(entity);
            dataGridView1.Update();
        }

        private int Edit(Form form)
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                controller.Update();
                dataGridView1.Update();
                return 1;
            }
            return 0;
        }

        private int Remove(object id)
        {
            var entity = controller.GetOne(id);
            controller.RemoveRecord(entity);
            dataGridView1.Update();
            return 1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            switch (typeof(T).Name)
            {
                case "TypeDish":
                    var typeDishForm = new TypeDishForm();
                    if (typeDishForm.ShowDialog() == DialogResult.OK)
                        Add(typeDishForm.TypeDish as T);
                    break;
                case "Dish":
                    var dishForm = new DishForm(controller.Db.TypeDishes);
                    if (dishForm.ShowDialog() == DialogResult.OK)
                        Add(dishForm.Dish as T);
                    break;
                default:
                    MessageBox.Show("Не можна додавати до цієї таблиці", "Попередження",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            object a = typeof(T).Name switch
            {
                "Customer" => Remove(id),
                "TypeDish" => Remove(id),
                "Dish" => Remove(id),
                _ => MessageBox.Show("Не можна додавати до цієї таблиці", "Попередження", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning),
            };
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            var entity = controller.GetOne(id);

            object a = typeof(T).Name switch
            {
                "Customer" => Edit(new CustomerForm(entity as Customer)),
                "TypeDish" => Edit(new TypeDishForm(entity as TypeDish)),
                "Dish" => Edit(new DishForm(entity as Dish, controller.Db.TypeDishes)),
                _ => MessageBox.Show("Не можна додавати до цієї таблиці", "Попередження",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning),
            };
        }
    }
}
