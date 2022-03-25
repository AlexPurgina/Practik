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
    /// Логика взаимодействия для AddMat_card.xaml
    /// </summary>
    public partial class AddMat_card : Window
    {
        public static Boolean miscSeance = false;
        Material_card material_Card1;
  
        public AddMat_card()
        {
            InitializeComponent();
            product.ItemsSource = BD.practik1282.Nomencloture.ToList();
            name.ItemsSource = BD.practik1282.Material.ToList();
            workshop.ItemsSource = BD.practik1282.Workshop.ToList();
            workshop1.ItemsSource = BD.practik1282.Workshop.ToList();
            weight.ItemsSource = BD.practik1282.Work_piece.ToList();
            work_piece_qu.ItemsSource = BD.practik1282.Work_piece.ToList();
            material_Card1 = new Material_card();
        }
        public AddMat_card(Material_card material_Card)
        {
            InitializeComponent();
            material_Card1 = material_Card;
            product.ItemsSource = BD.practik1282.Nomencloture.ToList();
            name.ItemsSource = BD.practik1282.Material.ToList();
            workshop.ItemsSource = BD.practik1282.Workshop.ToList();
            workshop1.ItemsSource = BD.practik1282.Workshop.ToList();
            weight.ItemsSource = BD.practik1282.Work_piece.ToList();
            work_piece_qu.ItemsSource = BD.practik1282.Work_piece.ToList();
        }
        private void btnMaterial_Click(object sender, RoutedEventArgs e)
        {
            MaterialWindow material = new MaterialWindow();
            miscSeance = true;
            this.Close();
            material.Show();
           
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Mat_card mat = new Mat_card();
            this.Close();
            mat.Show();
        }
       
        private void Cansel_Click(object sender, RoutedEventArgs e)
        {
            Mat_card mat = new Mat_card();
            this.Close();
            mat.Show();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (material_Card1.Num_card == 0)
                {
                    BD.practik1282.Material_card.Add(material_Card1);
                    MessageBox.Show("Материальная карта добавлена", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else { 
                MessageBox.Show("Материальная карта изменена", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information); }
                BD.practik1282.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
       {
            DataContext = material_Card1;
        }

        private void btnup1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                consumption_rate.Text = $"{Double.Parse(consumption_rate.Text) + 0.2}";
            }
            catch (Exception) { }
        }

        private void btndown1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double amount = double.Parse(consumption_rate.Text);
                if (amount > 0)
                    consumption_rate.Text = $"{amount - 0.2}";
            }
            catch (Exception) { }
        }
    }
}
