using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int health;
        static string name;
        static void Main()
        {
            health = 100;
            name = "dylan";

            ShowHud();

            Console.ReadKey(true);
        }
        static void TakeDamage(int hp)
        {
            health = health - hp;
        }

        static void ShowHud()
        {
            Console.WriteLine(name);
            Console.WriteLine(health);
        }
    }

}
