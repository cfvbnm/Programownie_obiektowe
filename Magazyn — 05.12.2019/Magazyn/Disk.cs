using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public enum diskType
    { 
        HDD,
        SSD
    }
    class Disk : Components
    {
        public int capacity;
        public string _diskType;

        public Disk(string name, double price, int capacity, string type) : base(name, price)
        {
            this.capacity = capacity;
            _diskType = type;
        }
    }
}
