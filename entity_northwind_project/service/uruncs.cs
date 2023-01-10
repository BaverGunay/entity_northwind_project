using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_northwind_project.service
{
    internal class uruncs
    {
       
        
            public static void Insert(URUNLER urun)
            {
                NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
                Entities.URUNLER.Add(urun);
                Entities.SaveChanges();
            }

            public static void Update(URUNLER urun)
            {
                NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
                var YeniPersonel = Entities.URUNLER.Where(x => x.ID == urun.ID)
                    .FirstOrDefault();
                if (YeniPersonel != null)
                {
                    YeniPersonel.ID = urun.ID;
                    YeniPersonel.AD=urun.AD;
                    YeniPersonel.TEDARIKCID=urun.TEDARIKCID;
                    YeniPersonel.KATEGORID=urun.KATEGORID;
                    YeniPersonel.FIYAT=urun.FIYAT;
                    YeniPersonel.STOK=urun.STOK;
                    Entities.SaveChanges();
                }
            }



            public static void SIL(URUNLER urun)
            {
                NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
                var YeniPersonel = Entities.URUNLER.Where(x => x.ID == urun.ID)
                    .FirstOrDefault();
                if (YeniPersonel != null)
                {
                    YeniPersonel.IS_FLAG = 0;
                    Entities.SaveChanges();
                }
            }

            public static List<View_Urunler_List> LISTELE()
            {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            List<View_Urunler_List> View_Urunler_List = Entities.View_Urunler_List.ToList();
            return View_Urunler_List;
            //string sql = "SELECT * FROM View_Urunler_List";
            //return Provider.GetQueryDataTable(sql);
        }

        public static DataTable LISTELEURUN()
        {
                string sql = "SELECT URUNLER_ID,URUN_AD FROM View_Urunler_List";
                return Provider.GetQueryDataTable(sql);
        }
        public static string FIYAT_GETIR(string ID)
        {
            string sql = "select FIYAT from URUNLER WHERE ID = " + ID;
            DataTable dt = Provider.GetQueryDataTable(sql);
            return dt.Rows[0][0].ToString();
        }
        public static string STOK_GETIR(string ID)
        {
            string sql = "select STOK from URUNLER WHERE ID = " + ID;
            DataTable dt = Provider.GetQueryDataTable(sql);
            return dt.Rows[0][0].ToString();
        }


    }
}
