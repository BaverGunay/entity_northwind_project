using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_northwind_project;
using entity_northwind_project.service;

namespace entity_northwind_project.service
{
    public class kategorics
    {

        public static void Insert(Kategoriler kategori)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            Entities.Kategoriler.Add(kategori);
            Entities.SaveChanges();
        }

        public static void Update(Kategoriler kategori)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.Kategoriler.Where(x => x.ID == kategori.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
            YeniPersonel.ID = kategori.ID;
            YeniPersonel.AD = kategori.AD;
                Entities.SaveChanges();
            }
        }



        public static void SIL(Kategoriler kategori)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.Kategoriler.Where(x => x.ID == kategori.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.IS_FLAG = 0;
                Entities.SaveChanges();
            }
        }

        public static List<View_Kategoriler> LISTELE()
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            List<View_Kategoriler> View_Kategoriler = Entities.View_Kategoriler.ToList();
            return View_Kategoriler;
            //string sql = "SELECT * FROM View_Kategoriler";
            //return Provider.GetQueryDataTable(sql);
        }

        public static DataTable LISTELEKAT()
        {
            string sql = "SELECT ID,AD FROM View_Kategoriler";
            return Provider.GetQueryDataTable(sql);
        }




    }
}
