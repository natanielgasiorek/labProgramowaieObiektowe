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
    /// Interaction logic for Dodawanie_podkategorii.xaml
    /// </summary>
    public partial class Dodawanie_podkategorii : ThemedWindow
    {
        PodkategoriaSerwis podkategoriaSerwis = new PodkategoriaSerwis();

        public Dodawanie_podkategorii()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Podkategorie podkategoria = new Podkategorie()
            {
                Nazwa_podkategorii = Wpisz_nazwe_podkategorii.Text,
            };
            podkategoriaSerwis.Add(podkategoria);
        }

        private void Zapisz_nazwe_podkategorii_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
