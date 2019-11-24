using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public enum socket
    {
        LGA1151,
        LGA1155,
        LGA1156,
        LGA1366
    }

    class Processor : Components
    {
        public int numOfCores;
        public int coreClock;
        public socket _socket;
        
        public Processor(string name, double price, int numOfCores, int coreClock, socket socket) : base(name, price)
        {
            this.numOfCores = numOfCores;
            this.coreClock = coreClock;
            this._socket = socket;
        }
    }
}
