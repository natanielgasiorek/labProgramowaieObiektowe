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
    /// Interaction logic for Dodawanie_kategorii.xaml
    /// </summary>
    public partial class Dodawanie_kategorii : ThemedWindow
    {
        KategoriaSerwis kategoriaSerwis = new KategoriaSerwis();

        public Dodawanie_kategorii()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Kategorie kategoria = new Kategorie()
            {
                Nazwa_kategorii = Wpisz_nazwe_kategorii.Text,
            };
            kategoriaSerwis.Add(kategoria);
        }

        private void Zapisz_nazwe_kategorii_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();

        }
    }
}
