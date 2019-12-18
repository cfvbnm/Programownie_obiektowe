using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
        
    public enum standardOfPowerSupply
    {
        ATX,
        ATX12V,
        EPS12V,
        SFX
    }

    class PowerSupply : Components
    {
        public int powerInWatts;
        public string _standardOfPowerSupply;
        public int size;

        public PowerSupply(string name, double price, int powerInWatts, string standardOfPowerSupply, int size) : base(name, price)
        {
            this.powerInWatts = powerInWatts;
            this._standardOfPowerSupply = standardOfPowerSupply;
            this.size = size;
        }
    }
}
