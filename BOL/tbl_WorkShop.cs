using System;
using System.Collections.Generic;
using System.Text;

namespace BOL
{
   public class tbl_WorkShop
    {
        public int WorkShopId { get; set; }
        public string WorkShopTitle { get; set; }
        public DateTime WorkShopDate { get; set; }
        public string WorkShopTopics { get; set; }
        public string WorkShopDuration { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int UpdatedDate { get; set; }

    }
}
