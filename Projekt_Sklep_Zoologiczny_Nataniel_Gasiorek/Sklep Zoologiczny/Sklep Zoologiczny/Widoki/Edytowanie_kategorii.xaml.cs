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
    /// Interaction logic for Edytowanie_kategorii.xaml
    /// </summary>
    public partial class Edytowanie_kategorii : ThemedWindow
    {
        KategoriaSerwis kategoriaSerwis = new KategoriaSerwis();

        private int KategoriaID { get; set; }

        public Edytowanie_kategorii()
        {
            InitializeComponent();
            ComboBox_wybierz_kategorie.ItemsSource = kategoriaSerwis.GetAll();
        }

        private void Edit()
        {
            Kategorie kategoria = new Kategorie()
            {
                ID_Kategorii = KategoriaID,
                Nazwa_kategorii = Wpisz_nowa_nazwe_kategorii.Text
            };
            kategoriaSerwis.Edit(kategoria);
        }

        private void ComboBox_wybierz_kategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedValue = ComboBox_wybierz_kategorie.SelectedValue as Kategorie;

            if (selectedValue != null)
            {

                Wpisz_nowa_nazwe_kategorii.Text = selectedValue.Nazwa_kategorii;
                KategoriaID = selectedValue.ID_Kategorii;
            }
        }


        private void Zapisz_edytowanie_nazwy_kategorii_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            this.Close();
        }
    }
}
