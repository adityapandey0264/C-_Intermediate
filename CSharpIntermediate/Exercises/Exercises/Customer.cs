using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders; //A list is a generic class and its uses a parameter called generic parameter.
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }
        public Customer(int id,string name)
            :this(id)
        {
            
            this.Name = name;
        }
    }
}
