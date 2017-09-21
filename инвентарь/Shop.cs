using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Shop
    {
        SportInventory[] inventory = new SportInventory[0];
        private void CreatNewInventory()
        {

            SportInventory[] timemas = new SportInventory[inventory.Length + 1];
            for (int i = 0; i < inventory.Length; i++)
            {
                timemas[i] = inventory[i];
            }
            inventory = timemas;
        }

        public void AddCapsMas(string name, int prise, string manufactory, int number, string strenght, string matireal, int ageGroup, string type)
        {
            CreatNewInventory();
            inventory[inventory.Length - 1] = new Caps(name, prise, manufactory, number, strenght, matireal, ageGroup, type);

        }

        public void AddGlovesMas(int number, int prise, string manufactory, string name, string strenght, string matireal, string claps, string glovesClass)
        {
            CreatNewInventory();
            inventory[inventory.Length - 1] = new Gloves(name, prise, manufactory, number, strenght, matireal, claps, glovesClass);
        }
        public void AddPointMas(string name, int prise, string manufacture, int number, string ageGroup, string color, int size, string closeness)
        {
            CreatNewInventory();
            inventory[inventory.Length - 1] = new Points(name, prise, manufacture, number, ageGroup, color, size, closeness);
        }
        public void AddBundleMas(string name, int prise, string manufacture, int number, string ageGroup, string color, int layer, int bunLength)
        {
            CreatNewInventory();
            inventory[inventory.Length - 1] = new Bundle(name, prise, manufacture, number, ageGroup, color, layer, bunLength);
        }

        public void AddBoxInfo(out int number, out int prise, out string manufactory, out string name, out string strenght, out string matireal)
        {
            Console.WriteLine("Enter number of your box inventory");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter manufacture of your box inventory");
            manufactory = Console.ReadLine();
            Console.WriteLine("Enter prise of your box inventory");
            prise = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of your box inventory");
            name = Console.ReadLine();
            Console.WriteLine("Enter strenght of your box inventory");
            strenght = Console.ReadLine();
            Console.WriteLine("Enter material of your box inventory");
            matireal = Console.ReadLine();
        }
        public void AddBalletInfo(out string name, out int prise, out string manufactory, out int number, out string ageGroup, out string color)
        {
            Console.WriteLine("Enter name of your ballet inventory");
            name = Console.ReadLine();
            Console.WriteLine("Enter prise of your ballet inventory");
            prise = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of your ballet inventory");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter manufacture of your ballet inventory");
            manufactory = Console.ReadLine();
            Console.WriteLine("Enter strenght of your ballet inventory");
            ageGroup = Console.ReadLine();
            Console.WriteLine("Enter material of your ballet inventory");
            color = Console.ReadLine();
        }

        public void AddCapsInfo(int number, int prise, string manufactory, string name, string strenght, string matireal)
        {
            Console.WriteLine("Enter age group of your caps");
            int ageGroup = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter type of your caps");
            string type = Console.ReadLine();
            AddCapsMas(name, prise, manufactory, number, strenght, matireal, ageGroup, type);
        }
        public void AddGlovesInfo(int number, int prise, string manufactory, string name, string strenght, string matireal)
        {
            Console.WriteLine("Enter information claps of your gloves");
            string claps = Console.ReadLine();
            Console.WriteLine("Enter class of your gloves");
            string glovesClass = Console.ReadLine();
            AddGlovesMas(number, prise, manufactory, name, strenght, matireal, claps, glovesClass);
}
        public void AddPointInfo(string name, int prise, string manufacture, int number, string ageGroup, string color)
        {
            Console.WriteLine("Enter size of your points");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter closeness of your pints");
            string closeness = Console.ReadLine();
            AddPointMas(name, prise, manufacture, number, ageGroup, color, size, closeness);
        }
        public void AddBundleInfo(string name, int prise, string manufactory, int number, string ageGroup, string color)
        {
            Console.WriteLine("Enter count of layer on your bundle");
            int layer = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of  your bundle");
            int bunLength = int.Parse(Console.ReadLine());
            AddBundleMas(name, prise, manufactory, number, ageGroup, color, layer, bunLength);
        }

        public void ShowCapsInfo()
        {
            Console.Clear();
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] is Caps)
                {
                    Console.WriteLine(inventory[i].AllInventory());
                }
            }
        }
        public void ShowGlovesInfo()
        {
            Console.Clear();
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] is Gloves)
                {
                    Console.WriteLine(inventory[i].AllInventory());
                }
            }
        }
        public void ShowBundleInfo()
        {
            Console.Clear();
            SportInventory result = null;
            for (int i = 0; i < inventory.Length; i++)
            {
                result = inventory[i] as Bundle;
                if (result != null)
                {
                    Console.WriteLine(inventory[i].AllInventory());
                }
            }
        }
        public void ShowPointInfo()
        {
            Console.Clear();
            SportInventory result = null;
            for (int i = 0; i < inventory.Length; i++)
            {
                result = inventory[i] as Points;
                if (result != null)
                {
                    Console.WriteLine(inventory[i].AllInventory());
                }
            }
        }

    }

}

