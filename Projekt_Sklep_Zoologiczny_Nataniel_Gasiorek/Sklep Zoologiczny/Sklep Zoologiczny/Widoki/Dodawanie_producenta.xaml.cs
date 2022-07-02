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
    /// Interaction logic for Dodawanie_producenta.xaml
    /// </summary>
    public partial class Dodawanie_producenta : ThemedWindow
    {
        ProducentSerwis producentSerwis = new ProducentSerwis();

        public Dodawanie_producenta()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Producenci producent = new Producenci()
            {
                Nazwa_producenta = Wpisz_nazwe_producenta.Text,
            };
            producentSerwis.Add(producent);
        }

        private void Zapisz_nazwe_producenta_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
