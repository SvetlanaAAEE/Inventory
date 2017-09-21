using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Points: Inventory_for_ballet
    {
        public int Size { get; set; }
        public string Closeness { get; set; }
        public override string AllInventory()
        {
            return base.AllInventory() + "Size: " + this.Size + "; " + "Closeness" + this.Closeness + "; ";
        }
        public Points(string name, int prise, string manufacture, int number, string ageGroup, string color,int size, string closeness) : base(name, prise, manufacture, number, ageGroup,color)
        {
            Size = size;
            Closeness = closeness;
        }

    }
}
