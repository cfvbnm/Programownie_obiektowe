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
        public diskType _diskType;

        public Disk(string name, double price, diskType type) : base(name, price)
        {
            _diskType = type;
        }
    }
}
