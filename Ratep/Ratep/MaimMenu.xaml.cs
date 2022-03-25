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
using Ratep.Helps;

namespace Ratep
{
    /// <summary>
    /// Логика взаимодействия для MaimMenu.xaml
    /// </summary>
    public partial class MaimMenu : Window
    {
        public MaimMenu()
        {
            InitializeComponent();
        }

        private void btnMat_card_Click(object sender, RoutedEventArgs e)
        {
            Mat_card card = new Mat_card();
            this.Close();
            card.Show();
        }

        private void btnMaterial_Click(object sender, RoutedEventArgs e)
        {
            MaterialWindow material = new MaterialWindow();
            this.Close();
            material.Show();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            Report report = new Report();
            this.Close();
            report.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void inf_Click(object sender, RoutedEventArgs e)
        {
            OProg oProg = new OProg();
            this.Close();
            oProg.Show();

        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            this.Close();
            help.Show();
        }
    }
}
