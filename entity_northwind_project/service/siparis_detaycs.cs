using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_northwind_project.service
{
    public class siparis_detaycs
    {
        public static void Insert(List<SIPARIS_DETAY> siparis_detay_list)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            //Entities.SIPARIS_DETAY.Add(siparis_detay_list);
            foreach (SIPARIS_DETAY item in siparis_detay_list)
            {
                Entities.SIPARIS_DETAY.Add(item);
            }
            Entities.SaveChanges();
        }

        public static void Update(SIPARIS_DETAY siparis_detay)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.SIPARIS_DETAY.Where(x => x.ID == siparis_detay.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.ID = siparis_detay.ID;
                YeniPersonel.SIPARIS_ID = siparis_detay.SIPARIS_ID;
                YeniPersonel.URUN_ID = siparis_detay.URUN_ID;
                YeniPersonel.FIYAT=siparis_detay.FIYAT;
                YeniPersonel.ADET=siparis_detay.ADET;
                Entities.SaveChanges();
            }
        }



        public static void SIL(SIPARIS_DETAY siparis_detay)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.SIPARIS_DETAY.Where(x => x.ID == siparis_detay.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.IS_FLAG = 0;
                Entities.SaveChanges();
            }
        }

        public static List<View_SIPARISDETAY_LIST> LISTELE()
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            List<View_SIPARISDETAY_LIST> View_SIPARISDETAY_LIST = Entities.View_SIPARISDETAY_LIST.ToList();
            return View_SIPARISDETAY_LIST;
            //string sql = "SELECT * FROM View_SIPARIS_LIST";
            //return Provider.GetQueryDataTable(sql);
        }

        public static DataTable LISTELECOM()
        {
            string sql = "SELECT ID,AD FROM View_Tedarikci_List";
            return Provider.GetQueryDataTable(sql);
        }
    }
}
