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
        static int lives;
        static int score;
        static string name;
        static void Main()
        {
            health = 100;
            name = "dylan";
            score = 0;
            lives = 3;


            ShowHud();
            Console.WriteLine("Punched by Troll");
            TakeDamage(10);
            ShowHud();
            Console.WriteLine("Killed Troll");
            GainScore(10);
            ShowHud();
            Console.WriteLine("Fell of a cliff");
            TakeLife(1);
            ShowHud();
            Console.WriteLine("Hit a Jackpot");
            GainScore(1000000);
            ShowHud();
            Console.WriteLine("Violently Mugged");
            LoseScore(1000000);
            TakeDamage(89);
            ShowHud();


            Console.ReadKey(true);
        }

        static void GainScore(int winner)
        {
            score = score + winner;
        }
        static void LoseScore(int trash)
        {
            score = score - trash;
        }
        static void TakeLife(int llost)
        {
            lives = lives - llost;
        }
        static void TakeDamage(int hp)
        {
            health = health - hp;
        }

        static void ShowHud()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(name);
            Console.WriteLine("HP = " + health);
            Console.WriteLine("Score = " + score);
            Console.WriteLine("Lives = " + lives);
            Console.WriteLine("--------------------");
        }
    }

}
