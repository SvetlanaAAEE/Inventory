using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Gloves : Inventory_for_box
    {
        public string Claps { get; set; }
        public string GlovesClass { get; set; }
        public override string AllInventory()
        {
            return base.AllInventory() + "Claps: " + this.Claps +"; " + "Class: " + this.GlovesClass +";";
        }
        public Gloves(string name, int prise, string manufacture, int number,string strenght,string matireal, string claps, string glovesClass) : base(name, prise, manufacture,number,strenght,  matireal)
        {
            Claps = claps;
            GlovesClass = glovesClass;
        }
    }

}
