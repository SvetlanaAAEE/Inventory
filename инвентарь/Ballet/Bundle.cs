using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Bundle:Inventory_for_ballet
    {
        public int Layer { get; set; }
        public int BunLength{ get; set; }
        public override string AllInventory()
        {
            return base.AllInventory() + "Layer: " + this.Layer + "; " + "BunLength" + this.BunLength + "; ";
        }
        public Bundle(string name, int prise, string manufacture, int number, string ageGroup, string color, int layer,int bunLength) : base(name, prise, manufacture, number, ageGroup,color)
        {
            Layer = layer;
            BunLength = bunLength;
        }
        


    }
}
