using RestaurantApp.BL.Controller;
using RestaurantApp.BL.EF;

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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
