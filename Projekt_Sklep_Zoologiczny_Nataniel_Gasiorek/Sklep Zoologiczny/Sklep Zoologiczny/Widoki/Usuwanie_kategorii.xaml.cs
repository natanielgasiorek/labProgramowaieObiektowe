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
    /// Interaction logic for Usuwanie_kategorii.xaml
    /// </summary>
    public partial class Usuwanie_kategorii : ThemedWindow
    {
        KategoriaSerwis kategoriaSerwis = new KategoriaSerwis();

        public Usuwanie_kategorii()
        {
            InitializeComponent();
            ComboBox_Kategoria.ItemsSource = kategoriaSerwis.GetAll();
        }

        private void Remove()
        {
            var nazwa_kategorii_przyjscie = ComboBox_Kategoria.SelectedItem as Kategorie;
            kategoriaSerwis.Remove(nazwa_kategorii_przyjscie.ID_Kategorii);
        }

        private void Zapisz_usuwanie_kategorii_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}
