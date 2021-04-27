using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
namespace Reinsurance.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private void login_btn_click(object sender, RoutedEventArgs e)
        {
            string UserPassword = PassBox.Password.ToString();
            string Pass = "Password123";
            string email = Email.Text.ToString();
            string usremail = "sidney";

            if (UserPassword == Pass && email == usremail)
            {
                this.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("the Password is incorrect");
            }
        }

        private void PasswordView_Click(object sender, RoutedEventArgs e)
        {
            if (PassBox.Visibility == Visibility.Visible)
            {
                PasswordHolder.Text = PassBox.Password.ToString();
                PasswordHolder.Visibility = Visibility.Visible;
                PassBox.Visibility = Visibility.Collapsed;
            }

            else if (PasswordHolder.Visibility == Visibility.Visible)
            {
                PasswordHolder.Visibility = Visibility.Collapsed;
                PassBox.Visibility = Visibility.Visible;
            }
        }
                
    }
}
