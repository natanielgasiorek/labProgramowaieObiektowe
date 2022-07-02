using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sklep_Zoologiczny.BazaDanych
{
    public class Models : ViewModelBase
    {
        SklepEntities Sklep_ZoologicznyEntities;

        public ObservableCollection<Podkategorie> Podkategorie
        {
            get => GetValue<ObservableCollection<Podkategorie>>();
            set => SetValue(value);
        }

        public ObservableCollection<Kategorie> Kategorie
        {
            get => GetValue<ObservableCollection<Kategorie>>();
            set => SetValue(value);
        }
        public ObservableCollection<Producenci> Producenci
        {
            get => GetValue<ObservableCollection<Producenci>>();
            set => SetValue(value);
        }
        public ObservableCollection<Produkty> Produkty
        {
            get => GetValue<ObservableCollection<Produkty>>();
            set => SetValue(value);
        }

        public Models()
        {
            Sklep_ZoologicznyEntities = new SklepEntities();

            if (IsInDesignMode)
            {
                Podkategorie = new ObservableCollection<Podkategorie>();
                Kategorie = new ObservableCollection<Kategorie>();
                Producenci = new ObservableCollection<Producenci>();
                Produkty = new ObservableCollection<Produkty>();
            }
            else
            {
                Sklep_ZoologicznyEntities.Podkategorie.Load();
                Podkategorie = Sklep_ZoologicznyEntities.Podkategorie.Local;
                Sklep_ZoologicznyEntities.Kategorie.Load();
                Kategorie = Sklep_ZoologicznyEntities.Kategorie.Local;
                Sklep_ZoologicznyEntities.Producenci.Load();
                Producenci = Sklep_ZoologicznyEntities.Producenci.Local;
                Sklep_ZoologicznyEntities.Produkty.Load();
                Produkty = Sklep_ZoologicznyEntities.Produkty.Local;
            }


        }
    }
}
