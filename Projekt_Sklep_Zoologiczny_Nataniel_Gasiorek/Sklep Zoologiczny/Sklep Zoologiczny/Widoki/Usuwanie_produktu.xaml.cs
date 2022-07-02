using DevExpress.Xpf.Core;
using Sklep_Zoologiczny.BazaDanych;
using Sklep_Zoologiczny.Serwisy;
using System;
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
    /// Interaction logic for Usuwanie_produktu.xaml
    /// </summary>
    public partial class Usuwanie_produktu : ThemedWindow
    {
        ProduktSerwis produktSerwis = new ProduktSerwis();

        public Usuwanie_produktu()
        {
            InitializeComponent();
            ComboBox_usun_produkt.ItemsSource = produktSerwis.GetAll();
        }

        private void Remove()
        {
            var nazwa_produktu_przyjscie = ComboBox_usun_produkt.SelectedItem as Produkty;
            produktSerwis.Remove(nazwa_produktu_przyjscie.ID_Produktu);
        }

        private void Zapisz_usuwanie_produktu_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}
