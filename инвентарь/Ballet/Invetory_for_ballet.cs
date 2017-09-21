using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Inventory_for_ballet:SportInventory
    {
        public string AgeGroup { get; set; }
        public string Color { get; set; }
         public override string AllInventory()
        {
            return base.AllInventory() + "AgeGroup: " + this.AgeGroup + "; " + "Color" + this.Color + "; ";
        }
       public Inventory_for_ballet(string name, int prise, string manufacture, int number,string ageGroup,string color):base(name, prise, manufacture, number)
        {
            AgeGroup = ageGroup;
            Color = color;
        }
    }
    
}
