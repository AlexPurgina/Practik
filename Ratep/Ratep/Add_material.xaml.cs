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
    /// Логика взаимодействия для Add_material.xaml
    /// </summary>
    public partial class Add_material : Window
    {
        Material material1;
        public Add_material()
        {
            InitializeComponent();
            unit.ItemsSource = BD.practik1282.OKEI.ToList();
            grop.ItemsSource = BD.practik1282.Rationing_groups.ToList();
            material1 = new Material();
        }
        public Add_material(Material material)
        {
            InitializeComponent();
            material1 = material;
            unit.ItemsSource = BD.practik1282.OKEI.ToList();
            grop.ItemsSource = BD.practik1282.Rationing_groups.ToList();


        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MaterialWindow material = new MaterialWindow();
            this.Close();
            material.Show();
         
        }

 

        private void Cansel_Click(object sender, RoutedEventArgs e)
        {
            MaterialWindow material = new MaterialWindow();
            this.Close();
            material.Show();
            BD.practik1282 = new Practik1282Entities();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (material1.Num_material == 0)
                {
                    BD.practik1282.Material.Add(material1);
                    MessageBox.Show("Материал добавлен", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else { 
                MessageBox.Show("Материал изменен", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                BD.practik1282.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = material1;
        }

        private void btnup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                diametr.Text = $"{Int32.Parse(diametr.Text) + 1}";
            }
            catch (Exception) { }
        }

        private void btndown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int amount = Int32.Parse(diametr.Text);
                if (amount > 1)
                    diametr.Text = $"{amount - 1}";
            }
            catch (Exception) { }
        }
        private void btnup1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                thick.Text = $"{Int32.Parse(thick.Text) + 1}";
            }
            catch (Exception) { }
        }

        private void btndown1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int amount = Int32.Parse(thick.Text);
                if (amount > 1)
                    thick.Text = $"{amount - 1}";
            }
            catch (Exception) { }
        }
        private void btnup2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                width.Text = $"{Int32.Parse(width.Text) + 1}";
            }
            catch (Exception) { }
        }

        private void btndown2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int amount = Int32.Parse(width.Text);
                if (amount > 1)
                    width.Text = $"{amount - 1}";
            }
            catch (Exception) { }
        }
        private void btnup3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                length.Text = $"{Int32.Parse(length.Text) + 1}";
            }
            catch (Exception) { }
        }

        private void btndown3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int amount = Int32.Parse(length.Text);
                if (amount > 1)
                    length.Text = $"{amount - 1}";
            }
            catch (Exception) { }
        }

    }
}
