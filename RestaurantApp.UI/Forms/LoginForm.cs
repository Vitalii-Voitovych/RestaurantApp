using RestaurantApp.BL.Controller;
using RestaurantApp.BL.EF;
using RestaurantApp.BL.Models;

namespace RestaurantApp.UI.Forms
{
    public partial class LoginForm : Form
    {
        private EntityController<Customer> controller;
        private Customer customer;

        public bool IsLoggedIn { get; private set; } = false;

        public LoginForm(RestaurantAppContext context)
        {
            InitializeComponent();
            controller = new EntityController<Customer>(context);
        }

        public Customer GetCustomer() => customer;

        private Customer ValidationCustomer(Customer customer)
        {
            return controller.GetAll().SingleOrDefault(
                    c => c.FirstName == customer.FirstName &&
                    c.LastName == customer.LastName);
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                customer = ValidationCustomer(customerForm.Customer);
                if (customer == null)
                {
                    controller.AddRecord(customer);
                }
                else
                {
                    MessageBox.Show("Такий клієнт вже зараєстровано", "Помилка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                customer = ValidationCustomer(customerForm.Customer);
                if (customer != null)
                {
                    IsLoggedIn = true;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Такого клієнта ще не зареєстровано", "Помилка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
