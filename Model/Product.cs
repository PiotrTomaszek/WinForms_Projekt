using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Projekt.Model
{
    public class Product
    {
        public int IdProduct { get; set; }
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public bool Discontinued { get; set; }
        public string Manufacturer { get; set; }
        public float UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOrdered { get; set; }
        public int UnitsSold { get; set; }
        public string ImageUrl { get; set; }

        public Category Category { get; set; }
        public ICollection<Chart> Chart { get; set; }
    }
}
