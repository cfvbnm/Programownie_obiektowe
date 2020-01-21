using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{

    public enum memoryType
    {
        DDR4,
        DDR3
    }

    public class Ram : Components
    {
        public int memorySize;
        public int memoryClockFrequency;
        public string _memoryType;

        public Ram(string name, double price, int memorySize, int memoryClockFreq, string memoryType) : base(name, price)
        {
            this.memorySize = memorySize;
            this.memoryClockFrequency = memoryClockFreq;
            this._memoryType = memoryType;
        }
    }
}
