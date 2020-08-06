using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Projekt.Model
{
    public class Chart
    {
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public float Price { get; set; }
        public int Units { get; set; }
        public float Discount { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }

    }
}
