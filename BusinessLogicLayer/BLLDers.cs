using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDersler> BLLListele()
        {
            return DALDers.DersListesi();
        }

        public static int TalepEkleBLL(EntityBasvuruForm parametre)
        {
            if(parametre.BASOGRID != null && parametre.BASDERSID != null)
            {
                return DALDers.TalepEkle(parametre);
            }
            else
            {
                return -1;
            }
        }

        public static List<EntityBasvuruDetay> BLLBasvuruDetayListele()
        {
            return DALDers.BasvuruDetayListesi();
        }

    }
}
