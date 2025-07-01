using RestaurantLibrary;
using RestaurantLibrary.Models;
using RestaurantLibrary.Models.HumanChildClasses;
using System.Drawing.Text;

namespace RestaurantAppUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                LoginModel model = new LoginModel(LoginUsernameField.Text, LoginPasswordField.Text);
                GlobalConfig.InitializeConnections(DatabaseType.Sql);
                CustomerModel CustomerInfo = GlobalConfig.Connection.LoginChecking(model);
                if (CustomerInfo != null)
                {
                    MessageBox.Show($"Hello - {CustomerInfo.Username}");
                }
                else
                {
                    MessageBox.Show("Something's wrong.... on your part");
                }
            }
            else
            {
                MessageBox.Show("Please fill the left out field");
            }
        }
        private bool ValidateForm()
        {
            bool result = true;
            if (LoginUsernameField.Text.Length == 0)
            {
                result = false;
            }
            if (LoginPasswordField.Text.Length == 0)
            {
                result = false;
            }
            return result;
        }
    }
}
