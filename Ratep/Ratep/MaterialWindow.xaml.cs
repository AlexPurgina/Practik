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
    /// Логика взаимодействия для Material.xaml
    /// </summary>
    public partial class MaterialWindow : Window
    {
       
        public MaterialWindow()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MaimMenu menu = new MaimMenu();
            AddMat_card.miscSeance = false;
            this.Close();
            menu.Show();
        }


        private void unitsh_GotFocus(object sender, RoutedEventArgs e)
        {
            if (unitsh.Text == "Поиск по единицам измерения...")
            {
                unitsh.Text = "";
                unitsh.Foreground = Brushes.Black;
            }
        }

        private void unitsh_LostFocus(object sender, RoutedEventArgs e)
        {
            if (unitsh.Text == "")
            {
                unitsh.Text = "Поиск по единицам измерения...";
                unitsh.Foreground = Brushes.Gray;
            }
        }

        private void unitsh_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (unitsh.Text != "")
                dgMaterial.ItemsSource = BD.practik1282.Material.Where(m => m.OKEI.Name_unit.ToLower().Contains(unitsh.Text.ToLower())).ToList();
            else
                dgMaterial.ItemsSource = BD.practik1282.Material.ToList();
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
                dgMaterial.ItemsSource = BD.practik1282.Material.Where(m => m.Name_material.ToLower().Contains(matersh.Text.ToLower())).ToList();
            else
                dgMaterial.ItemsSource = BD.practik1282.Material.ToList();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Add_material add_Material = new Add_material();
            this.Close();
            add_Material.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Material mater = dgMaterial.SelectedItem as Material;
            Add_material add_Material = new Add_material(mater);
            this.Close();
            add_Material.Show();
            dgMaterial.ItemsSource = null;
            dgMaterial.ItemsSource = BD.practik1282.Material.ToList();

        }

        private void Delite_Click(object sender, RoutedEventArgs e)
        {          
            Material m = dgMaterial.SelectedItem as Material;
            int id = m.Num_material;
            try
            {
                if (dgMaterial.SelectedItems.Count > 0)
                {
                    var dael = BD.practik1282.Material.Where(x => x.Num_material == id).FirstOrDefault();
                    BD.practik1282.DeleteMaterial(id);
                    MessageBox.Show("Запись успешно удалена!", "Внимане", MessageBoxButton.OK, MessageBoxImage.Information);
                    dgMaterial.ItemsSource = BD.practik1282.Material.ToList();
                }
                else MessageBox.Show("Выберите строку для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgMaterial.ItemsSource = BD.practik1282.Material.ToList();
        }
    }
 }
