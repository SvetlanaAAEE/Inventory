using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class SportInventory
    {
        public string Name { get; set; }
        public int Prise { get; set; }
        public string Manufacture { get; set; }
        public int Number { get; set; }

        public virtual string AllInventory()
        {
            return "Manufacture: " + this.Manufacture+ "; " + "Number: " + this.Number+"; "  + "Name: " + this.Name + "; " + "Prise: " + this.Prise+ ";";
        }
        public SportInventory(string name, int prise, string manufacture, int number)
        {
            Name = name;
            Prise = prise;
            Manufacture = manufacture;
            Number = number;
           
        }
    }
}
