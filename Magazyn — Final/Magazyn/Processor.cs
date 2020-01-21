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

    public class Processor : Components
    {
        public int numOfCores;
        public double coreClock;
        public string _socket;
        
        public Processor(string name, double price, int numOfCores, double coreClock, string socket) : base(name, price)
        {
            this.numOfCores = numOfCores;
            this.coreClock = coreClock;
            this._socket = socket;
        }

        public override string ToString()
        {
            return $"{this.numOfCores} - {this.coreClock} - ({this._socket})";
        }
    }
}
