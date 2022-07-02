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
    /// Interaction logic for Edytowanie_podkatgorii.xaml
    /// </summary>
    public partial class Edytowanie_podkatgorii : ThemedWindow
    {
        PodkategoriaSerwis podkategoriaSerwis = new PodkategoriaSerwis();

        private int PodkategoriaID { get; set; }

        public Edytowanie_podkatgorii()
        {
            InitializeComponent();
            ComboBox_wybierz_podkategorie.ItemsSource = podkategoriaSerwis.GetAll();
        }

        private void Edit()
        {
            Podkategorie podkategoria = new Podkategorie()
            {
                ID_Podkategorii = PodkategoriaID,
                Nazwa_podkategorii = Wpisz_nowa_nazwe_podkategorii.Text
            };
            podkategoriaSerwis.Edit(podkategoria);
        }

        private void ComboBox_wybierz_podkategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedValue = ComboBox_wybierz_podkategorie.SelectedValue as Podkategorie;

            if (selectedValue != null)
            {

                Wpisz_nowa_nazwe_podkategorii.Text = selectedValue.Nazwa_podkategorii;
                PodkategoriaID = selectedValue.ID_Podkategorii;
            }
        }

        private void Zapisz_edytowanie_nazwy_podkategorii_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            this.Close();
        }
    }
}
