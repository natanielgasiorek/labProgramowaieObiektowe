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
    /// Interaction logic for Usuwanie_podkategorii.xaml
    /// </summary>
    public partial class Usuwanie_podkategorii : ThemedWindow
    {
        PodkategoriaSerwis podkategoriaSerwis = new PodkategoriaSerwis();

        public Usuwanie_podkategorii()
        {
            InitializeComponent();
            ComboBox_Podkategoria.ItemsSource = podkategoriaSerwis.GetAll();
        }

        private void Remove()
        {
            var nazwa_podkategorii_przyjscie = ComboBox_Podkategoria.SelectedItem as Podkategorie;
            podkategoriaSerwis.Remove(nazwa_podkategorii_przyjscie.ID_Podkategorii);
        }

        private void Zapisz_usuwanie_podkategorii_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}
