using RestaurantApp.BL.Models;

namespace RestaurantApp.UI.Forms
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(Customer customer) : this()
        {
            Customer = customer;
            textBoxFirstName.Text = Customer.FirstName;
            textBoxLastName.Text = Customer.LastName;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Customer ??= new Customer();
            Customer.FirstName = textBoxFirstName.Text;
            Customer.LastName = textBoxLastName.Text;
            Close();
        }
    }
}
