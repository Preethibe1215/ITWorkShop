using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using DAL;


namespace BLL
{
   public class WorkShopBusiness
    {
        public bool InsertWorkShop(tbl_WorkShop Wp)
        {
            //WorkShopDate should be greater than current Date
            if(Wp.WorkShopDate>DateTime.Now)
            {
                WorkShopDb WD = new WorkShopDb();
                WD.InsertWorkShop(Wp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<tbl_WorkShop> GetWorkShops()
        {
            WorkShopDb WD = new WorkShopDb();
            return WD.GetWorkShops();
        }
        public tbl_WorkShop GetWorkShopById(int WorkShopId)
        {
            WorkShopDb WD = new WorkShopDb();
            tbl_WorkShop Wp = WD.GetWorkShopById(WorkShopId);
            return Wp;
        }

        public bool UpdateWorkShopById(tbl_WorkShop Wp, int WorkShopId)
        {
            WorkShopDb WD = new WorkShopDb();
            if (Wp.WorkShopDate > DateTime.Now)
            {

                WD.UpdateWorkShopById(Wp, WorkShopId);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool DeleteWorkShopById(int WorkShopId)
        {
            WorkShopDb WD = new WorkShopDb();
            WD.DeleteWorkShopById(WorkShopId);
                return true;
        }
    }
}
