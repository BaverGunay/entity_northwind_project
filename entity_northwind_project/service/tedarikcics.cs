using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_northwind_project.service
{
    public class tedarikcics
    {
        public static void Insert(TEDARIKCILER tedarikci)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            Entities.TEDARIKCILER.Add(tedarikci);
            Entities.SaveChanges();
        }

        public static void Update(TEDARIKCILER tedarikci)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.TEDARIKCILER.Where(x => x.ID == tedarikci.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.ID=tedarikci.ID;
                YeniPersonel.AD=tedarikci.AD;
                YeniPersonel.YETKILI = tedarikci.YETKILI;
                YeniPersonel.ADRES = tedarikci.ADRES;
                YeniPersonel.SEHIR = tedarikci.SEHIR;
                YeniPersonel.ULKE = tedarikci.ULKE;

                Entities.SaveChanges();
            }
        }



        public static void SIL(TEDARIKCILER tedarikci)
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            var YeniPersonel = Entities.TEDARIKCILER.Where(x => x.ID == tedarikci.ID)
                .FirstOrDefault();
            if (YeniPersonel != null)
            {
                YeniPersonel.IS_FLAG = 0;
                Entities.SaveChanges();
            }
        }

        public static List<View_Tedarikci_List> LISTELE()
        {
            NorthwindTR_DBEntities Entities = new NorthwindTR_DBEntities();
            List<View_Tedarikci_List> View_Tedarikci_List = Entities.View_Tedarikci_List.ToList();
            return View_Tedarikci_List;
            //string sql = "SELECT * FROM View_Tedarikci_List";
            //return Provider.GetQueryDataTable(sql);
        }

        public static DataTable LISTELECOM()
        {
            string sql = "SELECT ID,AD FROM View_Tedarikci_List";
            return Provider.GetQueryDataTable(sql);
        }
    }
}
