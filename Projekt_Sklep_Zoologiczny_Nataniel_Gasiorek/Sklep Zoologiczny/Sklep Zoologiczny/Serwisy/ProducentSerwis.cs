using System;
using System.Collections.Generic;
using Sklep_Zoologiczny.BazaDanych;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_Zoologiczny.Serwisy
{
    public class ProducentSerwis
    {
        SklepEntities dbContext = new SklepEntities();

        /// <summary>
        /// Dodawanie producenta do bazy danych
        /// </summary>
        /// <param name="producent"></param>
        public void Add(Producenci producent)
        {
            dbContext.Producenci.Add(producent);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Znajdowanie w bazie danych producenta po numerze ID, a następnie edycja
        /// </summary>
        /// <param name="producent"></param>
        public void Edit(Producenci producent)
        {
            if (producent != null)
            {
                var item = dbContext.Producenci.Find(producent.ID_Producenta);

                if (item.Nazwa_producenta != null)
                {
                    item.Nazwa_producenta = producent.Nazwa_producenta;
                }

                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Szukanie w bazie danych producenta po numerze ID, a nastepnie usuwa
        /// </summary>
        /// <param name="ProducentID"></param>
        public void Remove(int ProducentID)
        {
            var producent = dbContext.Producenci.Find(ProducentID);
            dbContext.Producenci.Remove(producent);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Pobieranie z bazy danych wszystkich producentow
        /// </summary>
        /// <returns></returns>
        public List<Producenci> GetAll()
        {
            return dbContext.Producenci.ToList();
        }

        /// <summary>
        /// Szukanie producenta po numerze ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Producenci Find(int? ID)
        {
            if(ID != null)
            {
                return dbContext.Producenci.Find(ID);
            }
            return null;
        }
    }
}
