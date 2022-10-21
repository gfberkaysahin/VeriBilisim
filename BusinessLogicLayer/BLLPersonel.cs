using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class BLLPersonel
    {
        public static int PersonelEkleBLL(EntityPersoneller p)
        {
            if (p.ADISOYADI1 != null)
            {
                return DALPersonel.PersonelEkle(p);
            }
            return -1;
        }

        public static List<EntityPersoneller> BllListele()
        {
            return DALPersonel.PersonelListesi();
        }

        public static bool PersonelSilBLL(int p)
        {
            if (p >= 0)
            {
                return DALPersonel.PersonelSil(p);
            }
            return false;
        }

        public static List<EntityPersoneller> BllDetay(int p)
        {
            return DALPersonel.PersonelDetay(p);
        }

        public static bool PersonelGuncelleBLL(EntityPersoneller p)
        {
            if (p.ADISOYADI1 != null && p.ILCEID1 != null && p.ILID1 != null && p.CINSIYET1 != null && p.DOGUMTARIHI1 != null && p.ACIKLAMA1 != null)
            {
                return DALPersonel.PersonelGuncelle(p);

            }
            return false;
        }



    }
}
