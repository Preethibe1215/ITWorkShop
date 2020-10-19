using System;
using System.Collections.Generic;
using System.Text;

namespace BOL
{
    public class tbl_Material
    {
        public int MaterialId { get; set; }
        public string MaterialDescription { get; set; }
        public string MaterialPath { get; set; }
        public int WorkShopId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int UpdatedDate { get; set; }
    }
}
