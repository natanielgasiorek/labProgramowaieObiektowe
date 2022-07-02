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
    /// Interaction logic for Dowanie_produktu.xaml
    /// </summary>
    public partial class Dowanie_produktu : ThemedWindow
    {
        SklepEntities dbContext = new SklepEntities();
        ProduktSerwis produktSerwis = new ProduktSerwis();
        KategoriaSerwis kategoriaSerwis = new KategoriaSerwis();
        PodkategoriaSerwis podkategoriaSerwis = new PodkategoriaSerwis();
        ProducentSerwis producentSerwis = new ProducentSerwis();

        public Dowanie_produktu()
        {
            InitializeComponent();
            SetCheckBoxes();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SetCheckBoxes()
        {
            ComboBox_wpisz_nazwe_kategorii.ItemsSource = kategoriaSerwis.GetAll();
            ComboBox_wpisz_nazwe_podkategorii.ItemsSource = podkategoriaSerwis.GetAll();
            ComboBox_wpisz_nazwe_producenta.ItemsSource = producentSerwis.GetAll();
           
        }

        private void Save()
        {
            string cena_przyjscie = Wpisz_cene_produktu.Text;
            var cena = decimal.Parse(cena_przyjscie);

            

            var kategoria_produktu_przyjscie = ComboBox_wpisz_nazwe_kategorii.SelectedItem as Kategorie;
            var podkategoria_produktu_przyjscie = ComboBox_wpisz_nazwe_podkategorii.SelectedItem as Podkategorie;

            var nazwa_producenta_przyjscie = ComboBox_wpisz_nazwe_producenta.SelectedItem as Producenci;

           

            Produkty produkt = new Produkty()
            {
                Nazwa_produktu = Wpisz_nazwe_produktu.Text,
                
                ID_Kategorii = kategoria_produktu_przyjscie.ID_Kategorii,
                ID_Podkategorii = podkategoria_produktu_przyjscie.ID_Podkategorii,
                
                ID_Producenta = nazwa_producenta_przyjscie.ID_Producenta,
                Cena = cena,
                
                
            };

            produktSerwis.Add(produkt);
        }

        private void Zapisz_dodawanie_produktu_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
