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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ratep
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Autu_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    string password = Cipher.Encrypt(Password.Password);
                    User EnterUser = BD.practik1282.User.Where(u => u.Login == Login.Text && u.Password == password).FirstOrDefault();
                    if (EnterUser != null)
                    {
                        MaimMenu menu = new MaimMenu();
                        this.Close();
                        menu.Show();
                    }
                    else throw new Exception("Пользователь не найден");
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка  при попытке соединения с базой данных. Повторите попытку позже.","Ошибка",MessageBoxButton.OK,MessageBoxImage.Warning);
                }
            
        }



        private void tbreg_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();
            this.Show();
        }
    }
}
