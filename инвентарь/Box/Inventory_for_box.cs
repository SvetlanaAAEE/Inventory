using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Inventory_for_box : SportInventory

    {
        public string Strength { get; set; }
        public string Matireal { get; set; }


        public override string AllInventory()
        {
            return "Manufacture: " + this.Manufacture + "; " + "Number: " + this.Number + "; " + "Name: " + this.Name + "; " + "Prise: " + this.Prise + ";" + "Streght: " + this.Strength + "; " + "Matireal: " + this.Matireal + ";";
        }
        public Inventory_for_box(string name, int prise, string manufacture, int number, string strenght, string matireal):base(name,  prise,  manufacture,  number)
        {
            Strength = strenght;
            Matireal = matireal;
        }
    }
}
