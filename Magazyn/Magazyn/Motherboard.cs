using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public enum size
    {
        ATX,
        MicroATX,
        MiniITX
    }

    class Motherboard : Components
    {
        public bool networkCard;
        public int ramSlots;
        public size _size;

        public Motherboard(string name, double price, bool networkCard, int ramSlots, size size) : base(name, price)
        {
            this.networkCard = networkCard;
            this.ramSlots = ramSlots;
            this._size = size;
        }
    }
}
