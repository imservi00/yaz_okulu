using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci parametre)
        {
            if (parametre.AD != null && parametre.SOYAD != null && parametre.NUMARA != null && parametre.SİFRE != null)
            {
                return DALOgrenci.OgrenciEkle(parametre);
            }
            else
            {
                return -1;
            }
        }

        public static List<EntityOgrenci> BLLListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int parametre)
        {
            if (parametre >= 0)
            {
                return DALOgrenci.OgrenciSil(parametre);
            }
            else
            {
                return false;
            }
        }

        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SİFRE != null && p.FOTOGRAF != null && p.ID > 0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            else
            {
                return false;
            }
        }
    }
}