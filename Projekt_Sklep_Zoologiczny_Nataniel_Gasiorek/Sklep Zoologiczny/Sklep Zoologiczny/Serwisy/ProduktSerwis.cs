using System;
using System.Collections.Generic;
using Sklep_Zoologiczny.BazaDanych;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_Zoologiczny.Serwisy
{
    public class ProduktSerwis
    {
        SklepEntities dbContext = new SklepEntities();

        /// <summary>
        /// Dodawanie produktu do bazy danych
        /// </summary>
        /// <param name="produkt"></param>
        public void Add(Produkty produkt)
        {
            dbContext.Produkty.Add(produkt);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Znajdowanie w bazie danych produktu po numerze ID, a następnie edycja
        /// </summary>
        /// <param name="produkt"></param>
        public void Edit(Produkty produkt)
        {
            if (produkt != null)
            {
                var item = dbContext.Produkty.Find(produkt.ID_Produktu);

                if (item.Nazwa_produktu != null)
                {
                    item.Nazwa_produktu = produkt.Nazwa_produktu;
                }
              
                if (item.Cena != null)
                {
                    item.Cena = produkt.Cena;
                }
              
                if (item.ID_Producenta != null)
                {
                    item.ID_Producenta = produkt.ID_Producenta;
                }

                if (item.ID_Kategorii != null)
                {
                    item.ID_Kategorii = produkt.ID_Kategorii;
                }

                if (item.ID_Podkategorii != null)
                {
                    item.ID_Podkategorii = produkt.ID_Podkategorii;
                }

                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Szukanie w bazie danych produktu po numerze ID, a nastepnie usuwa
        /// </summary>
        /// <param name="ProduktID"></param>
        public void Remove(int ProduktID)
        {
            var produkt = dbContext.Produkty.Find(ProduktID);
            dbContext.Produkty.Remove(produkt);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Pobieranie z bazy danych wszystkich produktow
        /// </summary>
        /// <returns></returns>
        public List<Produkty> GetAll()
        {
            return dbContext.Produkty.ToList();
        }
    }

}
