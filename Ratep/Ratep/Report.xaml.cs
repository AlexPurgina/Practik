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
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.Win32;
using System.Collections.ObjectModel;


namespace Ratep
{
    /// <summary>
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class Report : System.Windows.Window
    {
        ObservableCollection<Nomencloture> collection;
        ObservableCollection<Nomencloture> collectionprod;

        public Report()
        {
            InitializeComponent();
            product.ItemsSource = BD.practik1282.Nomencloture.ToList();
            collection = new ObservableCollection<Nomencloture>();
            collectionprod = new ObservableCollection<Nomencloture>();


        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MaimMenu menu = new MaimMenu();
            this.Close();
            menu.Show();
        }



        private void word_Click(object sender, RoutedEventArgs e)
        {
            Print(product.SelectedItem as Nomencloture);
        }
        async System.Threading.Tasks.Task Print(Nomencloture product)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить файл как...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "PDF документ (*.pdf)|*.pdf";
            if (savedialog.ShowDialog() == true)
            {
                await System.Threading.Tasks.Task.Run(() =>
                {
                    var word = new Word.Application();
                    var document = word.Documents.Open(Environment.CurrentDirectory + @"\Отчет.docx");
                    DateTime date = DateTime.Now;
                    try
                    {
                        document.Bookmarks["Дата"].Range.Text = date.ToShortDateString();
                        document.Bookmarks["ДецНомер"].Range.Text = product.Decimal_num;
                        document.Bookmarks["Изделие"].Range.Text = product.Name_product;
                        var table1 = document.Tables[1];
                        int row = 1;
                        foreach (var item in product.Material_card)
                        {
                            row++;
                            table1.Rows.Add();
                            table1.Cell(row, 2).Range.Text = item.Workshop.Name;
                            table1.Cell(row, 3).Range.Text = item.Workshop1.Name;
                            table1.Cell(row, 4).Range.Text = item.Consumer_workshop.ToString();
                            table1.Cell(row, 5).Range.Text = item.Material.Name_material.ToString();
                            table1.Cell(row, 6).Range.Text = item.Material.Stamp.Name.ToString();
                            table1.Cell(row, 7).Range.Text = item.Material.Profile.Name.ToString();
                            table1.Cell(row, 8).Range.Text = item.Material.Diametr.ToString() + " " + item.Material.Thick.ToString() + " " + item.Material.Width.ToString() + " " + item.Material.Length.ToString();
                            table1.Cell(row, 9).Range.Text = item.Material.OKEI.Name_unit.ToString();
                            table1.Cell(row, 10).Range.Text = item.Work_piece.Weight.ToString(); 
                            table1.Cell(row, 11).Range.Text = item.Work_piece.Quantity.ToString();
                        }

                        int T = table1.Rows.Count;
                        table1.Rows[T].Delete();
                        document.SaveAs2(savedialog.FileName, Word.WdSaveFormat.wdFormatPDF, Word.WdSaveOptions.wdDoNotSaveChanges);
                        document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                        word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                        word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                    }
                });
            }
        }

        

        private void dgRep_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void addpr_Click(object sender, RoutedEventArgs e)
        {
            collection.Clear();
            Nomencloture nomencloture = (product.SelectedItem as Nomencloture);
            dgRep.ItemsSource = BD.practik1282.Material_card.Where(m => m.Num_product == nomencloture.Num_product).ToList();
            

            collection.Add(BD.practik1282.Nomencloture.FirstOrDefault(n => n.Num_product == nomencloture.Num_product));
            collectionprod.Add(BD.practik1282.Nomencloture.FirstOrDefault(m => m.Num_product == nomencloture.Num_product));
        }
    }
}
