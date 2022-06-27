 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicStok
    {
        public static List<EntityStok> LLStokLisetesi()
        {
            return DALStok.stoklistesi();
        }
        public static List<EntityDate> LLDateLisetesi()
        {
            return DALStok.stoktarih();
        }
        public static int LLStokEkle(EntityStok p)
        {
            if(p.Urunmodel!="" && p.Urunmarka != "" && p.Urunmiktar >= 0)
            {
                return DALStok.StokEkle(p);

            }
            else
            {
                return -1;
            }
        }
        public static bool LLStokSil(int per)
        {
            if(per >= 1)
            {
                return DALStok.Stoksil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLStokGuncelle(EntityStok ent)
        {
            if(ent.Urunmarka!=""&& ent.Urunmodel!="" && ent.Urunmiktar >= 0)
            {
                return DALStok.StokGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
