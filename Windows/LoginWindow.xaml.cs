using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToursApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowLogin.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private int countTry;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            countTry++;
            if (string.IsNullOrWhiteSpace(UserLoginTextBox.Text))
            {
                MessageBox.Show("Не введен логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(UserPasswordBox.Password))
                {
                    MessageBox.Show("Не введен пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (User.CheckLogin(UserLoginTextBox.Text))
                {
                    if (User.CheckPassword(UserLoginTextBox.Text, UserPasswordBox.Password))
                    {
                        User.Name = UserLoginTextBox.Text;
                        var mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверно введен пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неверно введен логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
