using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Логика взаимодействия для OProg.xaml
    /// </summary>
    public partial class OProg : Window
    {
        public OProg()
        {
            InitializeComponent();
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        public string AssemblyCopyrigth
        {
            get
            {
                object[] atributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (atributes.Length == 0)
                    return "";
                return ((AssemblyCopyrightAttribute)atributes[0]).Copyright;
            }
        }
        public string AssemblyCompany
        {
            get
            {
                object[] atributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (atributes.Length == 0)
                    return "";
                return ((AssemblyCompanyAttribute)atributes[0]).Company;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbNameProd.Text = AssemblyProduct;
            tbVersProd.Text = $"Версия {AssemblyVersion}";
            tbCopyProd.Text = AssemblyCopyrigth;
            tbCompProd.Text = AssemblyCompany;
            txtbDescProd.Text = AssemblyDescription;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MaimMenu menu = new MaimMenu();
            this.Close();
            menu.Show();
        }
    }
}
