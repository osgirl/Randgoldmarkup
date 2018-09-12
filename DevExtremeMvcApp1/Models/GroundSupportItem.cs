using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeMvcApp1.Models
{
    public class GroundSupportItem
    {
        public int ItemId { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public float MetresDrilled { get; set; }        
        public string PieceRateCode { get; set; }
        
    }
}
