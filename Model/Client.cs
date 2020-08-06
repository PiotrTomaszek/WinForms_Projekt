using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Projekt.Model
{
    public class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        public int IdClient { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string Voivodeship { get; set; }
        public string ZIP { get; set; }
        public int Points { get; set; }
        public float MoneySpent { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public ICollection<Order> Orders { get; set; }


    }
}
