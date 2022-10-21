using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class BLLPersonelIsBasvuru
    {
        public static int PersonelBasvuruEkleBLL(EntityPersonelIsBasvurulari p)
        {
            if (p.POZISYON1 != null)
            {
                return DALPersonelBasvuru.PersonelBasvuruEkle(p);
            }
            return -1;
        }

        public static List<EntityPersonelIsBasvurulari> BllBasvuruListele()
        {
            return DALPersonelBasvuru.BasvuruPersonelListesi();
        }

        public static bool BasvuruPersonelSilBLL(int p)
        {
            if (p >= 0)
            {
                return DALPersonelBasvuru.BasvuruPersonelSil(p);
            }
            return false;
        }

        public static List<EntityPersonelIsBasvurulari> BllBasvuruDetay(int p)
        {
            return DALPersonelBasvuru.BasvuruPersonelDetay(p);
        }

        public static bool BasvuruPersonelGuncelleBLL(EntityPersonelIsBasvurulari p)
        {
            if (p.BASVURUACIKLAMA1 != null)
            {
                return DALPersonelBasvuru.BasvuruPersonelGuncelle(p);

            }
            return false;
        }


    }
}
