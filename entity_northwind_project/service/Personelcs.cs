using entity_northwind_project;
using entity_northwind_project.service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_northwind_project.service
{
    public class Personelcs
    {
        //public int ID { get; set; }
        //public string TCKN { get; set; }
        //public string AD { get; set; }
        //public string SOYAD { get; set; }
        //public string CINSIYET { get; set; }
        //public string DOGUM_YERI { get; set; }


        public static void Insert(PERSONELLER personel)
        {
            NorthwindTR_DBEntities Entities=new NorthwindTR_DBEntities();
            Entities.PERSONELLER.Add(personel);
            Entities.SaveChanges();
        }

        public static void Update(PERSONELLER personel)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel= Entities.PERSONELLER.Where(x => x.ID == personel.ID)
                .FirstOrDefault();
            if (YeniPersonel!=null)
            {
                YeniPersonel.TCKN = personel.TCKN;
                YeniPersonel.AD = personel.AD;  
                YeniPersonel.SOYAD = personel.SOYAD;
                YeniPersonel.CINSIYET = personel.CINSIYET;
                YeniPersonel.DOGUM_YERI = personel.DOGUM_YERI;
                Entities.SaveChanges();
            }
        }



        public static void SIL(PERSONELLER personel)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.PERSONELLER.Where(x => x.ID == personel.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.IS_FLAG = 0;
                Entities.SaveChanges();
            }
        }

        public static List<View_PERSONEL_LIST> LISTELE()
        {
            NorthwindTR_DBEntities Entities=new NorthwindTR_DBEntities();
            List<View_PERSONEL_LIST> PERSONEL_LIST= Entities.View_PERSONEL_LIST.ToList();
            return PERSONEL_LIST;
            //string sql = "SELECT * FROM View_PERSONEL_LIST";
            //return Provider.GetQueryDataTable(sql);
        }

        public static List<View_personelAD_ID> LISTELEPER()
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            List<View_personelAD_ID >personelAD_ID = Entities.View_personelAD_ID.ToList();
            return personelAD_ID;
            //string sql = "SELECT ID,AD FROM View_PERSONEL_LIST";
            //return Provider.GetQueryDataTable(sql);
        }






    }
}
