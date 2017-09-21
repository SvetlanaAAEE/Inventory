using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Menu
    {
        Shop shop = new Shop();
        StringBuilder str = new StringBuilder();
        public void MainMenu()
        {
            str.AppendLine("Wthis  which kind of sport are you want work?");
            str.AppendLine("If you want work with box  clik '1'");
            str.AppendLine("If you want work with ballet clik '2'");
            Console.WriteLine(str);
            string ans = Console.ReadLine();
            Console.Clear();
            if (ans == "1")
            {
                MainBoxMenu();
            }
            else if (ans == "2")
            {
                MainBalletMenu();
            }
            else
            {
                throw new ArgumentException("Incorrect comand");
            }
        }

        public void MainBoxMenu()
        {
            str.Clear();
            str.AppendLine("With wich inventory are you want work?");
            str.AppendLine("If you want work with caps, click '1'");
            str.AppendLine("If you want work with gloves, click '2'");
            str.AppendLine("if you want return to main menu click '3'");         
            Console.WriteLine(str);
           
            string ans = Console.ReadLine();
            Console.Clear();
            if (ans == "1")
            {
                ChoisCapsMenu();
            }
            else if (ans == "2")
            {
                ChoisGlovesMenu();
            }
            else if (ans == "3")
            {
                MainMenu();
            }
        }

        public void MainBalletMenu()
        {
            Console.WriteLine("Wthi wich inventory are you want work?");
            Console.WriteLine("If you work with bundlde, click '1'");
            Console.WriteLine("If you want work with point, click '2'");
            Console.WriteLine("if you want return to main menu click '3'");
            string ans = Console.ReadLine();
            Console.Clear();
            if (ans == "1")
            {
                ChoisBundleMenu();
            }
            else if (ans == "2")
            {
                ChoisPointMenu();
            }
            else if (ans == "3")
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public void ChoisGlovesMenu()
        {
            Console.Clear();
            Console.WriteLine("Now you can adding or show information about gloves.What do you want to do ?");
            Console.WriteLine("If you want adding information, click '1'");
            Console.WriteLine("If you want show, click '2'");
            Console.WriteLine("if you want return to main menu for box click '3'");
            DoGlovesAction();
            Console.Clear();
        }
        public void ChoisCapsMenu()
        {
            Console.Clear();
            Console.WriteLine("Now you can adding or show information about caps.What do you want to do ?");
            Console.WriteLine("If you want adding information, click '1'");
            Console.WriteLine("If you want show, click '2'");
            Console.WriteLine("if you want return to main menu for box click '3'");
            DoCapsAction();
            Console.Clear();
        }
        public void ChoisBundleMenu()
        {
            Console.Clear();
            Console.WriteLine("Now you can adding or show information about bundle.What do you want to do ?");
            Console.WriteLine("If you want adding information, click '1'");
            Console.WriteLine("If you want show, click '2'");
            Console.WriteLine("if you want return to main menu for ballet click '3'");
            DoBundleAction();
            Console.Clear();
        }
        public void ChoisPointMenu()
        {
            Console.Clear();
            Console.WriteLine("Now you can adding or show information about points.What do you want to do ?");
            Console.WriteLine("If you want adding information, click '1'");
            Console.WriteLine("If you want show, click '2'");
            Console.WriteLine("if you want return to main menu  for ballet click '3'");
            DoPointAction();
            Console.Clear();
        }

        public void DoCapsAction()
        {
            string manufactory;
            string name;
            string strenght;
            string matireal;
            int number;
            int prise;

            string answ = Console.ReadLine();
            if (answ == "1")
            {
                shop.AddBoxInfo(out number, out prise, out manufactory, out name, out strenght, out matireal);
                shop.AddCapsInfo(number, prise,  manufactory, name, strenght, matireal );
                Return();
                ChoisCapsMenu();
            }
            else if (answ == "2")
            {
                shop.ShowCapsInfo();
                Return();
                ChoisCapsMenu();
            }
            else if (answ == "3")
            {
                Console.Clear();
                MainBoxMenu();
            }
        }
        public void DoGlovesAction()
        {
            string manufactory;
            string name;
            string strenght;
            string matireal;
            int number;
            int prise;

            string answ = Console.ReadLine();
            if (answ == "1")
            {
                
                shop.AddBoxInfo(out number, out prise, out manufactory, out name, out strenght, out matireal);
                shop.AddGlovesInfo(number, prise, manufactory, name, strenght, matireal);
                Return();
                ChoisGlovesMenu();
            }
            else if (answ == "2")
            {
                shop.ShowGlovesInfo();
                Return();
                ChoisGlovesMenu();
            }
            else if (answ == "3")
            {
                Console.Clear();
                MainBoxMenu();
            }
        }
        public void DoPointAction()
        {
            string name;
            int prise;
            string manufactory;
            int number;
            string ageGroup;
            string color;
            
            string answ = Console.ReadLine();
            if (answ == "1")
            {
                shop.AddBalletInfo(out name, out prise, out manufactory, out number, out ageGroup, out color);
                shop.AddPointInfo(name, prise, manufactory, number, ageGroup, color);
                Return();
                ChoisPointMenu();
            }
            else if (answ == "2")
            {
                shop.ShowPointInfo();
                Return();
                ChoisPointMenu();
            }
            else if (answ == "3")
            {
                Console.Clear();
                MainBalletMenu();
            }
        }
        public void DoBundleAction()
        {
            string name;
            int prise;
            string manufactory;
            int number;
            string ageGroup;
            string color;

            string answ = Console.ReadLine();
            if (answ == "1")
            {
                shop.AddBalletInfo(out name, out prise, out manufactory, out number, out ageGroup, out color);
                shop.AddBundleInfo(name, prise, manufactory, number, ageGroup, color);
                Return();
                ChoisBundleMenu();
            }
            else if (answ == "2")
            {
                shop.ShowBundleInfo();
                Return();
                ChoisBundleMenu();
            }
            else if (answ == "3")
            {
                Console.Clear();
                MainBalletMenu();
            }
        }
        void Return()
        {
            string back;
            do
            {
                Console.WriteLine("\nНажмите '0' для возврата в главное меню\n");
                back = Console.ReadLine();
            }
            while (back != "0");
            Console.Clear();
        }
    }
}
