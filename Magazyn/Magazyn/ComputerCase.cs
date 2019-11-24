using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public enum color
    {
        czerwony,
        niebieski,
        czarny
    }
    public enum caseMaterial
    {
        stal,
        plastik,
    }
    class ComputerCase : Components
    {
        public string caseDimensions;
        public color _color;
        public caseMaterial _caseMaterial;

        public ComputerCase(string name, double price, string caseDimensions, color color, caseMaterial caseMaterial) : base(name, price)
        {
            this.caseDimensions = caseDimensions;
            this._color = color;
            this._caseMaterial = caseMaterial;
        }
    }
}
