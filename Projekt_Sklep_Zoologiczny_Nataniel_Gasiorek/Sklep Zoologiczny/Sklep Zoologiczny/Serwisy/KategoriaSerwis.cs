using System;
using System.Collections.Generic;
using Sklep_Zoologiczny.BazaDanych;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_Zoologiczny.Serwisy
{
    public class KategoriaSerwis
    {
        SklepEntities dbContext = new SklepEntities();

        /// <summary>
        /// Dodawanie kategori do bazy danych
        /// </summary>
        /// <param name="kategoria"></param>
        public void Add(Kategorie kategoria)
        {
            dbContext.Kategorie.Add(kategoria);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Znajdowanie w bazie danych kategori po numerze ID, a następnie edycja
        /// </summary>
        /// <param name="kategoria"></param>
        public void Edit(Kategorie kategoria)
        {
            if (kategoria != null)
            {
                var item = dbContext.Kategorie.Find(kategoria.ID_Kategorii);

                if (item.Nazwa_kategorii != null)
                {
                    item.Nazwa_kategorii = kategoria.Nazwa_kategorii;
                }

                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Szukanie w bazie danych kategori po numerze ID, a nastepnie usuwa
        /// </summary>
        /// <param name="KategoriaID"></param>
        public void Remove(int KategoriaID)
        {
            var kategoria = dbContext.Kategorie.Find(KategoriaID);
            dbContext.Kategorie.Remove(kategoria);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Pobieranie z bazy danych wszystkich kategorii
        /// </summary>
        /// <returns></returns>
        public List<Kategorie> GetAll()
        {
            return dbContext.Kategorie.ToList();
        }

        /// <summary>
        /// Szukanie kategori po numerze ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Kategorie Find(int? ID)
        {
            if(ID != null)
            {
                return dbContext.Kategorie.Find(ID);
            }
            return null;
        }
    }

}
