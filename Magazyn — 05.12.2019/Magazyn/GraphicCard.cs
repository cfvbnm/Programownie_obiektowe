using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    class GraphicCard : Components
    {
        public int memory;
        public int coreClock;
        public bool sliCompatible;

        public GraphicCard(string name, double price, int memory, int coreClock, bool sliCompatible) : base(name, price)
        {
            this.memory = memory;
            this.coreClock = coreClock;
            this.sliCompatible = sliCompatible;
        }
    }
}
