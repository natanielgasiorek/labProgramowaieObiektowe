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
    /// Interaction logic for Edytowanie_produktu.xaml
    /// </summary>
    public partial class Edytowanie_produktu : ThemedWindow
    {
        SklepEntities dbContext = new SklepEntities();
        ProduktSerwis produktSerwis = new ProduktSerwis();
        KategoriaSerwis kategoriaSerwis = new KategoriaSerwis();
        PodkategoriaSerwis podkategoriaSerwis = new PodkategoriaSerwis();
        ProducentSerwis producentSerwis = new ProducentSerwis();

        public Edytowanie_produktu()
        {
            InitializeComponent();
            SetCheckBoxes();

            Zapisz_edytowanie_produktu.IsEnabled = false;
        }

        private void SetCheckBoxes()
        {
            ComboBox_wybierz_produkt.ItemsSource = produktSerwis.GetAll();
            ComboBox_wpisz_nazwe_kategorii.ItemsSource = kategoriaSerwis.GetAll();
            ComboBox_wpisz_nazwe_podkategorii.ItemsSource = podkategoriaSerwis.GetAll();
            ComboBox_wpisz_nazwe_producenta.ItemsSource = producentSerwis.GetAll();

        }

        private void Edit()
        {
            string cena_przyjscie = Wpisz_cene_produktu.Text;
            var cena = decimal.Parse(cena_przyjscie);

            

            var kategoria_produktu_przyjscie = ComboBox_wpisz_nazwe_kategorii.SelectedItem as Kategorie;
            var podkategoria_produktu_przyjscie = ComboBox_wpisz_nazwe_podkategorii.SelectedItem as Podkategorie;
            var nazwa_producenta_przyjscie = ComboBox_wpisz_nazwe_producenta.SelectedItem as Producenci;

            

            var nazwa_produktu_przyjscie = ComboBox_wybierz_produkt.SelectedItem as Produkty;

            Produkty produkt = new Produkty()
            {
                ID_Produktu = nazwa_produktu_przyjscie.ID_Produktu,
                Nazwa_produktu = Wpisz_nazwe_produktu.Text,
                
                ID_Kategorii = kategoria_produktu_przyjscie.ID_Kategorii,
                ID_Podkategorii = podkategoria_produktu_przyjscie.ID_Podkategorii,
                ID_Producenta = nazwa_producenta_przyjscie.ID_Producenta,
                Cena = cena,
                
            };

            produktSerwis.Edit(produkt);
        }

        private void Zapisz_edytowanie_produktu_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            this.Close();
        }
    }
}
