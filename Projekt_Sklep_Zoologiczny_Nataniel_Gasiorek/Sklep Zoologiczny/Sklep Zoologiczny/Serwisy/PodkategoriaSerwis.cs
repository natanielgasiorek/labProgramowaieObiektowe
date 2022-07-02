using System;
using System.Collections.Generic;
using Sklep_Zoologiczny.BazaDanych;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_Zoologiczny.Serwisy
{
    public class PodkategoriaSerwis
    {
        SklepEntities dbContext = new SklepEntities();

        /// <summary>
        /// Dodawanie podkategori do bazy danych
        /// </summary>
        /// <param name="podkategoria"></param>
        public void Add(Podkategorie podkategoria)
        {
            dbContext.Podkategorie.Add(podkategoria);
            dbContext.SaveChanges();
        }

        /// <summary>
        ///  Znajdowanie w bazie danych podkategori po numerze ID, a następnie edycja
        /// </summary>
        /// <param name="podkategoria"></param>
        public void Edit(Podkategorie podkategoria)
        {
            if (podkategoria != null)
            {
                var item = dbContext.Podkategorie.Find(podkategoria.ID_Podkategorii);

                if (item.Nazwa_podkategorii != null)
                {
                    item.Nazwa_podkategorii = podkategoria.Nazwa_podkategorii;
                }

                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Szukanie w bazie danych podkategori po numerze ID, a nastepnie usuwa
        /// </summary>
        /// <param name="PodkategoriaID"></param>
        public void Remove(int PodkategoriaID)
        {
            var podkategoria = dbContext.Podkategorie.Find(PodkategoriaID);
            dbContext.Podkategorie.Remove(podkategoria);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Pobieranie z bazy danych wszystkich podkategorii
        /// </summary>
        /// <returns></returns>
        public List<Podkategorie> GetAll()
        {
            return dbContext.Podkategorie.ToList();
        }

        /// <summary>
        /// Szukanie podkategori po numerze ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Podkategorie Find(int? ID)
        {
            if(ID != null)
            {
                return dbContext.Podkategorie.Find(ID);
            }
            return null;
        }
    }
}
