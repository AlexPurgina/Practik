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
using Ratep.Properties;

namespace Ratep.Helps
{
    /// <summary>
    /// Логика взаимодействия для Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        Page[] pages;
        int i = 0;
        public Help()
        {
            InitializeComponent();
            HelpAvtoreg helpAvtoreg = new HelpAvtoreg(HelpFrame);
            HelpFrame.Navigate(helpAvtoreg);

            pages = new Page[] { new HelpAvtoreg(HelpFrame), new HelpMenu(), new HelpMat_card(), new HelpAddMat_card(), new HelpMater(), new HelpAddMater(), new HelpReport(),new HelpProg()};

            HelpFrame.Navigate(pages[i]);
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            i++;
            i = i % pages.Length;
            HelpFrame.Navigate(pages[i]);
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                i--;
                i = i % pages.Length;
                HelpFrame.Navigate(pages[i]);
            }
            catch (Exception)
            {
                MaimMenu menu = new MaimMenu();
                this.Close();
                menu.Show();
            }
        }
    }
}
