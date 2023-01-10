using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_northwind_project.service
{
    public class sipariscs
    {
        public static void Insert(SIPARIS siparis)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            Entities.SIPARIS.Add(siparis);
            Entities.SaveChanges();
        }

        public static void Update(SIPARIS siparis)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.SIPARIS.Where(x => x.ID == siparis.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.ID = siparis.ID;
                YeniPersonel.PERSONEL_ID=siparis.PERSONEL_ID;
                YeniPersonel.MUSTERI_ID = siparis.MUSTERI_ID;
                Entities.SaveChanges();
            }
        }



        public static void SIL(SIPARIS siparis)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.SIPARIS.Where(x => x.ID == siparis.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.IS_FLAG = 0;
                Entities.SaveChanges();
            }
        }

        public static List<View_SIPARIS_LIST> LISTELE()
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            List<View_SIPARIS_LIST> View_SIPARIS_LIST = Entities.View_SIPARIS_LIST.ToList();
            return View_SIPARIS_LIST;
            //string sql = "SELECT * FROM View_SIPARIS_LIST";
            //return Provider.GetQueryDataTable(sql);
        }

        public static DataTable LISTELESIPP()
        {
            string sql = "SELECT SIPARIS_ID FROM View_SIPARIS_LIST";
            return Provider.GetQueryDataTable(sql);
        }
    }
}
