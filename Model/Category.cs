using System.Collections.Generic;

namespace P4_Projekt.Model
{
    public class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int IdCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Product { get; set; }

    }
}
