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
    /// Логика взаимодействия для Mat_card.xaml
    /// </summary>
    public partial class Mat_card : Window
    {
        public Mat_card()
        {
            InitializeComponent();
            dgMat_card.ItemsSource = BD.practik1282.Material_card.ToList();

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MaimMenu menu = new MaimMenu();
            this.Close();
            menu.Show();
        }

      
        private void nomensh_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nomensh.Text == "Поиск по изделию...")
            {
                nomensh.Text = "";
                nomensh.Foreground = Brushes.Black;
            }
        }

        private void nomensh_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nomensh.Text == "")
            {
                nomensh.Text = "Поиск по изделию...";
                nomensh.Foreground = Brushes.Gray;
            }
        }

        private void nomensh_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nomensh.Text != "")
                dgMat_card.ItemsSource = BD.practik1282.Nomencloture.Where(m => m.Name_product.ToLower().Contains(nomensh.Text.ToLower())).ToList();
            else
                dgMat_card.ItemsSource = BD.practik1282.Nomencloture.ToList();

        }

        private void matersh_GotFocus(object sender, RoutedEventArgs e)
        {
            if (matersh.Text == "Поиск по материалу...")
            {
                matersh.Text = "";
                matersh.Foreground = Brushes.Black;
            }
        }

        private void matersh_LostFocus(object sender, RoutedEventArgs e)
        {
            if (matersh.Text == "")
            {
                matersh.Text = "Поиск по материалу...";
                matersh.Foreground = Brushes.Gray;
            }
        }

        private void matersh_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (matersh.Text != "")
                dgMat_card.ItemsSource = BD.practik1282.Material.Where(m => m.Name_material.ToLower().Contains(matersh.Text.ToLower())).ToList();
            else
                dgMat_card.ItemsSource = BD.practik1282.Material.ToList();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddMat_card addMat = new AddMat_card();
            this.Close();
            addMat.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
                if (dgMat_card.SelectedItems.Count > 0)
                {
                    Material_card mat_Card = dgMat_card.SelectedItem as Material_card;
                    AddMat_card addMat = new AddMat_card(mat_Card);
                    this.Close();
                    addMat.Show();
                }
                else
                MessageBox.Show("Выберите строку для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Delite_Click(object sender, RoutedEventArgs e)
        {
            Material_card m = dgMat_card.SelectedItem as Material_card;
            int id = m.Num_card;
            try
            {
                if (dgMat_card.SelectedItems.Count > 0)
                {
                    var dael = BD.practik1282.Material_card.Where(x => x.Num_card == id).FirstOrDefault();
                    BD.practik1282.DeleteMaterial_card(id);
                    MessageBox.Show("Запись успешно удалена!", "Внимане", MessageBoxButton.OK, MessageBoxImage.Information);
                    dgMat_card.ItemsSource = BD.practik1282.Material_card.ToList();
                }
                else MessageBox.Show("Выберите строку для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     

        }

    }
}
