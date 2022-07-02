using DevExpress.Xpf.Core;
using System;
using Sklep_Zoologiczny.BazaDanych;
using Sklep_Zoologiczny.Serwisy;
using Sklep_Zoologiczny.Widoki;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sklep_Zoologiczny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        SklepEntities dbContext = new SklepEntities();

        KategoriaSerwis kategoriaSerwis = new KategoriaSerwis();
        PodkategoriaSerwis podkategoriaSerwis = new PodkategoriaSerwis();
        ProducentSerwis producentSerwis = new ProducentSerwis();

        public MainWindow()
        {
            InitializeComponent();

            GridControlProdukty.ItemsSource = dbContext.Produkty.ToList();
            GridControlProducenci.ItemsSource = dbContext.Producenci.ToList();
            GridControlKategorie.ItemsSource = dbContext.Kategorie.ToList();
            GridControlPodkategorie.ItemsSource = dbContext.Podkategorie.ToList();
        }

        private void Dodaj_produkt_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Dowanie_produktu okno = new Dowanie_produktu();
            okno.ShowDialog();
        }

        private void Edytuj_produkt_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Edytowanie_produktu okno = new Edytowanie_produktu();
            okno.ShowDialog();
        }

        private void Usuń_produkt_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Usuwanie_produktu okno = new Usuwanie_produktu();
            okno.ShowDialog();
        }

        private void Dodaj_kategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Dodawanie_kategorii okno = new Dodawanie_kategorii();
            okno.ShowDialog();
        }

        private void Edytuj_kategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Edytowanie_kategorii okno = new Edytowanie_kategorii();
            okno.ShowDialog();
        }

        private void Usuń_kategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Usuwanie_kategorii okno = new Usuwanie_kategorii();
            okno.ShowDialog();
        }

        private void Dodaj_podkategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Dodawanie_podkategorii okno = new Dodawanie_podkategorii();
            okno.ShowDialog();
        }

        private void Edytuj_podkategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Edytowanie_podkatgorii okno = new Edytowanie_podkatgorii();
            okno.ShowDialog();
        }

        private void Usuń_podkategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Usuwanie_podkategorii okno = new Usuwanie_podkategorii();
            okno.ShowDialog();
        }

        private void Dodaj_producenta_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Dodawanie_producenta okno = new Dodawanie_producenta();
            okno.ShowDialog();
        }

        private void Edytuj_producenta_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Edytowanie_producenta okno = new Edytowanie_producenta();
            okno.ShowDialog();
        }

        private void Usun_producenta_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Usuwanie_producenta okno = new Usuwanie_producenta();
            okno.ShowDialog();
        }

        private void Odśwież_Click(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            GridControlProdukty.ItemsSource = dbContext.Produkty.ToList();
            GridControlProducenci.ItemsSource = dbContext.Producenci.ToList();
            GridControlKategorie.ItemsSource = dbContext.Kategorie.ToList();
            GridControlPodkategorie.ItemsSource = dbContext.Podkategorie.ToList();

            GridControlProdukty.RefreshData();
            GridControlProducenci.RefreshData();
            GridControlKategorie.RefreshData();
            GridControlPodkategorie.RefreshData();
        }

        private void GridControlProdukty_CustomColumnDisplayText(object sender, DevExpress.Xpf.Grid.CustomColumnDisplayTextEventArgs e)
        {
            var row = GridControlProdukty.GetRow(e.RowHandle) as Produkty;
            if (e.Column == KolumnaProducent)
            {

                var nazwaProducenta = producentSerwis.Find(row.ID_Producenta);
                if (nazwaProducenta != null)
                {
                    e.DisplayText = nazwaProducenta.Nazwa_producenta.ToString();
                }
            }


            if (e.Column == KolumnaKategoria)
            {
                var nazwaKategorii = kategoriaSerwis.Find(row.ID_Kategorii);
                if (nazwaKategorii != null)
                {
                    e.DisplayText = nazwaKategorii.Nazwa_kategorii.ToString();
                }
            }



            if (e.Column == KolumnaPodkategoria)
            {
                var nazwaPodkategorii = podkategoriaSerwis.Find(row.ID_Podkategorii);
                if (nazwaPodkategorii != null)
                {
                    e.DisplayText = nazwaPodkategorii.Nazwa_podkategorii.ToString();
                }
            }
        }

        
    }
}
