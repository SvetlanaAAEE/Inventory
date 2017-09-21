using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            try
            {
                menu.MainMenu();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }



}


