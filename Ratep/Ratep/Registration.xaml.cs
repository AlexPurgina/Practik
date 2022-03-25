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

namespace Ratep
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        User user;
        public Registration()
        {
            InitializeComponent();
        }

        private void Autu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user_ = new User()
                {
                    Login = login.Text,
                    Password = Cipher.Encrypt(password.Password)
                };
                BD.practik1282.User.Add(user_);
                BD.practik1282.SaveChanges();
                MessageBox.Show("Пользователь зарегистрирован", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка  при попытке соединения с базой данных. Повторите попытку позже.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
