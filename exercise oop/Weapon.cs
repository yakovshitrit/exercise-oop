using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise_oop
{
    internal class Weapon
    {
        string NameType;
        string Manufacturer;
        int AssaultBalls;

        public Weapon(string type, string manufacturer, int assaultballs)
        {
            this.NameType = type;
            this.Manufacturer = manufacturer;
            this.AssaultBalls = assaultballs;
        }
        public int Shoot()
        {
            if (AssaultBalls >= 1)
            {
                AssaultBalls -= 1;
             
            }
            else
            {
                Console.WriteLine("There are no bullets in the barrel.");
            }
            return AssaultBalls;
                
        }



    }
}
