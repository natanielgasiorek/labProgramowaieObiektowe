using DevExpress.Xpf.Core;
using System;
using Sklep_Zoologiczny.BazaDanych;
using Sklep_Zoologiczny.Serwisy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Sklep_Zoologiczny.Widoki
{
    /// <summary>
    /// Interaction logic for Usuwanie_producenta.xaml
    /// </summary>
    public partial class Usuwanie_producenta : ThemedWindow
    {
        SklepEntities dbContext = new SklepEntities();

        public Usuwanie_producenta()
        {
            InitializeComponent();
            ComboBox_Producent.ItemsSource = dbContext.Producenci.ToList();
        }


        private void Remove()
        {
            var nazwa_producenta_przyjscie = ComboBox_Producent.SelectedItem as Producenci;
            var producent = dbContext.Producenci.Find(nazwa_producenta_przyjscie.ID_Producenta);
            dbContext.Producenci.Remove(producent);
            dbContext.SaveChanges();
        }

        private void Zapisz_usuwanie_producenta_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}
