using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tankkk
{
    internal class Tank
    {
      
        public int ammo = 50;
        public string type;
        public int year;

        public Tank(int ammo, string type, int year)
        {

            this.ammo = ammo;
            this.type = type;
            this.year = year;


            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your name: ");
            string name2 = Console.ReadLine();
            
            Console.WriteLine("Player 1's turn: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(b + " " + "bullets were shot out");


            int attackEnemy = int.Parse(Console.ReadLine());
            if (attackEnemy == 1)
            {
                Console.WriteLine("Damage: 10");
                Console.WriteLine("Player 2 lost 10 health");
            }


            Console.WriteLine("Player 2's turn: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine(B + " " + "bullets were shot out");

            int attack = int.Parse(Console.ReadLine());
            if (attack == 3)
            {
                Console.WriteLine("Damage: 30");
                Console.WriteLine("Player 1 lost 30 health");
            }

        }

    }
}
