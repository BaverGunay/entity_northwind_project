using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_northwind_project.service;

namespace entity_northwind_project.service
{
    public class musterics
    {
        public static void Insert(MUSTERILER musteri)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            Entities.MUSTERILER.Add(musteri);
            Entities.SaveChanges();
        }

        public static void Update(MUSTERILER musteri)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.MUSTERILER.Where(x => x.ID == musteri.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.ID=musteri.ID;
                YeniPersonel.MUSTERI_AD=musteri.MUSTERI_AD;
                YeniPersonel.YETKILI = musteri.YETKILI;
                YeniPersonel.ADRES=musteri.ADRES;
                YeniPersonel.SEHIR = musteri.SEHIR;
                YeniPersonel.ULKE=musteri.ULKE;
               
                Entities.SaveChanges();
            }
        }



        public static void SIL(MUSTERILER musteri)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.MUSTERILER.Where(x => x.ID == musteri.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.IS_FLAG = 0;
                Entities.SaveChanges();
            }
        }

        public static List<View_Musteriler> LISTELE()
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            List<View_Musteriler> View_Musteriler = Entities.View_Musteriler.ToList();
            return View_Musteriler;
            //string sql = "SELECT * FROM View_Musteriler";
            //return Provider.GetQueryDataTable(sql);
        }

        public static List<View_musteriID_AD> LISTELEMUS()
        {
            NorthwindTR_DBEntities Entities=new NorthwindTR_DBEntities();
            List<View_musteriID_AD> musteriID_AD = Entities.View_musteriID_AD.ToList();
            return musteriID_AD;
            //string sql = "SELECT ID,MUSTERI_AD FROM View_Musteriler";
            //return Provider.GetQueryDataTable(sql);
        }

    }
}
