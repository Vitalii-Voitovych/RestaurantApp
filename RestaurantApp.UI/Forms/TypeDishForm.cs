using RestaurantApp.BL.Models;

namespace RestaurantApp.UI.Forms
{
    public partial class TypeDishForm : Form
    {
        public TypeDish TypeDish { get; private set; }
        public TypeDishForm()
        {
            InitializeComponent();
        }
        public TypeDishForm(TypeDish typeProduct) : this()
        {
            TypeDish = typeProduct;
            textBoxName.Text = TypeDish.Name;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            TypeDish ??= new TypeDish();
            TypeDish.Name = textBoxName.Text;
            Close();
        }
    }
}
