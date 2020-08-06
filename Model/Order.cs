using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Projekt.Model
{
    public class Order
    {
        public Order()
        {
            Charts = new HashSet<Chart>();
        }

        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderName { get; set; }
        public string OrderStreet { get; set; }
        public string OrderHouseNumber { get; set; }
        public string OrderCity { get; set; }
        public string OrderVoivodeship { get; set; }
        public string OrderZIP { get; set; }
        public float TotalPrice { get; set; }

        public Client Client { get; set; }
        public ICollection<Chart> Charts { get; set; }
    }
}
