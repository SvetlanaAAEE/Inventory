using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Caps : Inventory_for_box
    {
        public int AgeGroup { get; set; }
        public string Type { get; set; }
        public override string AllInventory()
        {
            return base.AllInventory() + "Age group: " + this.AgeGroup + "; "+ "Type: " + this.Type+ "; ";
        }
        public Caps(string name, int prise, string manufacture, int number, string strenght,string matireal, int ageGroup,string type):base(name,  prise,  manufacture,  number, strenght,matireal )
        {
            AgeGroup = ageGroup;
            Type = type;
        }
    }
}


