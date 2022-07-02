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
    /// Interaction logic for Edytowanie_producenta.xaml
    /// </summary>
    public partial class Edytowanie_producenta : ThemedWindow
    {
        ProducentSerwis producentSerwis = new ProducentSerwis();
        private int ProducentID { get; set; }

        public Edytowanie_producenta()
        {
            InitializeComponent();
            ComboBox_wybierz_producenta.ItemsSource = producentSerwis.GetAll();
        }

        private void Edit()
        {
            Producenci producent = new Producenci()
            {
                ID_Producenta = ProducentID,
                Nazwa_producenta = Wpisz_nowa_nazwe_producenta.Text
            };
            producentSerwis.Edit(producent);
        }

        private void ComboBox_wybierz_producenta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedValue = ComboBox_wybierz_producenta.SelectedValue as Producenci;

            if (selectedValue != null)
            {

                Wpisz_nowa_nazwe_producenta.Text = selectedValue.Nazwa_producenta;
                ProducentID = selectedValue.ID_Producenta;
            }
        }

        private void Zapisz_edytowanie_nazwy_producenta_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            this.Close();
        }
    }
}
